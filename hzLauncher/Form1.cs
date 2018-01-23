using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IWshRuntimeLibrary;
using DevComponents.DotNetBar;
using System.IO;

namespace hzLauncher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            String[] fileName = (String[])e.Data.GetData(DataFormats.FileDrop);

            if (System.IO.Directory.Exists(fileName[0]))
            {

            }
            else
            {
                FileInfo i = new FileInfo(fileName[0]);
                if(i.Extension.ToLower() == ".lnk"){
                    WshShell shell = new WshShell();
                    IWshShortcut link = (IWshShortcut)shell.CreateShortcut(fileName[0]);
                    String targetPath = link.TargetPath;
                    handleNewRac(targetPath);
                }else{
                    handleNewRac(fileName[0]);
                }


            }

            
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }


        private bool handleNewRac(string fn)
        {
            System.IO.FileInfo fi = new System.IO.FileInfo(fn);
            Image icon = Extends.utils.getIconX(fn);
            Button c = new Button();

            ButtonX b = Extends.utils.cloneControl(btn);
            b.Image = icon ?? Properties.Resources.if_gnome_app_install_23871;
            b.Text = fi.Name.Replace(fi.Extension, "");

            slider.Controls.Add(b);
            b.Left = ((slider.Controls.Count - 1) * (btn.Width + 10));
            b.Top = 0;
            b.Visible = true;
            b.Click += (object s, EventArgs e) =>
            {
                this.Text = b.Parent.Name;
            };

            return false;
        }
    }
}
