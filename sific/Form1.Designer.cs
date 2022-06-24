namespace sific
{
    partial class Sific
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
            this.sific_top_text = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sificbox = new System.Windows.Forms.TextBox();
            this.exit_button = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.button_start = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneDragControl1 = new Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sific_top_text
            // 
            this.sific_top_text.BackColor = System.Drawing.Color.Transparent;
            this.sific_top_text.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sific_top_text.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sific_top_text.Location = new System.Drawing.Point(329, 153);
            this.sific_top_text.Name = "sific_top_text";
            this.sific_top_text.Size = new System.Drawing.Size(119, 33);
            this.sific_top_text.TabIndex = 0;
            this.sific_top_text.Text = "SIFIC";
            this.sific_top_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sific_top_text.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.sificbox);
            this.panel1.Controls.Add(this.exit_button);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 25);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // sificbox
            // 
            this.sificbox.BackColor = System.Drawing.Color.Black;
            this.sificbox.Font = new System.Drawing.Font("MV Boli", 7.8F);
            this.sificbox.ForeColor = System.Drawing.Color.White;
            this.sificbox.Location = new System.Drawing.Point(3, 2);
            this.sificbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sificbox.Name = "sificbox";
            this.sificbox.Size = new System.Drawing.Size(77, 28);
            this.sificbox.TabIndex = 5;
            this.sificbox.Text = "SificHACKS";
            this.sificbox.TextChanged += new System.EventHandler(this.sificbox_TextChanged);
            // 
            // exit_button
            // 
            this.exit_button.CheckedState.Parent = this.exit_button;
            this.exit_button.CustomImages.Parent = this.exit_button;
            this.exit_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.exit_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.exit_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exit_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.exit_button.DisabledState.Parent = this.exit_button;
            this.exit_button.FillColor = System.Drawing.Color.Transparent;
            this.exit_button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exit_button.ForeColor = System.Drawing.Color.White;
            this.exit_button.HoverState.FillColor = System.Drawing.Color.Gray;
            this.exit_button.HoverState.Parent = this.exit_button;
            this.exit_button.Location = new System.Drawing.Point(763, 0);
            this.exit_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exit_button.Name = "exit_button";
            this.exit_button.PressedColor = System.Drawing.Color.LightGray;
            this.exit_button.ShadowDecoration.Parent = this.exit_button;
            this.exit_button.Size = new System.Drawing.Size(39, 25);
            this.exit_button.TabIndex = 4;
            this.exit_button.Text = "X";
            this.exit_button.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // button_start
            // 
            this.button_start.CheckedState.Parent = this.button_start;
            this.button_start.CustomImages.Parent = this.button_start;
            this.button_start.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_start.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_start.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_start.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_start.DisabledState.Parent = this.button_start;
            this.button_start.FillColor = System.Drawing.Color.White;
            this.button_start.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_start.ForeColor = System.Drawing.Color.Black;
            this.button_start.HoverState.BorderColor = System.Drawing.Color.Red;
            this.button_start.HoverState.CustomBorderColor = System.Drawing.Color.Red;
            this.button_start.HoverState.FillColor = System.Drawing.Color.SteelBlue;
            this.button_start.HoverState.Parent = this.button_start;
            this.button_start.Location = new System.Drawing.Point(297, 190);
            this.button_start.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_start.Name = "button_start";
            this.button_start.ShadowDecoration.Parent = this.button_start;
            this.button_start.Size = new System.Drawing.Size(180, 46);
            this.button_start.TabIndex = 3;
            this.button_start.Text = "start ";
            this.button_start.Click += new System.EventHandler(this.siticoneButton1_Click);
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.TargetControl = this.panel1;
            // 
            // Sific
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sific_top_text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Sific";
            this.Text = "Sific";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label sific_top_text;
        private System.Windows.Forms.Panel panel1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton button_start;
        private Siticone.Desktop.UI.WinForms.SiticoneButton exit_button;
        private System.Windows.Forms.TextBox sificbox;
        private Siticone.Desktop.UI.WinForms.SiticoneDragControl siticoneDragControl1;
    }
}

