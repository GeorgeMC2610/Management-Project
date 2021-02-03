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

        //for editing
        string Question, Chapter;
        int index, rightIndex, difficulty;
        string[] answers;
        bool editing;

        public FormAddQuestion()
        {
            InitializeComponent();
            editing = false;
        }

        public FormAddQuestion(string Question, int index, int difficulty, int rightIndex, string Chapter, params string[] answers)
        {
            InitializeComponent();
            this.Question = Question;
            this.index = index;
            this.rightIndex = rightIndex;
            this.answers = answers;
            this.difficulty = difficulty;
            this.Chapter = Chapter;
            editing = true;
        }

        private void EnableEditQuestions()
        {
            textBoxQuestion.Text = Question;
            numericUpDown1.Value = difficulty;

            possibleAnswers[0] = answers[0];
            possibleAnswers[1] = answers[1];
            for (int i = 2; i < answers.Length; i++)
                possibleAnswers.Add(answers[i]);

            rightAnswerIndex = rightIndex;
            rightAnswerIndex++;
            buttonPrev.PerformClick();

            int ChapterIndex = 0;
            foreach (string ch in Thema.Chapters)
            {
                if (ch.Equals(Chapter))
                    break;

                ChapterIndex++;
            }

            domainUpDownChapters.SelectedIndex = ChapterIndex+1;
            CheckIfButtonCanBeEnabled();
        }

        private void FormAddQuestion_Load(object sender, EventArgs e)
        {
            //με το που ξεκινά η φόρμα, βάζω δύο άδειες απαντήσεις
            possibleAnswers.Add("");
            possibleAnswers.Add("");

            //μετά αμέσως απανεργοποιώ το κουμπί (όλα τα πεδία είναι άδεια)
            CheckIfButtonCanBeEnabled();
            labelNotification.Visible = false;
            checkBoxIsRightAnswer.Checked = true;

            //βάζω και τα κεφάλαια στο λιστμποξ
            UpdateChapters();
            domainUpDownChapters.SelectedIndex = 0;

            if (editing)
                EnableEditQuestions();

            buttonAddQuestion.Text = "ΤΡΟΠΟΙΗΣΗ ΘΕΜΑΤΟΣ";
        }

        private void AnyButtonClicked(object sender, EventArgs e)
        {
            Button buttonClicked = (Button)sender;

            switch (buttonClicked.Name)
            {
                case "buttonNext":
                    //πηγαίνοντας από τη μία απάντηση στην άλλη, θέλουμε να κάνουμε το εφέ «επιστροφής» στην ίδια απάντηση.
                    answerIndex = (answerIndex == possibleAnswers.Count) ? 1 : answerIndex + 1;
                    labelAnswer.Text = "Απάντηση " + answerIndex.ToString();

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

                    break;

                case "buttonPrev":
                    //πηγαίνοντας από τη μία απάντηση στην άλλη, θέλουμε να κάνουμε το εφέ «επιστροφής» στην ίδια απάντηση.
                    answerIndex = (answerIndex == 1) ? possibleAnswers.Count : answerIndex - 1;
                    labelAnswer.Text = "Απάντηση " + answerIndex.ToString();

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
                    break;

                case "buttonAddPossibleAnswer":
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
                    break;

                case "buttonDeleteAnswer":
                    if (rightAnswerIndex == answerIndex)
                        rightAnswerIndex--;

                    possibleAnswers.RemoveAt(answerIndex - 1);
                    buttonPrev.PerformClick();
                    break;

                case "buttonReviewThema":
                    //για λόγους μνήμης φτιάχνουμε string builder.
                    StringBuilder sb = new StringBuilder();

                    //και απ' ευθείας βάζουμε ερώτηση και κεφάλαιο
                    sb.Append("ΕΡΩΤΗΣΗ: " + textBoxQuestion.Text + Environment.NewLine + Environment.NewLine);
                    sb.Append("ΚΕΦΑΛΑΙΟ: " + domainUpDownChapters.Text + Environment.NewLine + Environment.NewLine);

                    //ύστερα βάζουμε σε μορφή κειμένου τον βαθμό δυσκολίας
                    if (numericUpDown1.Value == 1)
                        sb.Append("ΒΑΘΜΟΣ ΔΥΣΚΟΛΙΑΣ: Eύκολος" + Environment.NewLine + Environment.NewLine);
                    else if (numericUpDown1.Value == 2)
                        sb.Append("ΒΑΘΜΟΣ ΔΥΣΚΟΛΙΑΣ: Μέτριος" + Environment.NewLine + Environment.NewLine);
                    else
                        sb.Append("ΒΑΘΜΟΣ ΔΥΣΚΟΛΙΑΣ: Δύσκολος" + Environment.NewLine + Environment.NewLine);

                    //μετά βάζουμε τις απαντήσεις, με ελληνικά αρίθμιση
                    string stringGreekNumerals = "α,β,γ,δ,ε,στ,ζ,η,θ,ι,ια,ιβ,ιγ,ιδ,ιε,ιστ,ιζ,ιη,ιθ,κ,κα,κβ,κγ,κδ,κε,κστ,κζ,κη,κθ";
                    string[] GreekNumerals = stringGreekNumerals.Split(',');

                    int count = 0;
                    foreach (string s in possibleAnswers)
                    {
                        if (s.Equals(possibleAnswers[rightAnswerIndex - 1]))
                            sb.Append(GreekNumerals[count] + ") " + s + " (Σ)" + Environment.NewLine);
                        else
                            sb.Append(GreekNumerals[count] + ") " + s + Environment.NewLine);

                        if (count > 27)
                            count = 0;
                        else
                            count++;
                    }

                    //και ύστερα εμφανίζουμε σε message box το περιεχόμενο του string builder.
                    string message = sb.ToString();
                    MessageBox.Show(message, "Επισκόπηση Ερώτησης");
                    break;

                case "buttonAddQuestion":
                    if (editing)
                    {
                        Thema.AllQuestions[index].Question         = textBoxQuestion.Text;
                        Thema.AllQuestions[index].Answers          = possibleAnswers;
                        Thema.AllQuestions[index].Difficulty       = (int)numericUpDown1.Value;
                        Thema.AllQuestions[index].Chapter          = domainUpDownChapters.SelectedItem.ToString();
                        Thema.AllQuestions[index].RightAnswerIndex = rightAnswerIndex - 1;

                        new Form2(false).Show();
                        Close();
                        return;
                    }

                    if (MessageBox.Show("Έχετε σιγουρευτεί για όλες τις ιδιότητες του θέματος και θέλετε πράγματι να το προσθέσετε;", "Επιβεβαίωση Θέματος", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        Thema thema = new Thema((int)numericUpDown1.Value, rightAnswerIndex - 1, textBoxQuestion.Text, domainUpDownChapters.Text, possibleAnswers.ToArray());
                        ClearFields();
                    }
                    break;

                case "buttonClearFields":
                    ClearFields();
                    break;

                case "buttonExit":
                    Thema.SaveQuestions();
                    new Form1().Show();
                    Close();
                    break;
            }
        }

        private void AnyTextBoxChanged(object sender, EventArgs e)
        {
            TextBox textboxChanged = (TextBox)sender;

            switch (textboxChanged.Name)
            {
                case "textBoxAnswer":
                    //θέτουμε την ερώτηση σε αυτήν που ήδη είμαστε και μετά ελέγχουμε αν το κουμπί μπορεί να πατηθεί
                    possibleAnswers[answerIndex - 1] = textBoxAnswer.Text;
                    CheckIfButtonCanBeEnabled();
                    break;

                case "textBoxQuestion":
                    //κάθε φορά που το πεδίο αλλάζει, μπορώ να δω αν το κουμπί μπορεί να ενεργοποιηθεί
                    CheckIfButtonCanBeEnabled();
                    break;
            }
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
            if (textBoxQuestion.Text.Equals("") || domainUpDownChapters.Text.Equals("") || CheckEmptyAnswer())
            {
                labelNotification.Visible   = false;
                buttonAddQuestion.Enabled   = false;
                buttonAddQuestion.BackColor = Color.Gray;
                buttonAddQuestion.ForeColor = Color.Black;
            }
            else if (!textBoxQuestion.Text.EndsWith(";") && !textBoxQuestion.Text.EndsWith("?"))
            {
                labelNotification.Visible   = true;
                buttonAddQuestion.Enabled   = true;
                buttonAddQuestion.BackColor = Color.Gold;
                buttonAddQuestion.ForeColor = Color.Black;
            }
            else
            {
                labelNotification.Visible   = false;
                buttonAddQuestion.Enabled   = true;
                buttonAddQuestion.BackColor = SystemColors.HotTrack;
                buttonAddQuestion.ForeColor = Color.White;
            }
        }

        private void UpdateChapters()
        {
            domainUpDownChapters.Items.Clear();
            domainUpDownChapters.Items.Add("");
            foreach (Thema th in Thema.AllQuestions)
            {
                if (!domainUpDownChapters.Items.Contains(th.Chapter))
                    domainUpDownChapters.Items.Add(th.Chapter);
            }
        }

        private void ClearFields()
        {
            UpdateChapters();
            textBoxQuestion.Text = "";
            domainUpDownChapters.SelectedIndex = 0;
            numericUpDown1.Value = 1;

            while (answerIndex != possibleAnswers.Count)
                buttonNext.PerformClick();

            while (buttonDeleteAnswer.Enabled)
                buttonDeleteAnswer.PerformClick();

            possibleAnswers[0] = possibleAnswers[1] = "";

            while (answerIndex != 1)
                buttonPrev.PerformClick();

            rightAnswerIndex = 1;
            textBoxAnswer.Text = "";
        }

        private void checkBoxIsRightAnswer_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxIsRightAnswer.Checked)
                rightAnswerIndex = answerIndex;
        }
    }
}