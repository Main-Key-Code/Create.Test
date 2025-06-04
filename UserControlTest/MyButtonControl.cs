using System;
using System.Windows.Forms;
using System.Drawing;

namespace UserControlTest
{
    public partial class MyButtonControl : UserControl
    {
        private void InitializeComponent()
        {
            // 필요한 초기화 코드 작성
        }

        private Button button1;

        public MyButtonControl()
        {
            InitializeComponent();

            button1 = new Button();
            button1.Text = "커스텀 버튼";
            button1.Dock = DockStyle.Fill;
            button1.BackColor = Color.LightSkyBlue;
            button1.Click += Button1_Click;

            this.Controls.Add(button1);
        }

        // 외부에서 클릭 이벤트를 사용할 수 있도록 이벤트 노출
        public event EventHandler MyClick
        {
            add { button1.Click += value; }
            remove { button1.Click -= value; }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // 필요시 내부 처리
        }
    }
}
