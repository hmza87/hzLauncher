namespace hzLauncher.Views
{
    partial class Default_launcher
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
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.slider = new DevComponents.DotNetBar.PanelEx();
            this.ExampleBTN = new DevComponents.DotNetBar.ButtonX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.panelEx1.SuspendLayout();
            this.slider.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.slider);
            this.panelEx1.Controls.Add(this.buttonX2);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(747, 80);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // slider
            // 
            this.slider.CanvasColor = System.Drawing.SystemColors.Control;
            this.slider.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.slider.Controls.Add(this.ExampleBTN);
            this.slider.DisabledBackColor = System.Drawing.Color.Empty;
            this.slider.Dock = System.Windows.Forms.DockStyle.Top;
            this.slider.Location = new System.Drawing.Point(0, 0);
            this.slider.Name = "slider";
            this.slider.Size = new System.Drawing.Size(747, 78);
            this.slider.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.slider.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.slider.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.slider.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.slider.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.slider.Style.GradientAngle = 90;
            this.slider.TabIndex = 3;
            // 
            // ExampleBTN
            // 
            this.ExampleBTN.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ExampleBTN.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ExampleBTN.FocusCuesEnabled = false;
            this.ExampleBTN.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExampleBTN.Image = global::hzLauncher.Properties.Resources.if_gnome_app_install_23871;
            this.ExampleBTN.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.ExampleBTN.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.ExampleBTN.ImageTextSpacing = 5;
            this.ExampleBTN.Location = new System.Drawing.Point(25, 0);
            this.ExampleBTN.Name = "ExampleBTN";
            this.ExampleBTN.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.ExampleBTN.Size = new System.Drawing.Size(67, 78);
            this.ExampleBTN.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ExampleBTN.TabIndex = 1;
            this.ExampleBTN.Text = "buttonX1";
            this.ExampleBTN.Visible = false;
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Location = new System.Drawing.Point(666, 136);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(20, 24);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 2;
            this.buttonX2.Text = "X";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2012Dark;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // Default_launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 80);
            this.ControlBox = false;
            this.Controls.Add(this.panelEx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Default_launcher";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "hzLauncher Beta";
            this.Load += new System.EventHandler(this.Default_launcher_Load);
            this.panelEx1.ResumeLayout(false);
            this.slider.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.ButtonX ExampleBTN;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.PanelEx slider;
    }
}