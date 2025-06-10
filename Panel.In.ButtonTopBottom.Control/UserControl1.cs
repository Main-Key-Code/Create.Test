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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        public System.Windows.Forms.Panel ShowPanel()
        {
            // 틀이 되는 패널
            System.Windows.Forms.Panel MainPnl = new System.Windows.Forms.Panel();
            MainPnl.Dock = DockStyle.Fill;
            MainPnl.BorderStyle = BorderStyle.None;
            MainPnl.BackColor = Color.White;


            //// 중간 트랙바 패널
            //System.Windows.Forms.Panel innerPanel = new System.Windows.Forms.Panel();
            //MainPnl.Controls.Add(innerPanel);

            //innerPanel.Dock = DockStyle.Fill;
            //innerPanel.BackColor = Color.LightGoldenrodYellow;
            //innerPanel.BorderStyle = BorderStyle.None;

            TrackBar trackBar = new TrackBar();
            trackBar.Dock = DockStyle.Fill;
            trackBar.Minimum = 0;
            trackBar.Maximum = 100;
            trackBar.Value = 50;
            trackBar.TickFrequency = 10;
            trackBar.Orientation = Orientation.Vertical;

            //innerPanel.Controls.Add(trackBar);
            MainPnl.Controls.Add(trackBar);

            //// 상단 버튼 패널
            //System.Windows.Forms.Panel TopPnl = new System.Windows.Forms.Panel();
            //MainPnl.Controls.Add(TopPnl);
            
            //TopPnl.Dock = DockStyle.Top;
            //TopPnl.Height = 50;
            //TopPnl.BackColor = Color.LightBlue;
            //TopPnl.BorderStyle = BorderStyle.None;

            // 상단 버튼 생성
            Button buttonTop = new Button();
            buttonTop.Text = "Top";
            buttonTop.Dock = DockStyle.Top;
            buttonTop.Height = 50;
            //TopPnl.Controls.Add(buttonTop);
            MainPnl.Controls.Add(buttonTop);

            buttonTop.Click += (sender, e) =>
            {
                //MessageBox.Show("Top button clicked!");
                PictureTest pTest = new PictureTest();
                pTest.ShowDialog();

            };

            //// 하단 버튼 패널
            //System.Windows.Forms.Panel BottomPnl = new System.Windows.Forms.Panel();
            //MainPnl.Controls.Add(BottomPnl);
            //BottomPnl.Dock = DockStyle.Bottom;
            //BottomPnl.Height = 50;
            //BottomPnl.BackColor = Color.LightCoral;
            //BottomPnl.BorderStyle = BorderStyle.None;

            // 하단 버튼 생성
            Button buttonBottom = new Button();
            buttonBottom.Text = "Bottom";
            buttonBottom.Dock = DockStyle.Bottom;
            buttonBottom.Height = 50;
            //BottomPnl.Controls.Add(buttonBottom);
            MainPnl.Controls.Add(buttonBottom);

            buttonBottom.Click += (sender, e) =>
            {
                ButtonDrawing bDrawing = new ButtonDrawing();
                bDrawing.ShowDialog();

                //MessageBox.Show("Bottom button clicked!");
            };


            







            return MainPnl;
        }
     
    }
}
