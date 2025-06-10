 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Panel.In.ButtonTopBottom.Control
{
    public partial class ButtonDrawing : Form
    {
        public ButtonDrawing()
        {
            InitializeComponent();
        }

        private void ButtonDrawing_Load(object sender, EventArgs e)
        {
            var buttonDrawing = new Controls.ButtonDrawing();

            System.Windows.Forms.Panel panel = buttonDrawing.ShowPanel(this); // Use the instance to call ShowPanel()
            this.Controls.Add(panel); // Add the returned panel to the form's controls

        }
    }
}
