using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hzLauncher.Views
{
    public partial class Default_launcher : Form
    {
        public Default_launcher()
        {
            InitializeComponent();

            Program.launcher.drawItems(ref slider, ExampleBTN);

        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Default_launcher_Load(object sender, EventArgs e)
        {
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Left = 0;
            Top = Screen.PrimaryScreen.WorkingArea.Size.Height - this.Height;
        }        
    }
}
