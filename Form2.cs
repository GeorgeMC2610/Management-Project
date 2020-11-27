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
                return;
            }

            label1.Text = (index + 1).ToString() + ") " + Thema.AllQuestions[index].Question;
            label2.Text = "Α: " + Thema.AllQuestions[index].Answers[0];
            label3.Text = "Β: " + Thema.AllQuestions[index].Answers[1];
            label4.Text = "Γ: " + Thema.AllQuestions[index].Answers[2];
            label5.Text = "Δ: " + Thema.AllQuestions[index].Answers[3];
            label7.Text = "Κεφάλαιο: " + Thema.AllQuestions[index].Chapter;

            switch (Thema.AllQuestions[index].Difficulty)
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

            label2.BackColor = label3.BackColor = label4.BackColor = label5.BackColor = default;
            switch(Thema.AllQuestions[index].RightAnswerIndex)
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
            if (Thema.AllQuestions.Count == 0)
            {
                button1.Enabled = button2.Enabled = false;
                return;
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
    }
}
