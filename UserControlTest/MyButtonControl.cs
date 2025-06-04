using System;
using System.Windows.Forms;
using System.Drawing;

namespace UserControlTest
{
    public partial class MyButtonControl : UserControl
    {
        private void InitializeComponent()
        {
            // �ʿ��� �ʱ�ȭ �ڵ� �ۼ�
        }

        private Button button1;

        public MyButtonControl()
        {
            InitializeComponent();

            button1 = new Button();
            button1.Text = "Ŀ���� ��ư";
            button1.Dock = DockStyle.Fill;
            button1.BackColor = Color.LightSkyBlue;
            button1.Click += Button1_Click;

            this.Controls.Add(button1);
        }

        // �ܺο��� Ŭ�� �̺�Ʈ�� ����� �� �ֵ��� �̺�Ʈ ����
        public event EventHandler MyClick
        {
            add { button1.Click += value; }
            remove { button1.Click -= value; }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // �ʿ�� ���� ó��
        }
    }
}
