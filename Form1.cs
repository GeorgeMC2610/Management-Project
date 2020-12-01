using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_Project
{
    public partial class Form1 : Form
    {
        public Form1() 
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) 
        {
            Thema.AcquireQuestions();
            checkButton();
            labelAvailableQuestions.Text = Thema.AllQuestions.Count.ToString() + " Διαθέσιμες Ερωτήσεις";
        }

        private void checkButton()
        {
            if (Thema.AllQuestions.Count == 0)
            {
                wordFileButton.Enabled = false;
                wordFileButton.BackColor = Color.Gray;
                wordFileButton.ForeColor = Color.Black;
            }
            else
            {
                wordFileButton.Enabled = true;
                wordFileButton.BackColor = SystemColors.HotTrack;
                wordFileButton.ForeColor = Color.White;
            }
        }

        private void editQuestionsButton_Click(object sender, EventArgs e)
        {
            Hide();
            new Form2().Show();
        }

        private void deleteAllQuestionsButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Έχετε σιγουρευτεί ότι θέλετε να σβήσετε ΟΛΑ τα θέματα από την τράπεζα; (" + Thema.AllQuestions.Count.ToString() + " θέματα).\n\n Δεν υπάρχει τρόπος για την επαναφορά τους, αν σβησθούν.", "ΣΒΗΣΙΜΟ ΟΛΩΝ ΤΩΝ ΘΕΜΑΤΩΝ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Thema.AllQuestions.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FormAddQuestion().Show();
            Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Thema.SaveQuestions();
        }
    }
}
