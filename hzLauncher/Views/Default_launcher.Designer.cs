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
            this.edit_menu = new DevComponents.DotNetBar.PanelEx();
            this.edit_a_btn = new DevComponents.DotNetBar.ButtonX();
            this.rem_a_btn = new DevComponents.DotNetBar.ButtonX();
            this.slider = new DevComponents.DotNetBar.PanelEx();
            this.ExampleBTN = new DevComponents.DotNetBar.ButtonX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.panelEx1.SuspendLayout();
            this.edit_menu.SuspendLayout();
            this.slider.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.edit_menu);
            this.panelEx1.Controls.Add(this.slider);
            this.panelEx1.Controls.Add(this.buttonX2);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(747, 170);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            this.panelEx1.Click += new System.EventHandler(this.panelEx1_Click);
            // 
            // edit_menu
            // 
            this.edit_menu.CanvasColor = System.Drawing.SystemColors.Control;
            this.edit_menu.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.edit_menu.Controls.Add(this.edit_a_btn);
            this.edit_menu.Controls.Add(this.rem_a_btn);
            this.edit_menu.DisabledBackColor = System.Drawing.Color.Empty;
            this.edit_menu.Location = new System.Drawing.Point(173, 86);
            this.edit_menu.Name = "edit_menu";
            this.edit_menu.Size = new System.Drawing.Size(123, 74);
            this.edit_menu.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.edit_menu.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.edit_menu.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.edit_menu.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.edit_menu.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.edit_menu.Style.GradientAngle = 90;
            this.edit_menu.TabIndex = 4;
            // 
            // edit_a_btn
            // 
            this.edit_a_btn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.edit_a_btn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.edit_a_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.edit_a_btn.FocusCuesEnabled = false;
            this.edit_a_btn.Location = new System.Drawing.Point(0, 36);
            this.edit_a_btn.Name = "edit_a_btn";
            this.edit_a_btn.PopupSide = DevComponents.DotNetBar.ePopupSide.Left;
            this.edit_a_btn.Size = new System.Drawing.Size(123, 35);
            this.edit_a_btn.StopPulseOnMouseOver = false;
            this.edit_a_btn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.edit_a_btn.SymbolSize = 10F;
            this.edit_a_btn.TabIndex = 1;
            this.edit_a_btn.Text = "Edit";
            // 
            // rem_a_btn
            // 
            this.rem_a_btn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.rem_a_btn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.rem_a_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.rem_a_btn.FocusCuesEnabled = false;
            this.rem_a_btn.Location = new System.Drawing.Point(0, 0);
            this.rem_a_btn.Name = "rem_a_btn";
            this.rem_a_btn.PopupSide = DevComponents.DotNetBar.ePopupSide.Left;
            this.rem_a_btn.Size = new System.Drawing.Size(123, 36);
            this.rem_a_btn.StopPulseOnMouseOver = false;
            this.rem_a_btn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.rem_a_btn.SymbolSize = 10F;
            this.rem_a_btn.TabIndex = 0;
            this.rem_a_btn.Text = "Remove";
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
            this.slider.Size = new System.Drawing.Size(747, 80);
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
            this.ClientSize = new System.Drawing.Size(747, 170);
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
            this.edit_menu.ResumeLayout(false);
            this.slider.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.ButtonX ExampleBTN;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.PanelEx slider;
        private DevComponents.DotNetBar.PanelEx edit_menu;
        private DevComponents.DotNetBar.ButtonX rem_a_btn;
        private DevComponents.DotNetBar.ButtonX edit_a_btn;
    }
}