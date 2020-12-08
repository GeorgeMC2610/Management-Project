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
        int answerIndex = 1, rightAnswerIndex = 1;

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
            if (textBox1.Text.Equals("") || domainUpDownChapters.Text.Equals("") || CheckEmptyAnswer())
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
            checkBoxIsRightAnswer.Checked = true;

            //βάζω και τα κεφάλαια στο λιστμποξ
            UpdateChapters();
        }

        private void UpdateChapters()
        {
            domainUpDownChapters.Items.Clear();

            foreach (Thema th in Thema.AllQuestions)
            {
                if (!domainUpDownChapters.Items.Contains(th.Chapter))
                    domainUpDownChapters.Items.Add(th.Chapter);
            }
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            //πηγαίνοντας από τη μία απάντηση στην άλλη, θέλουμε να κάνουμε το εφέ «επιστροφής» στην ίδια απάντηση.
            answerIndex        = (answerIndex == 1) ? possibleAnswers.Count : answerIndex - 1;
            labelAnswer.Text   = "Απάντηση " + answerIndex.ToString();

            //όπως επίσης πηγαίνοντας από την μία απάντηση στην άλλη θέλουμε να δείχνουμε στον χρήστη την παρούσα απάντηση
            textBoxAnswer.Text = possibleAnswers[answerIndex - 1];

            //ελέγχουμε και αν πρέπει να τικάρουμε το τσεκ μποξ
            checkBoxIsRightAnswer.Checked = (rightAnswerIndex == answerIndex);

            //ενεργοποιούμε το κουμπί αν και μόνο αν είναι μεγαλύτερο του 2 το ίντεξ
            if (answerIndex > 2)
            {
                buttonDeleteAnswer.Enabled = true;
                buttonDeleteAnswer.Visible = true;
            }
            else
            {
                buttonDeleteAnswer.Enabled = false;
                buttonDeleteAnswer.Visible = false;
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            //πηγαίνοντας από τη μία απάντηση στην άλλη, θέλουμε να κάνουμε το εφέ «επιστροφής» στην ίδια απάντηση.
            answerIndex = (answerIndex == possibleAnswers.Count)? 1 : answerIndex + 1;
            labelAnswer.Text   = "Απάντηση " + answerIndex.ToString();

            //όπως επίσης πηγαίνοντας από την μία απάντηση στην άλλη θέλουμε να δείχνουμε στον χρήστη την παρούσα απάντηση
            textBoxAnswer.Text = possibleAnswers[answerIndex - 1];

            //ελέγχουμε κι αν πρέπει να τικάρουμε το τσεκμποξ
            checkBoxIsRightAnswer.Checked = (rightAnswerIndex == answerIndex);

            //ενεργοποιούμε το κουμπί αν και μόνο αν είναι μεγαλύτερο του 2 το ίντεξ
            if (answerIndex > 2)
            {
                buttonDeleteAnswer.Enabled = true;
                buttonDeleteAnswer.Visible = true;
            }
            else
            {
                buttonDeleteAnswer.Enabled = false;
                buttonDeleteAnswer.Visible = false;
            }
        }

        private void buttonConfirmAnswer_Click(object sender, EventArgs e)
        {
            
        }

        private void ClearFields()
        {
            textBox1.Text = domainUpDownChapters.Text = "";
            numericUpDown1.Value = 1;

            while (buttonDeleteAnswer.Enabled)
                buttonDeleteAnswer.PerformClick();

            possibleAnswers[0] = possibleAnswers[1] = "";
            rightAnswerIndex = 1;
            answerIndex = 2;
            buttonPrev.PerformClick();
        }

        private void buttonAddQuestion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Έχετε σιγουρευτεί για όλες τις ιδιότητες του θέματος και θέλετε πράγματι να το προσθέσετε;", "Επιβεβαίωση Θέματος", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Thema thema = new Thema((int) numericUpDown1.Value, rightAnswerIndex - 1, textBox1.Text, domainUpDownChapters.Text, possibleAnswers.ToArray());
                ClearFields();
            }

            UpdateChapters();
        }

        private void textBoxChapter_TextChanged(object sender, EventArgs e)
        {
            //κάθε φορά που αλλάζει το textbox μπορούμε να δούμε αν μπορεί να ενεργοποιηθεί το κουμπί.
            CheckIfButtonCanBeEnabled();
        }

        private void buttonReviewThema_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("ΕΡΩΤΗΣΗ: "  + textBox1.Text             + Environment.NewLine + Environment.NewLine);
            sb.Append("ΚΕΦΑΛΑΙΟ: " + domainUpDownChapters.Text + Environment.NewLine + Environment.NewLine);

            string stringGreekNumerals = "α,β,γ,δ,ε,στ,ζ,η,θ,ι,ια,ιβ,ιγ,ιδ,ιε,ιστ,ιζ,ιη,ιθ,κ,κα,κβ,κγ,κδ,κε,κστ,κζ,κη,κθ";
            string[] GreekNumerals = stringGreekNumerals.Split(',');

            int count = 0;
            foreach (string s in possibleAnswers)
            {
                if (s.Equals(possibleAnswers[rightAnswerIndex - 1]))
                    sb.Append(GreekNumerals[count] + ") " + s + " (Σ)" + Environment.NewLine);
                else
                    sb.Append(GreekNumerals[count] + ") " + s + Environment.NewLine);

                count++;
            }

            string message = sb.ToString();
            MessageBox.Show(message, "Επισκόπηση Ερώτησης");
        }

        private void buttonAddPossibleAnswer_Click(object sender, EventArgs e)
        {
            //βάλε μια κενή ερώτηση
            possibleAnswers.Add("");
            
            //αν είναι ήδη στο τέλος ο χρήστης, απλά «πάτα» το κουμπί του επομένου, θα κάνει όλη τη δουλειά για εμάς
            if (answerIndex == possibleAnswers.Count - 1) 
                buttonNext.PerformClick();
            //αν δεν είναι ήδη, τον πάμε εμείς
            else
            {
                answerIndex = possibleAnswers.Count - 1;
                buttonNext.PerformClick();
            }

            CheckIfButtonCanBeEnabled();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Thema.SaveQuestions();

            new Form1().Show();
            Close();
        }

        private void textBoxAnswer_TextChanged(object sender, EventArgs e)
        {
            //θέτουμε την ερώτηση σε αυτήν που ήδη είμαστε και μετά ελέγχουμε αν το κουμπί μπορεί να πατηθεί
            possibleAnswers[answerIndex - 1] = textBoxAnswer.Text;
            CheckIfButtonCanBeEnabled();
        }

        private void buttonDeleteAnswer_Click(object sender, EventArgs e)
        {
            if (rightAnswerIndex == answerIndex)
                rightAnswerIndex--;

            possibleAnswers.RemoveAt(answerIndex - 1);
            buttonPrev.PerformClick();
        }

        private void buttonClearFields_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void checkBoxIsRightAnswer_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxIsRightAnswer.Checked)
                rightAnswerIndex = answerIndex;
        }
    }
}
