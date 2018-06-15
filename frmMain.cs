using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using myFunctions;

namespace IPchanger
{
    public partial class frmMain : Form
    {

        IPwork IPdev;
        bool newIPcheck;

        public frmMain()
        {
            InitializeComponent();
        }


        private void frmMain_Load(object sender, EventArgs e)
        {
            string ver = System.Reflection.Assembly.GetEntryAssembly().GetName().Version.ToString();
            this.Text += " - v"  + ver.Substring(0, ver.Length - 2);
            netRefresh();
            IPdev = new IPwork("networks.xml");
            loadProfile();
            loadList(0);

            // ----- minimalize to tray -----
            notifyIcon1.Visible = true;
            //notifyIcon1.ShowBalloonTip(500);
            this.Hide();

            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = true;

            string notText = IPdev.getIPstring(cbNetwork.Text);
            if (notText.Length > 63) notText = notText.Substring(0, 63);
            notifyIcon1.Text = notText;
            newIPcheck = false;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            IPdev.Save();
        }

        private void loadProfile()
        {
            List<ipItem> list = IPdev.GetList();
            cbProfile.Items.Clear();
            mnuProfiles.DropDownItems.Clear();

            for (int i = 0; i < list.Count; i++)
            {
                cbProfile.Items.Add(list[i].name);

                ToolStripMenuItem item = new ToolStripMenuItem();
                item.Name = "mnuProfile" + list[i].name;
                item.Text = list[i].name;
                item.Tag = i;
                item.Click += new EventHandler(mnuProfilesItem_Click);
                mnuProfiles.DropDownItems.Add(item);
            }
        }

        private void loadList(int index)
        {
            List<ipItem> list = IPdev.GetList();
            if (index >= list.Count || index < 0)
            {
                cbProfile.Text = "";
                cbNetwork.Text = "";
                chbSetIP.Checked = false;
                rbIPauto.Checked = true;
                txtIPaddress.Text = "";
                txtIPmask.Text = "";
                txtGateway.Text = "";
                chbSetDNS.Checked = false;
                rbDNSauto.Checked = true;
                txtDNS1.Text = "";
                txtDNS2.Text = "";
                return;
            }

            cbProfile.Text = list[index].name;
            cbNetwork.Text = list[index].network;
            chbSetIP.Checked = list[index].changeIP;
            if (list[index].autoIP) rbIPauto.Checked = true;
            else rbIPmanual.Checked = true;
            txtIPaddress.Text = list[index].IP;
            txtIPmask.Text = list[index].mask;
            txtGateway.Text = list[index].gateway;
            chbSetDNS.Checked = list[index].changeDNS;
            if (list[index].autoDNS) rbDNSauto.Checked = true;
            else rbDNSmanual.Checked = true;
            txtDNS1.Text = list[index].DNS1;
            txtDNS2.Text = list[index].DNS2;
        }

        private void cbProfile_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadList(cbProfile.SelectedIndex);
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            ipItem item = new ipItem();
            item.name = cbProfile.Text;
            item.network = cbNetwork.Text;
            item.changeIP = chbSetIP.Checked;
            if (rbIPauto.Checked) item.autoIP = true;
            else item.autoIP = false;
            item.IP = txtIPaddress.Text;
            item.mask = txtIPmask.Text;
            item.gateway = txtGateway.Text;
            item.changeDNS = chbSetDNS.Checked;
            if (rbDNSauto.Checked) item.autoDNS = true;
            else item.autoDNS = false;
            item.DNS1 = txtDNS1.Text;
            item.DNS2 = txtDNS2.Text;
            try
            {
                IPdev.changeIP(item);
                Dialogs.ShowInfo("IP updated!", "Info");
            }
            catch (Exception err)
            {
                Dialogs.ShowErr(err.Message, "Error");
            }
            RefreshIP();
        }

