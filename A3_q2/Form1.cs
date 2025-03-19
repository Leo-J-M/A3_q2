using System;

namespace A3_q2
{
    public partial class Form1 : Form
    {
        int randomNum;
        int atemptsLeft;
        int gamesWon;
        

        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            
            randomNum = random.Next(1, 1000);
            atemptsLeft = 10;
            gamesWon = 0;
        }

        private void btnGues_Click(object sender, EventArgs e)
        {
            randomNum = random.Next(1, 1000);
            atemptsLeft = 10;
            txtAtempts.Text = atemptsLeft.ToString();
            txtGues.Text = "";
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            int userGues = Convert.ToInt32(txtGues.Text);//
            if (randomNum == userGues && atemptsLeft == 1) {

            }
            else if (randomNum == userGues && atemptsLeft > 1) { 
                
            }
            else if(randomNum != userGues) {

            }
        }
    }
}
