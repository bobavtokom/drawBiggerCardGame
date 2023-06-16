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
        public static string Language { get; set; }
        public mainMenu() {
            InitializeComponent();
            buttonYes.Visible = false;
            buttonNo.Visible = false;
            buttonMiddle.Visible = false;   
        }

        private void buttonMkd_Click(object sender, EventArgs e) {
            Language = "macedonian";
            ParametersWF parametersWF = new ParametersWF();
            mainMenuTextBox.Text = parametersWF.GamesMenu + parametersWF.ChoosePayToPlay;
            buttonYes.Text = "ДА"; buttonYes.Visible = true;
            buttonNo.Text = "Не"; buttonNo.Visible = true;
            
        }

        private void buttonEng_Click(object sender, EventArgs e) {
            Language = "english";
            ParametersWF parametersWF = new ParametersWF();
            mainMenuTextBox.Text = parametersWF.GamesMenu + parametersWF.ChoosePayToPlay;
            buttonYes.Visible = true;
            buttonNo.Visible = true;
        }

        private void buttonYes_Click(object sender, EventArgs e) {
            var userNewForm = new UserNewForm();
            userNewForm.ShowDialog();
        }
        
        private void buttonNo_Click(object sender, EventArgs e) {
            mainMenuTextBox.Text = ParametersWF.MaybeNextTime;
            buttonYes.Visible = false;
            buttonNo.Visible = false;
        }

      

        private void button1_Click(object sender, EventArgs e) {

        }
    }
}
