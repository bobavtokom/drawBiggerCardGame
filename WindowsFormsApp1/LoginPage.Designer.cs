namespace WindowsFormsApp1 {
    partial class LoginPage {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLable = new System.Windows.Forms.Label();
            this.TextBoxUsername = new System.Windows.Forms.TextBox();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(284, 169);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(70, 16);
            this.UsernameLabel.TabIndex = 0;
            this.UsernameLabel.Text = "Username";
            // 
            // PasswordLable
            // 
            this.PasswordLable.AutoSize = true;
            this.PasswordLable.Location = new System.Drawing.Point(287, 235);
            this.PasswordLable.Name = "PasswordLable";
            this.PasswordLable.Size = new System.Drawing.Size(67, 16);
            this.PasswordLable.TabIndex = 1;
            this.PasswordLable.Text = "Password";
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.Location = new System.Drawing.Point(393, 169);
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.Size = new System.Drawing.Size(159, 22);
            this.TextBoxUsername.TabIndex = 2;
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Location = new System.Drawing.Point(393, 235);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(159, 22);
            this.TextBoxPassword.TabIndex = 3;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Black;
            this.buttonLogin.ForeColor = System.Drawing.Color.GreenYellow;
            this.buttonLogin.Location = new System.Drawing.Point(423, 329);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(88, 34);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.Black;
            this.buttonRegister.ForeColor = System.Drawing.Color.GreenYellow;
            this.buttonRegister.Location = new System.Drawing.Point(423, 423);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(88, 36);
            this.buttonRegister.TabIndex = 5;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(977, 760);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.TextBoxUsername);
            this.Controls.Add(this.PasswordLable);
            this.Controls.Add(this.UsernameLabel);
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswordLable;
        private System.Windows.Forms.TextBox TextBoxUsername;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonRegister;
    }
}