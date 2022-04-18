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
                if (MessageBox.Show("You need to turn off the vaccination Program.\n이 기능을 실행하기 전 백신 프로그램을 반드시 꺼주세요. 바이러스로 오진할 수 있어요", "NinePEU - 알림", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    WinActivation Winactive = new WinActivation();
                    Winactive.ShowDialog();
                }
                else
                {
                    MessageBox.Show("종료되었습니다.");
                    Environment.Exit(0);
                }
            }
            else
            {
                MessageBox.Show("You need to Start This program as ADMINISTRATOR\n당신은 이 프로그램을 관리자 권한으로 시작해야합니다", "Permission Error");
            }
        }
    }
}
