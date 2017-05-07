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
    public partial class frmMain : Form
    {
        int[] answer, question;

        public frmMain()
        {
            InitializeComponent();
        }

        private void Generate()
        {
            answer = new int[4];
            question = new int[4];

            Random r = new Random();

            for(int i=0; i<=3;i++)
            {
                answer[i] = r.Next(0, 9);
            }        

            Show();

        }

        private void Show()
        {
            lblAnswer.Text = "";

            for (int i = 0; i <= 3; i++)
            {
                lblAnswer.Text += answer[i];
            }
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
            txtCheck.Clear();
            txtTry.Clear();
            lblAnswer.Text = "";
            lblQuestion.Text = "";

            for (int i = 0; i <= 3; i++)
            {
                question[i] = 0;
            }

            Generate();
        }

        private void btnCheck_Click(object sender, EventArgs e)
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
                    btnNewGame_Click(sender, e);
                }
                else
                {
                    txtTry.Text += "Быков: " + bulls.ToString() + "Коров: " + cows.ToString() + "\n";
                }
            }
        }

        private void txtCheck_TextChanged(object sender, EventArgs e)
        {
            string check = txtCheck.Text;

            if(check.Count() == 4)
            {
                Save(check);

                lblQuestion.Text = "";

                for (int i = 0; i <= 3; i++)
                {
                    lblQuestion.Text += question[i].ToString();
                }
            }
        }
    }
}
