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

        private static readonly byte[] deckOfCards = new byte[] { 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 13, 14, 15 };
        private static readonly Random randomCard = new Random();
        private static byte randomIndex;
        private static byte randomIndex1;
        private static byte yourCard;
        private byte compCard;
        private string cardName;
        private readonly string directoryPath = @"C:\Users\Boban\source\repos\GamesMySqlWPFApp\WindowsFormsApp1\Resources\";
        float bet;
        public float CurrentUserBalance { get; set; }

        public BiggerCard() {
            CurrentUserBalance = float.Parse(textBoxBigCardUserBalance.Text);
        }
        void CardsShuffle(Random randoms) {

            randomIndex = (byte)randoms.Next(0, deckOfCards.Length);
            randomIndex1 = (byte)randoms.Next(0, deckOfCards.Length);
            yourCard = deckOfCards[randomIndex];
            compCard = deckOfCards[randomIndex1];
        }

        public BiggerCard(string tbUsername, float userBalance ) {

            InitializeComponent();
            textBoxBigCardUsername.Text = tbUsername;
            textBoxBigCardUserBalance.Text = userBalance.ToString();
            CurrentUserBalance = userBalance;
            pictureBoxPlayersCard.Visible = false;
            pictureBoxComputersCard.Visible = false; 
            buttonDrawComputerCard.Enabled = false;
            buttonDrawYourCard.Enabled = false;
            cashOutButton.Visible= false;
            CardsShuffle(randomCard);
            textBoxPlayerStatus.ReadOnly = true;
        }

        private void GetCard(int card, PictureBox pictureBox) {
             
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
            } else {
                throw new Exception("Image not found");
            }
        }

        private void textBoxBet_TextChanged(object sender, EventArgs e) {
            
            if (!float.TryParse(textBoxBet.Text, out bet) || bet > CurrentUserBalance) {
                MessageBox.Show("not valid number or bet is higher than balance", "ATTENTION", MessageBoxButtons.OK);
                textBoxBet.Text = string.Empty;
                buttonDrawYourCard.Enabled = false;
            } else {
                buttonDrawYourCard.Enabled = true;
            }
        }

        private void BiggerCard_Load(object sender, EventArgs e) {
            var dbUserNew = new EFDbNewUserEntities1();
            
        }

        private void buttonDrawYourCard_Click(object sender, EventArgs e) {
            GetCard(yourCard, pictureBoxPlayersCard);
            buttonDrawYourCard.Enabled = false;
            buttonDrawComputerCard.Enabled = true;  
            buttonDrawComputerCard.Focus();
        }
        private void CardsResult() {

            if (compCard > yourCard) {
                textBoxPlayerStatus.Text = "You lose";
            } else if (compCard < yourCard) {

                textBoxPlayerStatus.Text = "You win";
                textBoxPlayerStatus.ForeColor = Color.GreenYellow;
            } else {
                textBoxPlayerStatus.Text = "Noone wins";
                textBoxPlayerStatus.ForeColor = Color.Blue;
            }
        }
        private float CurrentBalance(float ba, float be) {
            float currentBalance = 0;

            switch (textBoxPlayerStatus.Text) {
                case "You win":
                    currentBalance = ba + be;
                    break;

                case "You lose":
                    currentBalance = ba - be;
                    break;

                case "Noone wins":
                    currentBalance = ba;
                    break;

                default:
                    throw new Exception("Invalid player status");
            }

            return currentBalance;
        }
        private void buttonDrawComputerCard_Click(object sender, EventArgs e ) {
            GetCard(compCard, pictureBoxComputersCard);
            CardsResult();
            buttonDrawComputerCard.Enabled = false;
            playAgainButton.Visible = true;
            playAgainButton.Focus();
            cashOutButton.Visible = true;
        }

        private void textBoxPlayerStatus_TextChanged(object sender, EventArgs e) {
          
            bet = float.Parse(textBoxBet.Text);
            float balance = float.Parse(textBoxBigCardUserBalance.Text.ToString());
            float result;
            result = CurrentBalance(balance, bet);
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
            if (result <= 0) {
                MessageBox.Show("To continue playing please add balance", "EMPTY WALLET", MessageBoxButtons.OK);
                UserNewForm userNewForm = new UserNewForm();
                userNewForm.ShowDialog();
            }
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
       
        private void cashOutButtonClick(object sender, EventArgs e) {

            var userWalletForm = new UserWalletForm();
            userWalletForm.CashoutSwitch = true;
            userWalletForm.Show();
            userWalletForm.QuitButton.Visible = true;
            Random randomCards2 = new Random();
            CardsShuffle(randomCards2);
            this.Close();
        }
    }
}
