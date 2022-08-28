namespace WindowsFormsApp1
{
    partial class SignupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignupForm));
            this.label1 = new System.Windows.Forms.Label();
            this.Role = new System.Windows.Forms.ComboBox();
            this.Password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.username = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Signup = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(21, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 64);
            this.label1.TabIndex = 21;
            this.label1.Text = "           SIGN UP\r\nFOR YOUR ACCOUNT\r\n";
            // 
            // Role
            // 
            this.Role.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Role.FormattingEnabled = true;
            this.Role.Items.AddRange(new object[] {
            "Admin",
            "Attendant"});
            this.Role.Location = new System.Drawing.Point(54, 286);
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(243, 31);
            this.Role.TabIndex = 19;
            this.Role.Text = "Select Role";
            // 
            // Password
            // 
            this.Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Password.HintForeColor = System.Drawing.Color.White;
            this.Password.HintText = "Password";
            this.Password.isPassword = false;
            this.Password.LineFocusedColor = System.Drawing.Color.SeaShell;
            this.Password.LineIdleColor = System.Drawing.Color.CornflowerBlue;
            this.Password.LineMouseHoverColor = System.Drawing.Color.Pink;
            this.Password.LineThickness = 3;
            this.Password.Location = new System.Drawing.Point(27, 420);
            this.Password.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(290, 48);
            this.Password.TabIndex = 18;
            this.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Password.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged);
            // 
            // username
            // 
            this.username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.username.HintForeColor = System.Drawing.Color.White;
            this.username.HintText = "Username";
            this.username.isPassword = false;
            this.username.LineFocusedColor = System.Drawing.Color.SeaShell;
            this.username.LineIdleColor = System.Drawing.Color.CornflowerBlue;
            this.username.LineMouseHoverColor = System.Drawing.Color.Pink;
            this.username.LineThickness = 3;
            this.username.Location = new System.Drawing.Point(24, 349);
            this.username.Margin = new System.Windows.Forms.Padding(4);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(300, 48);
            this.username.TabIndex = 17;
            this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.af5834f6_improving_material_management1_removebg_preview__1_;
            this.pictureBox1.Location = new System.Drawing.Point(339, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(686, 661);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // Signup
            // 
            this.Signup.ActiveBorderThickness = 1;
            this.Signup.ActiveCornerRadius = 20;
            this.Signup.ActiveFillColor = System.Drawing.Color.Pink;
            this.Signup.ActiveForecolor = System.Drawing.Color.Transparent;
            this.Signup.ActiveLineColor = System.Drawing.Color.CornflowerBlue;
            this.Signup.BackColor = System.Drawing.Color.Pink;
            this.Signup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Signup.BackgroundImage")));
            this.Signup.ButtonText = "SIGNUP";
            this.Signup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Signup.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signup.ForeColor = System.Drawing.Color.White;
            this.Signup.IdleBorderThickness = 1;
            this.Signup.IdleCornerRadius = 20;
            this.Signup.IdleFillColor = System.Drawing.Color.Pink;
            this.Signup.IdleForecolor = System.Drawing.Color.CornflowerBlue;
            this.Signup.IdleLineColor = System.Drawing.Color.CornflowerBlue;
            this.Signup.Location = new System.Drawing.Point(63, 510);
            this.Signup.Margin = new System.Windows.Forms.Padding(5);
            this.Signup.Name = "Signup";
            this.Signup.Size = new System.Drawing.Size(219, 66);
            this.Signup.TabIndex = 20;
            this.Signup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Signup.Click += new System.EventHandler(this.Signup_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(982, 658);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Signup);
            this.Controls.Add(this.Role);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 Signup;
        private System.Windows.Forms.ComboBox Role;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Password;
        private Bunifu.Framework.UI.BunifuMaterialTextbox username;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}