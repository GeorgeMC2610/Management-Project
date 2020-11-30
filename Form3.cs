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
    public partial class FormAddQuestion : Form
    {
        List<string> possibleAnswers = new List<string>();
        int answerIndex = 1;

        public FormAddQuestion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void CheckIfButtonCanBeEnabled()
        {
            //φτιάχνω μία boolean συνάρτηση μέσα στην ήδη υπάρχουσα, που επιστρέφει αν μία από τις απαντήσεις είναι άδεια.
            bool CheckEmptyAnswer()
            {
                foreach (string s in possibleAnswers)
                    if (s.Equals(""))
                        return true;

                return false;
            }

            //μετά τσεκάρω αν το κουμπί μπορεί να ενεργοποιηθεί, δηλαδή αν δεν είναι άδεια τα πεδία της ερώτησης και του κεφαλαίου, κι αν υπάρχουν πιθανές απαντήσεις.
            if (textBox1.Text.Equals("") || textBoxChapter.Text.Equals("") || CheckEmptyAnswer())
            {
                buttonAddQuestion.Enabled   = false;
                buttonAddQuestion.BackColor = Color.Gray;
                buttonAddQuestion.ForeColor = Color.Black;
            }
            else
            {
                buttonAddQuestion.Enabled   = true;
                buttonAddQuestion.BackColor = SystemColors.HotTrack;
                buttonAddQuestion.ForeColor = Color.White;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //κάθε φορά που το πεδίο αλλάζει, μπορώ να δω αν το κουμπί μπορεί να ενεργοποιηθεί
            CheckIfButtonCanBeEnabled();
        }

        private void FormAddQuestion_Load(object sender, EventArgs e)
        {
            //με το που ξεκινά η φόρμα, βάζω δύο άδειες απαντήσεις
            possibleAnswers.Add("");
            possibleAnswers.Add("");

            //μετά αμέσως απανεργοποιώ το κουμπί (όλα τα πεδία είναι άδεια)
            CheckIfButtonCanBeEnabled();
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            //πηγαίνοντας από τη μία απάντηση στην άλλη, θέλουμε να κάνουμε το εφέ «επιστροφής» στην ίδια απάντηση.
            answerIndex        = (answerIndex == 1) ? possibleAnswers.Count : answerIndex - 1;
            labelAnswer.Text   = "Απάντηση " + answerIndex.ToString();

            //όπως επίσης πηγαίνοντας από την μία απάντηση στην άλλη θέλουμε να δείχνουμε στον χρήστη την παρούσα απάντηση
            textBoxAnswer.Text = possibleAnswers[answerIndex - 1];
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            //πηγαίνοντας από τη μία απάντηση στην άλλη, θέλουμε να κάνουμε το εφέ «επιστροφής» στην ίδια απάντηση.
            answerIndex = (answerIndex == possibleAnswers.Count)? 1 : answerIndex + 1;
            labelAnswer.Text   = "Απάντηση " + answerIndex.ToString();

            //όπως επίσης πηγαίνοντας από την μία απάντηση στην άλλη θέλουμε να δείχνουμε στον χρήστη την παρούσα απάντηση
            textBoxAnswer.Text = possibleAnswers[answerIndex - 1];
        }

        private void buttonConfirmAnswer_Click(object sender, EventArgs e)
        {
            //θέτουμε την ερώτηση σε αυτήν που ήδη είμαστε και μετά ελέγχουμε αν το κουμπί μπορεί να πατηθεί
            possibleAnswers[answerIndex - 1] = textBoxAnswer.Text;
            CheckIfButtonCanBeEnabled();
        }

        private void buttonAddQuestion_Click(object sender, EventArgs e)
        {
            
        }

        private void textBoxChapter_TextChanged(object sender, EventArgs e)
        {
            CheckIfButtonCanBeEnabled();
        }

        private void buttonReviewThema_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (string s in possibleAnswers)
            {
                sb.Append(s + Environment.NewLine);
            }

            string message = sb.ToString();
            MessageBox.Show(message);
        }

        private void buttonAddPossibleAnswer_Click(object sender, EventArgs e)
        {
            possibleAnswers.Add("");
            buttonNext.PerformClick();
        }
    }
}
