using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1 {
    public partial class BiggerCard : Form {
        public int Bet => int.Parse(textBoxBet.Text); 
        public static int min = 1;
        public static int max = 14;
        public static Random deckOfCards = new Random();
        public static int yourCard = deckOfCards.Next(min, max);
        public static int compCard = deckOfCards.Next(min, max);
        static string directoryPath = @"C:\Users\Boban\source\repos\GamesMySqlWPFApp\WindowsFormsApp1\Resources\";
        string cardName;
        private void GetCard(int card) {
             
            switch (compCard) {
                case 11:
                case 1:
                    cardName = "ace";
                    break;
                case 12:
                    cardName = "jack";
                    break;
                case 13:
                    cardName = "queen";
                    break;
                case 14:
                    cardName = "king";
                    break;
                default:
                    cardName = card.ToString();
                    break;
            }

            string[] matchingFiles = Directory.GetFiles(directoryPath, $"{cardName}_*");

        }
        public BiggerCard(string tbUsername,string userBalance ) {
            InitializeComponent();
           textBoxBigCardUsername.Text = tbUsername;
            textBoxBigCardUserBalance.Text = userBalance.ToString();
            pictureBoxPlayersCard.Visible = false;
            pictureBoxComputersCard.Visible = false;
            pictureBoxComputersCard.Visible = false;
        }

        private void textBoxBet_TextChanged(object sender, EventArgs e) {
           
        }

        private void BiggerCard_Load(object sender, EventArgs e) {
            var dbUserNew = new EFDbNewUserEntities1();
            
        }

        private void buttonDrawYourCard_Click(object sender, EventArgs e) {
            pictureBoxPlayersCard.Visible = true;
            GetCard(yourCard);
            string[] matchingFiles = Directory.GetFiles(directoryPath, $"{cardName}_*");

            if (matchingFiles.Length > 0) {
                string imagePath = matchingFiles[0];
                pictureBoxPlayersCard.Image = Image.FromFile(imagePath);
            } else {
                throw new Exception("Image not found");
            }
        }
        private void CardsResult() {
            if (compCard > yourCard) {
                textBoxPlayerStatus.Text = "You lose";
            } else if (compCard < yourCard) {
                textBoxPlayerStatus.Text = "You win";
            } else textBoxPlayerStatus.Text = "Noone wins";
        }
        private int CurrentBalance(int ba, int be) {
            var currentBalance = 0;
            switch (textBoxPlayerStatus.Text) {
                case "You win": return currentBalance = ba + be; break;
                case "You lose": return currentBalance = ba - be; break;
                case "Noone wins": return currentBalance = ba; break;
            }
            if (currentBalance < 0) {
                throw new Exception("bet cant be proceed");
            }
            return currentBalance;
        }




        private void textBoxDrawComputersCard_TextChanged(object sender, EventArgs e) {

        }

        private void buttonDrawComputerCard_Click(object sender, EventArgs e ) {
            pictureBoxComputersCard.Visible = true;
            GetCard(compCard);
            string[] matchingFiles = Directory.GetFiles(directoryPath, $"{cardName}_*");

            if (matchingFiles.Length > 0) {
                string imagePath = matchingFiles[0];
                pictureBoxComputersCard.Image = Image.FromFile(imagePath);
            } else {
                throw new Exception("Image not found");
            }
            CardsResult();
        }

        private void textBoxPlayerStatus_TextChanged(object sender, EventArgs e) {
            int bet = int.Parse(textBoxBet.Text);
            int balance = int.Parse(textBoxBigCardUserBalance.Text);
            int result;
          
            result = CurrentBalance(balance, bet);
           // result = balance + bet;
            textBoxBigCardUserBalance.Text = result.ToString();
            using(var dbUserNew = new EFDbNewUserEntities1()) {
                int currentBalanceValue = int.Parse(textBoxBigCardUserBalance.Text);
                string currentBiggerCardUser = textBoxBigCardUsername.Text;
                var bigCardCurrentBalance = new UserNew {
                    UserNewName = currentBiggerCardUser,
                    UserNewBalance = currentBalanceValue
                };
                dbUserNew.UserNews.Add(bigCardCurrentBalance);
                dbUserNew.SaveChanges();
            }
           
        }

        private void pictureBoxPlayersCard_Click(object sender, EventArgs e) {

        }

        private void textBoxDrawYourCard_TextChanged(object sender, EventArgs e) {

        }
    }
}
