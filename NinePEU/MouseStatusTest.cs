using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NinePEU
{
    public partial class MouseStatusTest : Form
    {
        public MouseStatusTest()
        {
            InitializeComponent();
            //버튼 마우스 Up 이벤트 선언

            Clicking.MouseUp += Clicking_Click;
        }
        private void Clicking_Click(object sender, EventArgs e)
        {
            stat.BorderColor = Color.Lime;
            stat.Texts = "Recognized!";
            Clicking.BackgroundColor = Color.FromArgb(128, 255, 128);
        }
    }
}
