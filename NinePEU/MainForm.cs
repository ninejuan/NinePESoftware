using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;
using System.Windows.Forms;

namespace NinePEU
{
    public partial class MainForm : Form
    {
        public bool Dark = false;
        bool IsUserAdministrator()
        {
            WindowsIdentity user = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(user);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }
        public MainForm()
        {
            InitializeComponent();
        }

        private void KBsTst_Click(object sender, EventArgs e)
        {
            KeyBoardStatusTest kbst = new KeyBoardStatusTest();
            kbst.ShowDialog();
        }

        private void MTest_Click(object sender, EventArgs e)
        {
            MouseStatusTest mst = new MouseStatusTest();
            mst.ShowDialog();
        }

        private void Winact_Click(object sender, EventArgs e)
        {
            if (IsUserAdministrator())
            {
                WinActivation Winactive = new WinActivation();
                Winactive.ShowDialog();
            }
            else
            {
                MessageBox.Show("You need to Start This program as ADMINISTRATOR\n당신은 이 프로그램을 관리자 권한으로 시작해야합니다", "Permission Error");
            }
        }
    }
}
