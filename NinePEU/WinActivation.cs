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

namespace NinePEU
{
    public partial class WinActivation : Form
    {
        public static bool IsWindowsActivated()
        {
            ManagementScope scope = new ManagementScope(@"\\" + System.Environment.MachineName + @"\root\cimv2");
            scope.Connect();

            SelectQuery searchQuery = new SelectQuery("SELECT * FROM SoftwareLicensingProduct WHERE ApplicationID = '55c92734-d682-4d71-983e-d6ec3f16059f' and LicenseStatus = 1");
            ManagementObjectSearcher searcherObj = new ManagementObjectSearcher(scope, searchQuery);

            using (ManagementObjectCollection obj = searcherObj.Get())
            {
                return obj.Count > 0;
            }
        }
        public WinActivation()
        {
            InitializeComponent();
            AtStat.Enabled = false;
            Version.Items.Add("Windows11 Pro");
            Version.Items.Add("Windows10 Pro");
            Version.Items.Add("Windows11 Pro Education");
            Version.Items.Add("Windows10 Pro Education");
            Version.Items.Add("Windows11 Home");
            Version.Items.Add("Windows10 Home");
            Version.Items.Add("Windows11 Enterprise");
            Version.Items.Add("Windows10 Enterprise");
            Version.Items.Add("Windows Server 2022 DataCenter");
            Version.Items.Add("Windows Server 2022 Standard");
            Version.Items.Add("Windows Server 2019 Datacenter");
            Version.Items.Add("Windows Server 2019 Standard");
            Version.Items.Add("Windows Server 2019 Essential");
            Version.Items.Add("Windows8.1 Pro");
            Version.Items.Add("Windows8.1 Enterprise");
            Version.Items.Add("Windows7 Professional");
            Version.Items.Add("Windows7 Enterprise");
        }

        private void WinActivation_Load(object sender, EventArgs e)
        {
            if (IsWindowsActivated())
            {
                AtStat.BorderColor = Color.Lime;
                AtStat.Texts = "Activated!";
            }
            else
            {
                AtStat.BorderColor = Color.Red;
                AtStat.Texts = "Not Activated or Cannot Recognize!";
            }
        }

        private void Activate_Click(object sender, EventArgs e)
        {
            string venvalue = Version.SelectedItem.ToString();
            if (MessageBox.Show($"You Selected {venvalue}.\n당신은 {venvalue}를 선택하셨습니다.\n\nDo you Want to Proceed? 진행하시겠습니까?", "NinePEU - 알림", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("It could be take few minutes.\n이 작업은 시간이 소요되는 작업입니다.", "Time Alert");
                MessageBox.Show(venvalue);
            }
            else
            {
                MessageBox.Show("아니요 클릭");
            }
        }
    }
}
