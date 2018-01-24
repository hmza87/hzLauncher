namespace hzLauncher
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn = new DevComponents.DotNetBar.ButtonX();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.slider = new DevComponents.DotNetBar.PanelEx();
            this.slider.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btn.FocusCuesEnabled = false;
            this.btn.Image = global::hzLauncher.Properties.Resources.if_gnome_app_install_23871;
            this.btn.ImageFixedSize = new System.Drawing.Size(64, 64);
            this.btn.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btn.Location = new System.Drawing.Point(3, 3);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(84, 103);
            this.btn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn.TabIndex = 1;
            this.btn.Text = "buttonX1";
            this.btn.Visible = false;
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Black;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // slider
            // 
            this.slider.CanvasColor = System.Drawing.SystemColors.Control;
            this.slider.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.slider.Controls.Add(this.btn);
            this.slider.DisabledBackColor = System.Drawing.Color.Empty;
            this.slider.Dock = System.Windows.Forms.DockStyle.Top;
            this.slider.Location = new System.Drawing.Point(0, 0);
            this.slider.Name = "slider";
            this.slider.Size = new System.Drawing.Size(1057, 148);
            this.slider.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.slider.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.slider.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.slider.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.slider.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.slider.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.slider.Style.GradientAngle = 90;
            this.slider.TabIndex = 1;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 153);
            this.Controls.Add(this.slider);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.slider.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btn;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.PanelEx slider;
    }
}

