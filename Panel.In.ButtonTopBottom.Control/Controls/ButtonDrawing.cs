using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Panel.In.ButtonTopBottom.Control.Controls
{
    public partial class ButtonDrawing : UserControl
    {
        public ButtonDrawing()
        {
            InitializeComponent();
            
        }

        public System.Windows.Forms.Panel ShowPanel(Form parentForm)
        {
            System.Windows.Forms.Panel MainPnl = new System.Windows.Forms.Panel();
            MainPnl.Width = 20; // 원하는 너비
            MainPnl.Height = Convert.to(parentForm.ClientSize.Height * 0.5); // 폼의 클라이언트 높이에 맞춤
            MainPnl.Location = new Point(10 - MainPnl.Width, 0);
            MainPnl.BackColor = Color.LightGray;

            // 폼 크기 변경 시 패널 위치/크기 자동 조정
            parentForm.Resize += (s, e) =>
            {
                MainPnl.Height = parentForm.ClientSize.Height;
                MainPnl.Location = new Point(parentForm.ClientSize.Width - MainPnl.Width, 0);
            };

            return MainPnl;
        }

    }
}
