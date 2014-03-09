using System;
using System.Windows.Forms;

namespace HelloWinForm_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Load the form caption with current version
            Text = "Version: " + Application.ProductVersion;
            Form1_Resize((object)this, new EventArgs());
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            label2.Text = Width + "x" + Height + "  :  " + ClientSize.Width + "/" + ClientSize.Height;
            centerControl(label1);
        }

        private void centerControl(Control ctl)
        {
            ctl.Left = (ClientSize.Width / 2) - (ctl.Width / 2);
            ctl.Top = (ClientSize.Height / 2) - (ctl.Height / 2);
        }

    }
}
