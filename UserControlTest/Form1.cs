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

            // 사용자 정의 컨트롤의 이벤트 사용
            myButton.MyClick += (s, e) =>
            {
                MessageBox.Show("사용자 정의 컨트롤 버튼 클릭!");
            };

            this.Controls.Add(myButton);
        }
    }
}
