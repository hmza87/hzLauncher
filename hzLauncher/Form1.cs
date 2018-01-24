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
using hzLauncher.Extends;

namespace hzLauncher
{
    public partial class Form1 : Form
    {
        public Model model;
        public Form1()
        {
            InitializeComponent();
            model = new Model();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn.Parent = this;
            slider.Controls.Clear();
            btn.Parent = slider;
            init_();
        }

        private void init_()
        {
            foreach (ShortCut s in model.shurtcuts())
            {
                System.IO.FileInfo fi = new System.IO.FileInfo(s.uri);
                Image icon = Extends.utils.getIconX(s.uri);
                
                ButtonX b = Extends.utils.cloneControl(btn);
                b.Image = icon ?? Properties.Resources.if_gnome_app_install_23871;
                b.Text = s.name;

                slider.Controls.Add(b);
                b.Left = ((slider.Controls.Count - 1) * (btn.Width + 10));
                b.Top = 0;
                b.Visible = true;
            }
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            String[] fileName = (String[])e.Data.GetData(DataFormats.FileDrop);

            if (System.IO.Directory.Exists(fileName[0]))
            {
                handleNewFolder(fileName[0]);
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
            model.insert(fi.Name.Replace(fi.Extension, ""), fn, "").commit().load();
            init_();

            return true;
        }

        private bool handleNewFolder(string fld)
        {

            return true;
        }
    }
}
