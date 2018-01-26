using DevComponents.DotNetBar;
using hzLauncher.Extends;
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
    public partial class Default_launcher : LauncherView
    {
        public Default_launcher()
        {
            InitializeComponent();

            

        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Default_launcher_Load(object sender, EventArgs e)
        {
            Program.launcher.drawItems();

            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Left = 0;
            Top = Screen.PrimaryScreen.WorkingArea.Size.Height - this.Height;
        }

        public override bool init(List<ShortCut> Shorts)
        {

            slider.Controls.Clear();
            foreach (ShortCut s in Shorts)
            {
                System.IO.FileInfo fi = new System.IO.FileInfo(s.uri);
                Image icon = Extends.utils.getIconX(s.uri);

                ButtonX b = Extends.utils.cloneControl(ExampleBTN);
                b.Image = icon ?? Properties.Resources.if_gnome_app_install_23871;
                b.Text = s.name;

                slider.Controls.Add(b);
                b.Left = ((slider.Controls.Count - 2) * (b.Width + 5));
                b.Top = 1;
                b.Height = slider.Height - 2;
                b.Visible = true;
                b.Tag = "";

              
                
                b.MouseDown += (object sender, MouseEventArgs e) =>
                {
                    if (e.Button == System.Windows.Forms.MouseButtons.Left)
                    {
                        b.Tag = "";
                        Timer timer = new Timer();
                        timer.Tick += (object that, EventArgs ee) =>
                        {

                            b.Tag = "NO";
                            startMove(b);
                            timer.Stop();
                            timer.Dispose();
                            return;
                        };
                        timer.Interval = 400;
                        timer.Start();
                    }
                    

                };


                b.MouseUp += (object sender, MouseEventArgs e) =>
                {
                    if (e.Button == System.Windows.Forms.MouseButtons.Left)
                    {
                        if ((string)b.Tag == "")
                        {
                            s.Run();
                        }

                        b.Tag = "";
                        endMove(b);
                    }
                    else if (e.Button == System.Windows.Forms.MouseButtons.Right)
                    {
                        edit(b);
                    }

                    b.Pulse();
                };

                b.MouseMove += (object sender, MouseEventArgs e) =>
                {
                    
                };

            }

            return true;
        }

       

        

        private void edit(ButtonX btn)
        {
            btn.Pulse();
            edit_menu.Left = btn.Left;
            edit_menu.Top = btn.Top;
            edit_menu.Width = btn.Width;
            edit_menu.Height = btn.Height;
            edit_menu.BringToFront();
            edit_menu.Tag = btn;

            
        }

        private void startMove(ButtonX btn)
        {
            btn.Tag = "MOVING";
            btn.Height -= 6;
            btn.Width -= 6;
            btn.Top += 3;
            btn.Left += 3;
          
        }

        private void endMove(ButtonX btn)
        {
            btn.Height += 6;
            btn.Width += 6;
            btn.Top -= 3;
            btn.Left -= 3;
        }

        private void panelEx1_Click(object sender, EventArgs e)
        {
           
        }

        


    }
}
