namespace UserControlTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var myButton = new MyButtonControl();
            myButton.Location = new Point(30, 30);
            myButton.Size = new Size(150, 50);

            // ����� ���� ��Ʈ���� �̺�Ʈ ���
            myButton.MyClick += (s, e) =>
            {
                MessageBox.Show("����� ���� ��Ʈ�� ��ư Ŭ��!");
            };

            this.Controls.Add(myButton);
        }
    }
}
