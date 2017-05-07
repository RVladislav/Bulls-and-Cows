using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bulls_and_Cows
{
    public partial class Main : Form
    {
        int[] answer, question;
        int attempt = 15;

        public Main()
        {
            InitializeComponent();

            txtCheck.Focus();
        }

        private void Generate()
        {
            answer = new int[4];
            question = new int[4];

            Random r = new Random();

            for (int i = 0; i <= 3; i++)
            {
                answer[i] = r.Next(0, 9);
            }

            Show();

        }

        private void Clear()
        {
            txtCheck.Clear();
            txtTry.Clear();
            lblAnswer.Text = "";
            lblQuestion.Text = "";

            for (int i = 0; i <= 3; i++)
            {
                question[i] = 0;
                answer[i] = 0;
            }

            attempt = 15;
        }

        private void Show()
        {
            lblAnswer.Text = "";

            for (int i = 0; i <= 3; i++)
            {
                lblAnswer.Text += answer[i];
            }
        }

        private int ShowQuestion()
        {
            string q = "";

            for (int i = 0; i <= 3; i++)
            {
                q += question[i].ToString();
            }

            return int.Parse(q);
        }

        private void Save(string s)
        {

            for (int i = 0; i <= 3; i++)
            {
                question[i] = int.Parse(s[i].ToString());
            }



        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Generate();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            Clear();

            Generate();

            txtCheck.Focus();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (attempt == 0)
            {
                string s = "Ты проиграл! Загаданное число: " + answer[0].ToString() + answer[1].ToString() + answer[2].ToString() + answer[3].ToString();
                MessageBox.Show(s);
                btnNewGame_Click(sender, e);

            }
            else
            {

                string check = txtCheck.Text;

                if (check.Count() == 4)
                {
                    int bulls = 0;
                    int cows = 0;

                    for (int i = 0; i <= 3; i++)
                    {
                        for (int j = 0; j <= 3; j++)
                        {
                            if (answer[i] == question[j])
                            {
                                if (i == j)
                                {
                                    bulls++;
                                }
                                else
                                {
                                    cows++;
                                }
                            }
                        }
                    }

                    if (bulls == 4)
                    {
                        string s = "Ты победил! Загаданное число: " + answer[0].ToString() + answer[1].ToString() + answer[2].ToString() + answer[3].ToString();
                        MessageBox.Show(s);

                        Clear();

                        Generate();
                    }
                    else
                    {
                        txtTry.Text += attempt.ToString() + " |" + " " + ShowQuestion() + " " + "  Быков: " + bulls.ToString() + " Коров: " + cows.ToString() + "\n";

                        attempt--;
                    }

                    txtCheck.Clear();
                }

            }
        }

        private void txtCheck_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCheck_Click(sender, e);
            }
            else
            {

            }

        }

        private void txtCheck_TextChanged(object sender, EventArgs e)
        {
            string check = txtCheck.Text;

            if (check.Count() == 4)
            {

                Save(check);
                lblQuestion.Text = "";

                for (int n = 0; n <= 3; n++)
                {
                    lblQuestion.Text += question[n].ToString();
                }
            }
        }
    }
}
