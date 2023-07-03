using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class UserNewForm : Form {
        UserNew userNew = new UserNew();
        public string  Username { get; set; }
        public int UserBalance { get; set; }
        public UserNewForm() {
            InitializeComponent();
            buttonPay.Enabled = false;  
        }

        private void button1_Click(object sender, EventArgs e) {

        }

        private void buttonCancel_Click(object sender, EventArgs e) {
                
             Clear();
        }
        void Clear() {
            textBoxUserName.Text = textBoxUserBalance.Text = "";
            buttonSave.Text = "Save";
            buttonDelete.Enabled = false;
            userNew.UserNewId = 0;
        }

        private async void UserNewForm_Load(object sender, EventArgs e) {
            Clear();
            this.ActiveControl = textBoxUserName;
            await LoadDataAsync();
        }
        private async Task LoadDataAsync() {
            try {
                using (var context = new EFDbNewUserEntities1()) {

                    var lastRecord = await context.UserNews.OrderByDescending(x => x.UserNewId).FirstOrDefaultAsync();
                    var bindingList = new BindingList<UserNew>(new[] { lastRecord });
                    var source = new BindingSource(bindingList, null);
                    dataGridViewNewUser.DataSource = source;
                }
            }
            catch (Exception ex) {
                MessageBox.Show("An error occurred while loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async void buttonSave_Click(object sender, EventArgs e) {
            userNew.UserNewName = textBoxUserName.Text.Trim();
            userNew.UserNewBalance = Convert.ToInt32(textBoxUserBalance.Text.Trim());
            
            using (EFDbNewUserEntities1 db = new EFDbNewUserEntities1()) {
                if (userNew.UserNewId == 0) {
                    db.UserNews.Add(userNew);
                    buttonPay.Enabled = true;
                } else {
                    db.Entry(userNew).State = System.Data.Entity.EntityState.Modified;
                    buttonPay.Enabled = true;
                }
                    db.SaveChanges();
            }
            Clear();
            await LoadDataAsync();
            MessageBox.Show("Successfully submitted");
        }
        public void LoadData() {
               
        }

        private void dataGridViewNewUser_DoubleClick(object sender, EventArgs e) {

            if(dataGridViewNewUser.CurrentRow.Index != -1) {
                userNew.UserNewId = Convert.ToInt32(dataGridViewNewUser.CurrentRow.Cells["UserNewId"].Value);
                using(EFDbNewUserEntities1 db = new EFDbNewUserEntities1()) {
                    userNew = db.UserNews.Where(x => x.UserNewId == userNew.UserNewId).FirstOrDefault();
                    textBoxUserName.Text = userNew.UserNewName;
                    textBoxUserBalance.Text = userNew.UserNewBalance.ToString();
                }
                buttonSave.Text = "Update";
                buttonDelete.Enabled = true;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e) {

            if(MessageBox.Show("Are you sure to delete this record?","Message",MessageBoxButtons.YesNo)== DialogResult.Yes) {
                using(EFDbNewUserEntities1 db = new EFDbNewUserEntities1()) {
                    var entry = db.Entry(userNew);
                    if(entry.State == System.Data.Entity.EntityState.Detached) {
                        db.UserNews.Attach(userNew);
                        db.UserNews.Remove(userNew);
                        db.SaveChanges();
                        LoadData();
                        Clear();
                        MessageBox.Show("Successfully removed record");
                    }
                }
            }
        }

        private void buttonPay_Click(object sender, EventArgs e) {

            var paymentForm = new PaymentForm();
            paymentForm.ShowDialog();
        }
    }
}
