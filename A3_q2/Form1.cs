using System;
using Microsoft.VisualBasic.ApplicationServices;

namespace A3_q2
{
    public partial class Form1 : Form {
        const string arrowUp = "\u2191";
        const string arrowDown = "\u2193";

        int randomNum;
        int atemptsLeft;
        int gamesWon;

        Random random = new Random();

        public Form1() {
            InitializeComponent();
            this.AcceptButton = btnGues;
            randomNum = random.Next(1, 1000);
            txtAnsw.Text = randomNum.ToString();
            atemptsLeft = 10;
            gamesWon = 0;
        }

        private void btnGues_Click(object sender, EventArgs e) {
            if (!txtGues.Text.All(char.IsDigit) || txtGues.Text == "") {//check input
                MessageBox.Show("Invalid input! Enter 1-1000.");
                txtGues.Text = "";
                return;
            }

            int userGues = Convert.ToInt32(txtGues.Text);

            if (userGues > 1000 || userGues < 1) {//check input
                MessageBox.Show("Invalid input! Enter 1-1000.");
                txtGues.Text = "";
                return;
            }

            ListViewItem item = new ListViewItem(txtGues.Text);

            if (randomNum == userGues) {
                if (atemptsLeft == 1) {
                    MessageBox.Show("Either you know the secret or you got lucky!");
                }
                else {
                    MessageBox.Show("You know the secret!");
                }
                item.SubItems.Add("=");
                btnGues.Enabled = false;
                txtWon.Text = (++gamesWon).ToString();
                DialogResult result = MessageBox.Show("Start new game?",
                                                          "Click Yes",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Question);

                if (result == DialogResult.Yes) {
                    btnNewGame_Click(sender, e);
                    return;
                }
                txtGues.Text = "";
                listViewGuesses.Items.Add(item);
                return;
            }

            else if (atemptsLeft <= 1) {

                btnGues.Enabled = false;
                DialogResult result = MessageBox.Show("You should be able to do better! Try again?",
                                                          "New game?",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Information);

                if (result == DialogResult.Yes) {
                    btnNewGame_Click(sender, e);
                    return;
                }
            }

            else if (randomNum > userGues) {
                MessageBox.Show("Too Low, Try again.");
                item.SubItems.Add(arrowDown);
            }

            else if (randomNum < userGues) {
                MessageBox.Show("Too HIGH, Try again.");
                item.SubItems.Add(arrowUp);
            }

            listViewGuesses.Items.Add(item);
            txtAtempts.Text = (--atemptsLeft).ToString();
            txtGues.Text = "";
        }

        private void btnNewGame_Click(object sender, EventArgs e) {
            btnGues.Enabled = true;
            randomNum = random.Next(1, 1000);
            txtAnsw.Text = randomNum.ToString();
            atemptsLeft = 10;
            txtAtempts.Text = atemptsLeft.ToString();
            txtGues.Text = "";
            listViewGuesses.Items.Clear();
        }

        private void checkBoxShow_CheckedChanged(object sender, EventArgs e) {
            if (checkBoxShow.Checked) 
                txtAnsw.Visible = true;
            else                
                txtAnsw.Visible = false;
        }
    }
}
