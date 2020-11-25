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
        List<Question> questions = new List<Question>();
        int index = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void updateQuestions()
        {
            label1.Text = (index + 1).ToString() + ") " + questions[index].Ques;
            label2.Text = "Α: " + questions[index].Ans1;
            label3.Text = "Β: " + questions[index].Ans2;
            label4.Text = "Γ: " + questions[index].Ans3;
            label5.Text = "Δ: " + questions[index].Ans4;
            label6.Text = "Βαθμός δυσκολίας: " + questions[index].Difficulty.ToString();

            label2.BackColor = label3.BackColor = label4.BackColor = label5.BackColor = default;
            switch(questions[index].RightAnswer)
            {
                case 1:
                    label2.BackColor = Color.LightGreen;
                    break;
                case 2:
                    label3.BackColor = Color.LightGreen;
                    break;
                case 3:
                    label4.BackColor = Color.LightGreen;
                    break;
                case 4:
                    label5.BackColor = Color.LightGreen;
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
            if (index == 0)
                button1.Enabled = false;
            else
                button1.Enabled = true;

            if (index == questions.Count - 1)
                button3.Enabled = false;
            else
                button3.Enabled = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("Questions.txt");
                string Everything = sr.ReadToEnd();
                string[] AllLines = Everything.Split('\n');

                if (AllLines.Length < 1)
                {
                    label1.Text = "Το αρχείο των ερωτήσεων είναι άδειο!";

                }
                else
                {
                    foreach (string a in AllLines)
                    {
                        string[] Attributes = a.Split('|');
                        if (Attributes.Length != 0)
                        {
                            try
                            {
                                Question q = new Question(Attributes[0], Attributes[1], Attributes[2], Attributes[3], Attributes[4], int.Parse(Attributes[5]), int.Parse(Attributes[6]));
                                questions.Add(q);
                            }
                            catch (IndexOutOfRangeException ex)
                            {
                                Console.WriteLine(ex.ToString());
                            }
                        }
                    }
                } 
            }
            catch (IOException ex)
            {
                Console.Write(ex.ToString());
            }

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
            index--;
            updateButtons();
            updateQuestions();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            index++;
            updateButtons();
            updateQuestions();
        }
    }
}
