//author: Matt Blaul
//date:   1/8/2018
//class:  CSI 3370, Dr. Nilesh Patel

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace hangman
{
    public partial class Main : Form
    {
        public static string[] wordarray = { "tarantula","copper","explain","tenuous","scandalous",
                                             "shave","silk","dangerous","muddle","bee","fix","twig",
                                             "guide","develop","building","loss","fuel","haircut",
                                             "hysterical","lean","stimulating","start","end","wry",
                                             "stiff","flowery","draconian","evasive","badge","steady"
                                            };
        public static Random rnd = new Random();
        string gameword = wordarray[rnd.Next(0, wordarray.Length)];
        public string maskedword;
        int tries = 0;

        public Main()
        {
            InitializeComponent();
            SelectGameWord(gameword);
        }
        
        public string SelectGameWord(string gameword)
        {
            foreach (char c in gameword)
            {
               maskedword = maskedword+"-";
            }
            lblRandWord.Text = maskedword;
            return maskedword;
        }
        
        public void CheckMaskedWord(string letter)
        {
            int cntr = 0;
            if (gameword.Contains(letter) && !maskedword.Contains(letter))
            {
                tries += 1;
                lblTries.Text = tries.ToString() + " Tries";
                foreach (char c in gameword)
                {
                    if (letter == Convert.ToString(c))
                    {
                        StringBuilder sb = new StringBuilder(maskedword);
                        sb[cntr] = Convert.ToChar(letter);
                        maskedword = sb.ToString();
                        lblRandWord.Text = maskedword;
                    }
                    cntr += 1;
                    CheckGameOver();

                }
            }else{
                tries += 1;
                lblTries.Text = tries.ToString() + " Tries";
            }
        }

        private void CheckGameOver()
        {
            if (lblRandWord.Text.Contains("-"))
            { 
            }else{
                lblWin.Visible = true;
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            CheckMaskedWord("a");
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            CheckMaskedWord("b");
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            CheckMaskedWord("c");
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            CheckMaskedWord("d");
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            CheckMaskedWord("e");
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            CheckMaskedWord("f");
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            CheckMaskedWord("g");
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            CheckMaskedWord("h");
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            CheckMaskedWord("i");
        }

        private void btnJ_Click(object sender, EventArgs e)
        {
            CheckMaskedWord("j");
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            CheckMaskedWord("k");
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            CheckMaskedWord("l");
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            CheckMaskedWord("m");
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            CheckMaskedWord("n");
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            CheckMaskedWord("o");
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            CheckMaskedWord("p");
        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            CheckMaskedWord("q");
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            CheckMaskedWord("r");
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            CheckMaskedWord("s");
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            CheckMaskedWord("t");
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            CheckMaskedWord("u");
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            CheckMaskedWord("v");
        }

        private void btnW_Click(object sender, EventArgs e)
        {
            CheckMaskedWord("w");
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            CheckMaskedWord("x");
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            CheckMaskedWord("y");
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            CheckMaskedWord("z");
        }

        private void btnEndGame_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Start start = new Start();
            start.Show();
            this.Hide();
    }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