        private string RefreshIP()
        {
            string ip = IPdev.getIPstring(cbNetwork.Text);
            if (ip.Length > 63) ip = ip.Substring(0, 63);
            notifyIcon1.Text = ip;
            return ip;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ipItem item = new ipItem();
            item.name = cbProfile.Text;
            item.network = cbNetwork.Text;
            item.changeIP = chbSetIP.Checked;
            if (rbIPauto.Checked) item.autoIP = true;
            else item.autoIP = false;
            item.IP = txtIPaddress.Text;
            item.mask = txtIPmask.Text;
            item.gateway = txtGateway.Text;
            item.changeDNS = chbSetDNS.Checked;
            if (rbDNSauto.Checked) item.autoDNS = true;
            else item.autoDNS = false;
            item.DNS1 = txtDNS1.Text;
            item.DNS2 = txtDNS2.Text;

            List<ipItem> list = IPdev.GetList();
            bool edited = false;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].name == cbProfile.Text)
                {
                    IPdev.EditList(i, item);
                    edited = true;
                    break;
                }
            }
            if (!edited)
            {
                IPdev.AddList(item);
                loadProfile();
                loadList(list.Count-1);
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //this.WindowState = FormWindowState.Normal;
            this.Show();
            this.WindowState = FormWindowState.Normal;
            //this.Visible = !this.Visible;
        }

        private void mnuProfilesItem_Click(object sender, EventArgs e)
        {
            try
            {
                IPdev.ChangeIP((int)((ToolStripMenuItem)sender).Tag);
                Dialogs.ShowInfo("IP changed to: " + ((ToolStripMenuItem)sender).Text, "Info");
            }
            catch (Exception err)
            {
                Dialogs.ShowErr(err.Message, "Error");
            }
            RefreshIP();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            List<ipItem> list = IPdev.GetList();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].name == cbProfile.Text)
                {
                    IPdev.DelList(i);
                    loadProfile();
                    loadList(list.Count - 1);
                    break;
                }
            }
            
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon1.Visible = true;
                //notifyIcon1.ShowBalloonTip(500);
                this.Hide();
                //this
            }

            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon1.Visible = false;
            }
        }

        private void btnNetRefresh_Click(object sender, EventArgs e)
        {
            netRefresh();
        }

        private void netRefresh()
        {
            var adapterConfig = new ManagementClass("Win32_NetworkAdapterConfiguration");
            var networkCollection = adapterConfig.GetInstances();
            int lastIndex = cbNetwork.SelectedIndex;
            cbNetwork.Items.Clear();

            foreach (ManagementObject adapter in networkCollection)
            {
                if ((bool)adapter["IPEnabled"])
                {
                    string description = adapter["Description"] as string;
                    //string caption = adapter["Caption"] as string;

                    if (!(description.Contains("Linux USB Ethernet") || description.Contains("VirtualBox")))
                    {
                        cbNetwork.Items.Add(description);
                    }
                    
                }
            }

            if (cbNetwork.Items.Count > 0)
            {
                if (lastIndex >= 0 && lastIndex < cbNetwork.Items.Count)
                    cbNetwork.SelectedIndex = lastIndex;
                else cbNetwork.SelectedIndex = 0;
            }
            else
            {
                cbNetwork.Text = "";
            }
        }

        private void chbSetIP_CheckedChanged(object sender, EventArgs e)
        {
            if (chbSetIP.Checked)
            {
                rbIPauto.Enabled = true;
                rbIPmanual.Enabled = true;
                if (rbIPmanual.Checked)
                {
                    txtIPaddress.Enabled = true;
                    txtIPmask.Enabled = true;
                    txtGateway.Enabled = true;
                    rbDNSmanual.Checked = true;
                    rbDNSauto.Enabled = false;
                }
                else
                {
                    txtIPaddress.Enabled = false;
                    txtIPmask.Enabled = false;
                    txtGateway.Enabled = false;
                    if (chbSetDNS.Checked) rbDNSauto.Enabled = true;

                }
                
            }
            else
            {
                rbIPauto.Enabled = false;
                rbIPmanual.Enabled = false;
                txtIPaddress.Enabled = false;
                txtIPmask.Enabled = false;
                txtGateway.Enabled = false;
                if (chbSetDNS.Checked) rbDNSauto.Enabled = true;
            }
        }

        private void chbSetDNS_CheckedChanged(object sender, EventArgs e)
        {
            if (chbSetDNS.Checked)
            {
                if (chbSetIP.Checked && rbIPmanual.Checked)
                    rbDNSauto.Enabled = false;
                else
                    rbDNSauto.Enabled = true;
                rbDNSmanual.Enabled = true;
                if (rbDNSmanual.Checked)
                {
                    txtDNS1.Enabled = true;
                    txtDNS2.Enabled = true;
                }
                else
                {
                    txtDNS1.Enabled = false;
                    txtDNS2.Enabled = false;
                }
                
            }
            else
            {
                rbDNSauto.Enabled = false;
                rbDNSmanual.Enabled = false;
                txtDNS1.Enabled = false;
                txtDNS2.Enabled = false;
            }
        }

        private void btnGetIP_Click(object sender, EventArgs e)
        {
            MessageBox.Show(RefreshIP());
        }

        private void mnuGetIP_Click(object sender, EventArgs e)
        {
            MessageBox.Show(RefreshIP());
        }

        private void notifyIcon1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!newIPcheck)
            {
                newIPcheck = true;
                timer1.Enabled = true;
                RefreshIP();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            newIPcheck = false;
            timer1.Enabled = false;
        }
    }
}
