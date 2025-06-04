namespace Panel.In.ButtonTopBottom.Control
{
    public partial class MainF : Form
    {
        private UserControl1 uCtrl; // Declare an instance of UserControl1  

        public MainF()
        {
            InitializeComponent();

            uCtrl = new UserControl1(); // Initialize the instance  
            System.Windows.Forms.Panel panel = uCtrl.ShowPanel(); // Use the instance to call ShowPanel()  
            this.Controls.Add(panel); // Add the returned panel to the form's controls
        }
    }
}
