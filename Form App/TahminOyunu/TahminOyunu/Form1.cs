using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TahminOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random random= new Random();
        string secretKey;
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            lstGuessedWords.Items.Clear();
            string[] secretKeys = { "dolap", "bilgisayar", "fare", "kalem" };
            secretKey = secretKeys[random.Next(0,4)];//rastgele bir kelime saçildi.

            txtGuess.Enabled = true;
            btnCheck.Enabled = true;
            txtGuess.Text= "";//tahmin edilen kısmın içini boşalttık.

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string guess = txtGuess.Text;
            if(guess == secretKey)
            {
                MessageBox.Show("Kazandınız...");

            }
            else
            {
               char[] letters = guess.ToCharArray();
                string matchedletters = "";

                foreach(char letter in letters)
                {
                    if(secretKey.Contains(letter) && !matchedletters.Contains(letter))
                    {
                        matchedletters += $"{letter}";
                    }
                    
                }

                if(matchedletters != "" )
                {
                    matchedletters = matchedletters.TrimEnd(',');
                    lstGuessedWords.Items.Add(matchedletters);
                }

            }
        }
    }
}
