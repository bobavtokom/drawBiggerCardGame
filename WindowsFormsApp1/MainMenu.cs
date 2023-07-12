using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GamesDevProject.cs;

namespace WindowsFormsApp1 {
    public partial class mainMenu : Form {
        NewPlayer newPlayer = new NewPlayer();
        public static string _language { get; set; }
        public string Macedonian = "macedonian";
        public string English = "english";

        public mainMenu() {
            InitializeComponent();
            buttonYes.Visible = false;
            buttonNo.Visible = false;
        }
        private void MainMenuLanguage(string language) {
            _language = language;
            var parametersWf = new ParametersWF();
            mainMenuTextBox.Text = parametersWf.GamesMenu;
            buttonNo.Visible = true;
            buttonYes.Visible = true;
        }
        private void buttonMkd_Click(object sender, EventArgs e) {
            MainMenuLanguage(Macedonian);
            buttonYes.Text = "ДА";
            buttonNo.Text = "Не"; 
            
        }

        private void buttonEng_Click(object sender, EventArgs e) {
          MainMenuLanguage(English);
        }

        private void buttonYes_Click(object sender, EventArgs e) {
            var loginPage = new LoginPage();
            loginPage.ShowDialog();
            this.Close();
        }
        
        private void buttonNo_Click(object sender, EventArgs e) {
            mainMenuTextBox.Text = ParametersWF.MaybeNextTime;
            buttonYes.Visible = false;
            buttonNo.Visible = false;
            buttonEng.Visible = false;
            buttonMkd.Visible = false;
        }
    }
}
