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

namespace Management_Project
{
    public partial class Form2 : Form
    {
        //global variable for question index.
        int index = 0;
        public Form2()
        {
            InitializeComponent();
        }

        //to update the questions, I set all the labels to be the corresponding properties
        private void updateQuestions()
        {
            //but if there are no questions available, nothing happens.
            if (Thema.AllQuestions.Count == 0)
            {
                label1.Text = "Η τράπεζα θεμάτων είναι άδεια.";
                label7.Text = "Πηγαίνετε στο κύριο μενου, πατήστε \"Προσθήκη Θέματος\" κι όταν φτιάξετε το θέμα σας, θα το βρείτε εδώ!";
                label3.Text = label6.Text = label2.Text = "";
                return;
            }

            Thema th = Thema.AllQuestions[index];

            label1.Text = (index + 1).ToString() + ") " + th.Question;

            string stringGreekNumerals = "α,β,γ,δ,ε,στ,ζ,η,θ,ι,ια,ιβ,ιγ,ιδ,ιε,ιστ,ιζ,ιη,ιθ,κ,κα,κβ,κγ,κδ,κε,κστ,κζ,κη,κθ";
            string[] GreekNumerals = stringGreekNumerals.Split(',');

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < th.Answers.Count; i++)
            {
                sb.Append(GreekNumerals[i] + ") ");
                sb.Append(th.Answers[i]);
                sb.Append(Environment.NewLine);
            }

            label2.Text = sb.ToString();
            label3.Text = GreekNumerals[th.RightAnswerIndex] + ") " + th.Answers[th.RightAnswerIndex]; //αυτό σημαίνει "η σωστή απάντηση" λμαο.

            label7.Text = "Κεφάλαιο: " + th.Chapter;

            switch (th.Difficulty)
            {
                case 1:
                    label6.Text = "Βαθμός δυσκολίας: Εύκολος";
                    break;
                case 2:
                    label6.Text = "Βαθμός δυσκολίας: Μέτριος";
                    break;
                case 3:
                    label6.Text = "Βαθμός δυσκολίας: Δύσκολος";
                    break;
            }


            if (label1.Text.Length < 100)
            {
                Font f = new Font("Microsoft Sans Serif", 16f);
                label1.Font = f;
            }
            else if (label1.Text.Length < 160)
            {
                Font f = new Font("Microsoft Sans Serif", 13f);
                label1.Font = f;
            }
            else
            {
                Font f = new Font("Microsoft Sans Serif", 10f);
                label1.Font = f;
            }
        }

        private void updateButtons()
        {
            if (Thema.AllQuestions.Count == 0)
            {
                button1.Enabled = button3.Enabled = buttonEditQuestion.Enabled = buttonDeleteQuestion.Enabled = false;
                buttonDeleteQuestion.BackColor = Color.DarkGray;
                buttonDeleteQuestion.ForeColor = Color.Black;
            }
            else if (Thema.AllQuestions.Count == 1)
            {
                button1.Enabled = button3.Enabled = false;
                buttonEditQuestion.Enabled = buttonDeleteQuestion.Enabled = true;
                buttonDeleteQuestion.BackColor = Color.DarkRed;
                buttonDeleteQuestion.ForeColor = Color.White;
            }
            else
            {
                button1.Enabled = button3.Enabled = buttonEditQuestion.Enabled = buttonDeleteQuestion.Enabled = true;
                buttonDeleteQuestion.BackColor = Color.DarkRed;
                buttonDeleteQuestion.ForeColor = Color.White;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            updateQuestions();
            updateButtons();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            index = (index == 0)? Thema.AllQuestions.Count -1 : index - 1;

            updateButtons();
            updateQuestions();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            index = (index == Thema.AllQuestions.Count - 1)? 0 : index + 1;
            updateButtons();
            updateQuestions();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Thema.SaveQuestions();
            new Form1().Show();
            Close();
        }

        private void buttonDeleteQuestion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Αν διαγραφεί το θέμα από την τράπεζα, δεν υπάρχει τρόπος επαναφοράς. Έχετε σιγουρευτεί για αυτήν την ενέργεια;", "Διαγραφή Θέματος", MessageBoxButtons.YesNo) == DialogResult.Yes && Thema.AllQuestions.Count > 1)
            {
                Thema.AllQuestions.RemoveAt(index);
                button1.PerformClick();
            }
            else
            {
                Thema.AllQuestions.RemoveAt(index);
                updateButtons();
                updateQuestions();
            }
        }
    }
}
