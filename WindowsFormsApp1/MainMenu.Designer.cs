namespace WindowsFormsApp1 {
    partial class mainMenu {
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
            this.mainMenuTextBox = new System.Windows.Forms.RichTextBox();
            this.buttonYes = new System.Windows.Forms.Button();
            this.buttonNo = new System.Windows.Forms.Button();
            this.buttonMiddle = new System.Windows.Forms.Button();
            this.buttonEng = new System.Windows.Forms.Button();
            this.buttonMkd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainMenuTextBox
            // 
            this.mainMenuTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainMenuTextBox.BackColor = System.Drawing.Color.White;
            this.mainMenuTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuTextBox.ForeColor = System.Drawing.Color.Teal;
            this.mainMenuTextBox.Location = new System.Drawing.Point(144, 161);
            this.mainMenuTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.mainMenuTextBox.Name = "mainMenuTextBox";
            this.mainMenuTextBox.Size = new System.Drawing.Size(707, 375);
            this.mainMenuTextBox.TabIndex = 1;
            this.mainMenuTextBox.Text = "";
            // 
            // buttonYes
            // 
            this.buttonYes.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonYes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonYes.Location = new System.Drawing.Point(144, 461);
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.Size = new System.Drawing.Size(75, 41);
            this.buttonYes.TabIndex = 3;
            this.buttonYes.Text = "Yes";
            this.buttonYes.UseVisualStyleBackColor = false;
            this.buttonYes.Click += new System.EventHandler(this.buttonYes_Click);
            // 
            // buttonNo
            // 
            this.buttonNo.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonNo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonNo.Location = new System.Drawing.Point(338, 461);
            this.buttonNo.Name = "buttonNo";
            this.buttonNo.Size = new System.Drawing.Size(75, 41);
            this.buttonNo.TabIndex = 4;
            this.buttonNo.Text = "No";
            this.buttonNo.UseVisualStyleBackColor = false;
            this.buttonNo.Click += new System.EventHandler(this.buttonNo_Click);
            // 
            // buttonMiddle
            // 
            this.buttonMiddle.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonMiddle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonMiddle.Location = new System.Drawing.Point(239, 461);
            this.buttonMiddle.Name = "buttonMiddle";
            this.buttonMiddle.Size = new System.Drawing.Size(75, 41);
            this.buttonMiddle.TabIndex = 4;
            this.buttonMiddle.Text = "Matrix";
            this.buttonMiddle.UseVisualStyleBackColor = false;
            this.buttonMiddle.Click += new System.EventHandler(this.buttonNo_Click);
            // 
            // buttonEng
            // 
            this.buttonEng.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.icons8_united_kingdom_48;
            this.buttonEng.Location = new System.Drawing.Point(512, 89);
            this.buttonEng.Name = "buttonEng";
            this.buttonEng.Size = new System.Drawing.Size(66, 57);
            this.buttonEng.TabIndex = 2;
            this.buttonEng.UseVisualStyleBackColor = true;
            this.buttonEng.Click += new System.EventHandler(this.buttonEng_Click);
            // 
            // buttonMkd
            // 
            this.buttonMkd.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.macedonia_round_icon_64;
            this.buttonMkd.Location = new System.Drawing.Point(592, 89);
            this.buttonMkd.Name = "buttonMkd";
            this.buttonMkd.Size = new System.Drawing.Size(82, 57);
            this.buttonMkd.TabIndex = 0;
            this.buttonMkd.UseVisualStyleBackColor = true;
            this.buttonMkd.Click += new System.EventHandler(this.buttonMkd_Click);
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(977, 760);
            this.Controls.Add(this.buttonMiddle);
            this.Controls.Add(this.buttonNo);
            this.Controls.Add(this.buttonYes);
            this.Controls.Add(this.buttonEng);
            this.Controls.Add(this.mainMenuTextBox);
            this.Controls.Add(this.buttonMkd);
            this.Name = "mainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMkd;
        private System.Windows.Forms.RichTextBox mainMenuTextBox;
        private System.Windows.Forms.Button buttonEng;
        private System.Windows.Forms.Button buttonYes;
        private System.Windows.Forms.Button buttonNo;
        private System.Windows.Forms.Button buttonMiddle;
    }
}

