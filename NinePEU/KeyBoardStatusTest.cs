using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NinePEU
{
    public partial class KeyBoardStatusTest : Form
    {
        ConsoleKeyInfo cki;
        public void keytest()
        {
            if (MessageBox.Show("키보드 테스트를 진행합니다.\n", "NinePEU - 알림", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Console.Beep();
                System.Threading.Thread.Sleep(1000);
                Console.Beep();
                System.Threading.Thread.Sleep(1000);
                Console.Beep();
            }
            else
            {
                MessageBox.Show("아니요 클릭");
            }
        }
        
        public KeyBoardStatusTest()
        {
            InitializeComponent();
        }

        private void KeyBoardStatusTest_Load(object sender, EventArgs e)
        {
            // KeyName.Text = " ";
            KeyBox.Enabled = false;
        }

        private void kinput_test_Click(object sender, EventArgs e)
        {
            keytest();
        }

        private void spkeytest_Click(object sender, EventArgs e)
        {

        }

        private void KeyBox_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void KeyBoardStatusTest_KeyDown(object sender, KeyEventArgs e)
        {
            /*Console.Beep();
            cki = */
            KeyBox.Texts = $"{e.KeyCode} is Pressed.";
            while (e.KeyCode == Keys.Escape) Environment.Exit(0);
        }
    }
}
