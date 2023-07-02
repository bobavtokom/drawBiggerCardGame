using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class BiggerCard : Form {

        private static byte[] deckOfCards = new byte[] { 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 13, 14, 15 };
        private static Random randomCard = new Random();
        private static byte randomIndex = (byte) randomCard.Next(0, deckOfCards.Length);
        private static byte randomIndex1 = (byte) randomCard.Next(0, deckOfCards.Length);
        private static byte yourCard = deckOfCards[randomIndex];
        private byte compCard = deckOfCards[randomIndex1];
        private string cardName;
        private string directoryPath = @"C:\Users\Boban\source\repos\GamesMySqlWPFApp\WindowsFormsApp1\Resources\";


        public BiggerCard(string tbUsername, float userBalance ) {
            InitializeComponent();
            textBoxBigCardUsername.Text = tbUsername;
            textBoxBigCardUserBalance.Text = userBalance.ToString();
            pictureBoxPlayersCard.Visible = false;
            pictureBoxComputersCard.Visible = false; 
            buttonDrawComputerCard.Enabled = false;
        }
        private void GetCard(int card, PictureBox pictureBox, TextBox textBox) {
             
            switch (card) {

                case 15:
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
            pictureBox.Visible = true;
           
            string[] matchingFiles = Directory.GetFiles(directoryPath, $"{cardName}_*");

            if (matchingFiles.Length > 0) {
                Random random = new Random();
                int randomIndex = random.Next(0, matchingFiles.Length);
                string imagePath = matchingFiles[randomIndex];
                pictureBox.Image = Image.FromFile(imagePath);
                textBox.Text = card.ToString();
            } else {
                throw new Exception("Image not found");
            }
        }

        private void textBoxBet_TextChanged(object sender, EventArgs e) {
            float bet;
            if (!float.TryParse(textBoxBet.Text, out bet)) {
                MessageBox.Show("Please enter a valid number", "ATTENTION", MessageBoxButtons.OK);
                buttonDrawYourCard.Enabled = false;
            } else {
                buttonDrawYourCard.Enabled = true;
            }
        }

        private void BiggerCard_Load(object sender, EventArgs e) {
            var dbUserNew = new EFDbNewUserEntities1();
            

        }

        private void buttonDrawYourCard_Click(object sender, EventArgs e) {
            GetCard(yourCard, pictureBoxPlayersCard, textBoxYourCard);
            buttonDrawComputerCard.Enabled = true;  
        }
        private void CardsResult() {
            
            if (compCard > yourCard) {
                textBoxPlayerStatus.Text = "You lose";
            } else if (compCard < yourCard) {
                
                textBoxPlayerStatus.Text = "You win";
            } else textBoxPlayerStatus.Text = "Noone wins";
        }
        private float CurrentBalance(float ba, float be) {
            float currentBalance = 0;

            switch (textBoxPlayerStatus.Text) {
                case "You win":
                    currentBalance = ba + be;
                    if (currentBalance < 0) {
                        throw new Exception("Bet cannot be proceeded: Negative balance");
                    }
                    break;

                case "You lose":
                    currentBalance = ba - be;
                    if (currentBalance < 0) {
                        throw new Exception("Bet cannot be proceeded: Negative balance");
                    }
                    break;

                case "Noone wins":
                    currentBalance = ba;
                    break;

                default:
                    throw new Exception("Invalid player status");
            }

            return currentBalance;
        }





        private void textBoxDrawComputersCard_TextChanged(object sender, EventArgs e) {

        }

        private void buttonDrawComputerCard_Click(object sender, EventArgs e ) {
            GetCard(compCard, pictureBoxComputersCard, textBoxCompCard);
            CardsResult();
            playAgainButton.Visible = true;
        }

        private void textBoxPlayerStatus_TextChanged(object sender, EventArgs e) {
            float bet;
            if (!float.TryParse(textBoxBet.Text, out bet)) {
                throw new FormatException("not a valid number");
            }
            bet = float.Parse(textBoxBet.Text);
            float balance = float.Parse(textBoxBigCardUserBalance.Text.ToString());
            float result;
          
            result = CurrentBalance(balance, bet);
           // result = balance + bet;
            textBoxBigCardUserBalance.Text = result.ToString();
            using(var dbUserNew = new EFDbNewUserEntities1()) {
                float currentBalanceValue = float.Parse(textBoxBigCardUserBalance.Text);
                string currentBiggerCardUser = textBoxBigCardUsername.Text;
                var bigCardCurrentBalance = new UserNew {
                    UserNewName = currentBiggerCardUser,
                    UserNewBalance = (int?)currentBalanceValue
                };
                dbUserNew.UserNews.Add(bigCardCurrentBalance);
                dbUserNew.SaveChanges();
            }
           
        }

        private void pictureBoxPlayersCard_Click(object sender, EventArgs e) {

        }

        private void textBoxDrawYourCard_TextChanged(object sender, EventArgs e) {

        }

        private void playAgainButton_Click(object sender, EventArgs e) {
            Random randomCards = new Random();
            randomIndex = (byte)randomCards.Next(0, deckOfCards.Length);
            randomIndex1 = (byte)randomCards.Next(0, deckOfCards.Length);
            yourCard = deckOfCards[randomIndex];
            compCard = deckOfCards[randomIndex1];

            var biggerCard = new BiggerCard(textBoxBigCardUsername.Text, float.Parse(textBoxBigCardUserBalance.Text));
            biggerCard.Show();
            this.Close();
    }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void label1_Click_1(object sender, EventArgs e) {

        }
    }
}
