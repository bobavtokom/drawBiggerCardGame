namespace WindowsFormsApp1 {
    partial class UserNewForm {
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
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelUserBalance = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxUserBalance = new System.Windows.Forms.TextBox();
            this.dataGridViewNewUser = new System.Windows.Forms.DataGridView();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonPay = new System.Windows.Forms.Button();
            this.UserNewId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserNewName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserNewBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNewUser)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Red;
            this.buttonDelete.Location = new System.Drawing.Point(67, 252);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 42);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Yellow;
            this.buttonCancel.Location = new System.Drawing.Point(67, 331);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 39);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(252, 41);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(70, 16);
            this.labelUserName.TabIndex = 3;
            this.labelUserName.Text = "Username";
            // 
            // labelUserBalance
            // 
            this.labelUserBalance.AutoSize = true;
            this.labelUserBalance.Location = new System.Drawing.Point(252, 84);
            this.labelUserBalance.Name = "labelUserBalance";
            this.labelUserBalance.Size = new System.Drawing.Size(88, 16);
            this.labelUserBalance.TabIndex = 4;
            this.labelUserBalance.Text = "User balance";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(444, 35);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(224, 22);
            this.textBoxUserName.TabIndex = 5;
            this.textBoxUserName.Text = "nj";
            // 
            // textBoxUserBalance
            // 
            this.textBoxUserBalance.Location = new System.Drawing.Point(444, 84);
            this.textBoxUserBalance.Name = "textBoxUserBalance";
            this.textBoxUserBalance.Size = new System.Drawing.Size(100, 22);
            this.textBoxUserBalance.TabIndex = 6;
            this.textBoxUserBalance.TextChanged += new System.EventHandler(this.textBoxUserBalance_TextChanged);
            // 
            // dataGridViewNewUser
            // 
            this.dataGridViewNewUser.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewNewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNewUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserNewId,
            this.UserNewName,
            this.UserNewBalance});
            this.dataGridViewNewUser.Location = new System.Drawing.Point(227, 190);
            this.dataGridViewNewUser.Name = "dataGridViewNewUser";
            this.dataGridViewNewUser.ReadOnly = true;
            this.dataGridViewNewUser.RowHeadersWidth = 51;
            this.dataGridViewNewUser.RowTemplate.Height = 24;
            this.dataGridViewNewUser.Size = new System.Drawing.Size(506, 50);
            this.dataGridViewNewUser.TabIndex = 7;
            this.dataGridViewNewUser.DoubleClick += new System.EventHandler(this.dataGridViewNewUser_DoubleClick);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonSave.Location = new System.Drawing.Point(67, 166);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 40);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonPay
            // 
            this.buttonPay.BackColor = System.Drawing.Color.Black;
            this.buttonPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonPay.Location = new System.Drawing.Point(385, 321);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(134, 52);
            this.buttonPay.TabIndex = 9;
            this.buttonPay.Text = "Pay";
            this.buttonPay.UseVisualStyleBackColor = false;
            this.buttonPay.Click += new System.EventHandler(this.buttonPay_Click);
            // 
            // UserNewId
            // 
            this.UserNewId.DataPropertyName = "UserNewId";
            this.UserNewId.HeaderText = "User Id";
            this.UserNewId.MinimumWidth = 6;
            this.UserNewId.Name = "UserNewId";
            this.UserNewId.ReadOnly = true;
            this.UserNewId.Visible = false;
            this.UserNewId.Width = 125;
            // 
            // UserNewName
            // 
            this.UserNewName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserNewName.DataPropertyName = "UserNewName";
            this.UserNewName.HeaderText = "Username";
            this.UserNewName.MinimumWidth = 6;
            this.UserNewName.Name = "UserNewName";
            this.UserNewName.ReadOnly = true;
            // 
            // UserNewBalance
            // 
            this.UserNewBalance.DataPropertyName = "UserNewBalance";
            this.UserNewBalance.HeaderText = "Balance";
            this.UserNewBalance.MinimumWidth = 6;
            this.UserNewBalance.Name = "UserNewBalance";
            this.UserNewBalance.ReadOnly = true;
            this.UserNewBalance.Width = 125;
            // 
            // UserNewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(977, 760);
            this.Controls.Add(this.buttonPay);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dataGridViewNewUser);
            this.Controls.Add(this.textBoxUserBalance);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.labelUserBalance);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonDelete);
            this.Name = "UserNewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserNewForm";
            this.Load += new System.EventHandler(this.UserNewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNewUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelUserBalance;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxUserBalance;
        private System.Windows.Forms.DataGridView dataGridViewNewUser;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserNewId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserNewName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserNewBalance;
    }
}