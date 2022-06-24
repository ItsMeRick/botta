namespace sific
{
    partial class KeySystemUI
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
            this.keybox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.GETKEY = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneElipse1 = new Siticone.Desktop.UI.WinForms.SiticoneElipse(this.components);
            this.siticoneElipse2 = new Siticone.Desktop.UI.WinForms.SiticoneElipse(this.components);
            this.siticoneDragControl1 = new Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticoneButton1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.submitbutton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneElipse3 = new Siticone.Desktop.UI.WinForms.SiticoneElipse(this.components);
            this.siticonePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // keybox
            // 
            this.keybox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.keybox.DefaultText = "";
            this.keybox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.keybox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.keybox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.keybox.DisabledState.Parent = this.keybox;
            this.keybox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.keybox.FillColor = System.Drawing.SystemColors.ControlDarkDark;
            this.keybox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.keybox.FocusedState.Parent = this.keybox;
            this.keybox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.keybox.ForeColor = System.Drawing.Color.White;
            this.keybox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.keybox.HoverState.Parent = this.keybox;
            this.keybox.Location = new System.Drawing.Point(224, 159);
            this.keybox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.keybox.Name = "keybox";
            this.keybox.PasswordChar = '●';
            this.keybox.PlaceholderForeColor = System.Drawing.Color.White;
            this.keybox.PlaceholderText = "";
            this.keybox.SelectedText = "";
            this.keybox.ShadowDecoration.Parent = this.keybox;
            this.keybox.Size = new System.Drawing.Size(150, 29);
            this.keybox.TabIndex = 0;
            this.keybox.TextChanged += new System.EventHandler(this.siticoneTextBox1_TextChanged);
            // 
            // GETKEY
            // 
            this.GETKEY.CheckedState.Parent = this.GETKEY;
            this.GETKEY.CustomImages.Parent = this.GETKEY;
            this.GETKEY.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GETKEY.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GETKEY.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GETKEY.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GETKEY.DisabledState.Parent = this.GETKEY;
            this.GETKEY.FillColor = System.Drawing.Color.Gray;
            this.GETKEY.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GETKEY.ForeColor = System.Drawing.Color.White;
            this.GETKEY.HoverState.FillColor = System.Drawing.Color.SteelBlue;
            this.GETKEY.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GETKEY.HoverState.Parent = this.GETKEY;
            this.GETKEY.Location = new System.Drawing.Point(230, 235);
            this.GETKEY.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GETKEY.Name = "GETKEY";
            this.GETKEY.ShadowDecoration.Parent = this.GETKEY;
            this.GETKEY.Size = new System.Drawing.Size(135, 37);
            this.GETKEY.TabIndex = 1;
            this.GETKEY.Text = "Get Key";
            this.GETKEY.Click += new System.EventHandler(this.GETKEY_Click);
            // 
            // siticoneElipse1
            // 
            this.siticoneElipse1.BorderRadius = 20;
            this.siticoneElipse1.TargetControl = this.GETKEY;
            // 
            // siticoneElipse2
            // 
            this.siticoneElipse2.BorderRadius = 20;
            this.siticoneElipse2.TargetControl = this.keybox;
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.TargetControl = this.siticonePanel1;
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BackColor = System.Drawing.Color.White;
            this.siticonePanel1.Controls.Add(this.siticoneButton1);
            this.siticonePanel1.Location = new System.Drawing.Point(0, 1);
            this.siticonePanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.ShadowDecoration.Parent = this.siticonePanel1;
            this.siticonePanel1.Size = new System.Drawing.Size(600, 22);
            this.siticonePanel1.TabIndex = 2;
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.CheckedState.Parent = this.siticoneButton1;
            this.siticoneButton1.CustomImages.Parent = this.siticoneButton1;
            this.siticoneButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton1.DisabledState.Parent = this.siticoneButton1;
            this.siticoneButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.HoverState.Parent = this.siticoneButton1;
            this.siticoneButton1.Location = new System.Drawing.Point(571, 0);
            this.siticoneButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.ShadowDecoration.Parent = this.siticoneButton1;
            this.siticoneButton1.Size = new System.Drawing.Size(29, 22);
            this.siticoneButton1.TabIndex = 0;
            this.siticoneButton1.Text = "X";
            this.siticoneButton1.Click += new System.EventHandler(this.siticoneButton1_Click);
            // 
            // submitbutton
            // 
            this.submitbutton.CheckedState.Parent = this.submitbutton;
            this.submitbutton.CustomImages.Parent = this.submitbutton;
            this.submitbutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.submitbutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.submitbutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.submitbutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.submitbutton.DisabledState.Parent = this.submitbutton;
            this.submitbutton.FillColor = System.Drawing.Color.Gray;
            this.submitbutton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.submitbutton.ForeColor = System.Drawing.Color.White;
            this.submitbutton.HoverState.FillColor = System.Drawing.Color.SteelBlue;
            this.submitbutton.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitbutton.HoverState.Parent = this.submitbutton;
            this.submitbutton.Location = new System.Drawing.Point(230, 193);
            this.submitbutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.submitbutton.Name = "submitbutton";
            this.submitbutton.ShadowDecoration.Parent = this.submitbutton;
            this.submitbutton.Size = new System.Drawing.Size(135, 37);
            this.submitbutton.TabIndex = 3;
            this.submitbutton.Text = "Submit";
            this.submitbutton.Click += new System.EventHandler(this.submitbutton_Click);
            // 
            // siticoneElipse3
            // 
            this.siticoneElipse3.BorderRadius = 20;
            this.siticoneElipse3.TargetControl = this.submitbutton;
            // 
            // KeySystemUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.submitbutton);
            this.Controls.Add(this.siticonePanel1);
            this.Controls.Add(this.GETKEY);
            this.Controls.Add(this.keybox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "KeySystemUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KeySystemUI";
            this.siticonePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneTextBox keybox;
        private Siticone.Desktop.UI.WinForms.SiticoneButton GETKEY;
        private Siticone.Desktop.UI.WinForms.SiticoneElipse siticoneElipse1;
        private Siticone.Desktop.UI.WinForms.SiticoneElipse siticoneElipse2;
        private Siticone.Desktop.UI.WinForms.SiticoneDragControl siticoneDragControl1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton submitbutton;
        private Siticone.Desktop.UI.WinForms.SiticoneElipse siticoneElipse3;
    }
}