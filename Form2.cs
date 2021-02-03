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
        List<Thema> DummyThemaList = new List<Thema>();
        List<Thema> SelectedThemas = new List<Thema>();
        List<string> SelectedChapters = new List<string>();
        Random random = new Random();
        bool SelectMode;

        public Form2(bool SelectMode)
        {
            InitializeComponent();
            this.SelectMode = SelectMode;
            buttonSelectQuestion.Visible = buttonGenerateWord.Visible = labelOverview.Visible = menuStrip.Visible = SelectMode;
            buttonSelectQuestion.Enabled = buttonGenerateWord.Enabled = labelOverview.Enabled = menuStrip.Visible = SelectMode;

            buttonEditQuestion.Visible = buttonDeleteQuestion.Visible = !SelectMode;
            buttonEditQuestion.Enabled = buttonDeleteQuestion.Enabled = !SelectMode;

            this.BackColor = (SelectMode) ? SystemColors.GradientInactiveCaption : SystemColors.Menu;
            labelRightAnswer.BackColor = (SelectMode) ? Color.LimeGreen : Color.LightGreen;

            this.Text = (SelectMode) ? "Χειροκίνητη Επιλογή Θεμάτων" : "Προβολή Θεμάτων";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DummyThemaList.AddRange(Thema.AllQuestions);
            toolStripComboBoxSorting.SelectedIndex = 0;

            for (int i = 2; i <= Thema.mostAnswers; i++)
                ToolStripComboBoxMaxAnswers.Items.Add(i.ToString());

            ToolStripComboBoxMaxAnswers.SelectedIndex = ToolStripComboBoxMaxAnswers.Items.Count - 1;

            updateQuestions();
            updateButtons();
            updateLabels();
        }

        private void AnyButtonClicked(object sender, EventArgs e)
        {
            Button buttonClicked = (Button)sender;


            switch (buttonClicked.Name)
            {
                case "buttonExit":
                    if (SelectMode)
                    {
                        new Form1().Show();
                        Close();
                        return;
                    }

                    Thema.SaveQuestions();
                    new Form1().Show();
                    Close();
                    break;

                case "buttonPrev":
                    index = (index == 0) ? DummyThemaList.Count - 1 : index - 1;
                    updateButtons();
                    updateQuestions();
                    break;

                case "buttonNext":
                    index = (index == DummyThemaList.Count - 1) ? 0 : index + 1;
                    updateButtons();
                    updateQuestions();
                    break;

                case "buttonEditQuestion":
                    new FormAddQuestion(DummyThemaList[index].Question, index, DummyThemaList[index].Difficulty, DummyThemaList[index].RightAnswerIndex, DummyThemaList[index].Chapter, DummyThemaList[index].Answers.ToArray()).Show();
                    Close();
                    break;

                case "buttonDeleteQuestion":
                    if (MessageBox.Show("Αν διαγραφεί το θέμα από την τράπεζα, δεν υπάρχει τρόπος επαναφοράς. Έχετε σιγουρευτεί για αυτήν την ενέργεια;", "Διαγραφή Θέματος", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                        return;

                    Thema.AllQuestions.RemoveAt(index);
                    index = (index == 0) ? Thema.AllQuestions.Count - 1 : index - 1;

                    DummyThemaList.Clear();
                    DummyThemaList.AddRange(Thema.AllQuestions);

                    updateButtons();
                    updateQuestions();
                    break;

                case "buttonSelectQuestion":
                    if (!SelectedThemas.Contains(DummyThemaList[index]))
                    {
                        SelectedThemas.Add(DummyThemaList[index]);

                        if (!SelectedChapters.Contains(DummyThemaList[index].Chapter))
                            SelectedChapters.Add(DummyThemaList[index].Chapter);
                    }

                    else
                    {
                        SelectedThemas.Remove(DummyThemaList[index]);

                        if (SelectedChapters.Contains(DummyThemaList[index].Chapter))
                            SelectedChapters.Remove(DummyThemaList[index].Chapter);
                    }

                    updateLabels();
                    updateButtons();
                    break;

                case "buttonGenerateWord":
                    if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                        return;

                    richTextBoxToWord.Text = "";

                    foreach (Thema th in SelectedThemas)
                    {
                        //Αν οι απαντήσεις που πρόκειται να μπουν είναι μεγαλύτερες σε πλήθος από τις μέγιστες επιτρεπόμενες
                        if (th.Answers.Count > int.Parse(ToolStripComboBoxMaxAnswers.SelectedItem.ToString()))
                        {
                            //αν πρέπει να έχουμε ανακτεμμένες απαντήσεις
                            if (ToolStripMenuItemRandomizedAnswers.Checked)
                            {
                                //κράτα την σωστή απάντηση και μετά κόψε μερικά στοιχεία από τη λίστα
                                string rightAnswer = th.Answers[th.RightAnswerIndex];
                                th.Answers = RandomSelectionFromList(th.Answers, int.Parse(ToolStripComboBoxMaxAnswers.SelectedItem.ToString()));
                                //αν δεν βρεις την σωστή απάντηση μέσα στη λίστα, βάλ' την
                                if (!th.Answers.Contains(rightAnswer))
                                    th.Answers[random.Next(th.Answers.Count)] = rightAnswer;
                            }
                            //αν δεν πρέπει να 'χουμε ανακατεμμένες απαντήσεις
                            else
                            {
                                //κράτα την σωστή απάντηση και μετά κόψε τις υπόλοιπες
                                string rightAnswer = th.Answers[th.RightAnswerIndex];
                                int count = th.Answers.Count - int.Parse(ToolStripComboBoxMaxAnswers.SelectedItem.ToString());
                                for (int AA = 0; AA < count; AA++)
                                    th.Answers.RemoveAt(th.Answers.Count - 1);
                                //αν η απάντηση βρισκόταν σε μεγαλύτερη θέση από τις απαντήσεις που κόψαμε, τη βάζουμε ως τελευταία.
                                th.Answers[th.Answers.Count - 1] = (th.RightAnswerIndex + 1 > int.Parse(ToolStripComboBoxMaxAnswers.SelectedItem.ToString())) ? rightAnswer : th.Answers[th.Answers.Count - 1];
                            }
                        }
                        //αλλιώς ανάκατεψε τις απαντήσεις αν πρέπει. Αν δεν πρέπει, σημαίνει ότι τις αφήνουμε όπως είναι.
                        else if (ToolStripMenuItemRandomizedAnswers.Checked)
                            th.Answers = RandomSelectionFromList(th.Answers, th.Answers.Count);
                    }

                    switch (toolStripComboBoxSorting.SelectedIndex)
                    {
                        //στην περίπτωση που ο χρήστης έχει επιλέξει κανονική κατάταξη, δεν κάνουμε τίποτα. Τα θέματα είναι ήδη ανά κεφάλαιο
                        case 0:
                            SelectedThemas = SelectedThemas.OrderBy(th => Thema.QuestionsByChapter).ToList();
                            break;
                        //χρησιμοποιούμε Linq για την ταξινόμηση ανά attribute ερώτησης
                        case 1:
                            SelectedThemas = SelectedThemas.OrderBy(th => th.Difficulty).ToList();
                            break;
                        //χρησιμοποιούμε Linq για την ταξινόμηση ανά attribute κεφαλαίου
                        case 2:
                            SelectedThemas = SelectedThemas.OrderBy(th => th.Question).ToList();
                            break;
                        case 3:
                            SelectedThemas = SelectedThemas.OrderBy(th => th.Chapter).ToList();
                            break;
                        //χρησιμοποιούμε Linq για την ταξινόμηση ανά attribute δυσκολίας
                        case 4:
                            break;
                        //χρησιμοποιούμε την φτιαχτή RandomSelectionFromList για να παραχθεί μία τυχαία λίστα.
                        case 5:
                            SelectedThemas = RandomSelectionFromList(SelectedThemas, SelectedThemas.Count);
                            break;
                    }

                    if (ToolStripMenuItemReverse.Checked)
                        SelectedThemas.Reverse();

                    //ύστερα παράγουμε το αρχείο μέσω του richtextbox
                    int i = 0;
                    foreach (Thema th in SelectedThemas)
                    {
                        string Question = (i + 1).ToString() + ") " + th.Question + Environment.NewLine;
                        int length = richTextBoxToWord.Text.Length;
                        richTextBoxToWord.AppendText(Question);

                        int j = 0;
                        string stringGreekNumerals = "α,β,γ,δ,ε,στ,ζ,η,θ,ι,ια,ιβ,ιγ,ιδ,ιε,ιστ,ιζ,ιη,ιθ,κ,κα,κβ,κγ,κδ,κε,κστ,κζ,κη,κθ";
                        string[] GreekNumerals = stringGreekNumerals.Split(',');
                        foreach (string answer in th.Answers)
                        {
                            richTextBoxToWord.AppendText(GreekNumerals[j] + ". " + answer + Environment.NewLine);
                            j++;
                        }
                        richTextBoxToWord.AppendText(Environment.NewLine);

                        richTextBoxToWord.Select(length, Question.Length - 1);
                        richTextBoxToWord.SelectionFont = new Font(richTextBoxToWord.Font, FontStyle.Bold);

                        i++;
                    }

                    richTextBoxToWord.SaveFile(saveFileDialog.FileName);

                    DummyThemaList.Clear();
                    Thema.AcquireQuestions();
                    DummyThemaList.AddRange(Thema.AllQuestions);

                    for (i = 0; i < SelectedThemas.Count; i++)
                        for (int j = 0; j < DummyThemaList.Count; j++)
                            if (SelectedThemas[i].Question.Equals(DummyThemaList[j].Question))
                                SelectedThemas[i] = DummyThemaList[j];
                    break;
            }
        }

        private void AnyToolStripItemClickedOrChanged(object sender, EventArgs e)
        {
            ToolStripMenuItem pressed = (ToolStripMenuItem)sender;

            int previous_index;
            switch (pressed.Name)
            {
                case "ToolStripMenuItemSelectAllThemas":
                    if (MessageBox.Show("Είστε σίγουρος ότι θέλετε να επιλέξετε όλα τα θέματα όλων των κεφαλαίων;", "Επιλογή Πάντων", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                        return;

                    previous_index = index;

                    while (index != 0)
                        buttonPrev.PerformClick();

                    for (int i = 0; i < DummyThemaList.Count; i++)
                    {
                        if (buttonSelectQuestion.Text.Equals("Επιλογή Θέματος"))
                            buttonSelectQuestion.PerformClick();

                        buttonNext.PerformClick();
                    }

                    while (index != previous_index)
                        buttonPrev.PerformClick();

                    break;

                case "ToolStripMenuItemClearSelections":
                    if (MessageBox.Show("Είστε σίγουρος ότι θέλετε να γίνει εκκαθάριση των επιλογών σας;", "Εκκαθάριση Επιλογών", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                        return;

                    previous_index = index;

                    while (index != 0)
                        buttonPrev.PerformClick();

                    for (int i = 0; i < DummyThemaList.Count; i++)
                    {
                        if (buttonSelectQuestion.Text.Equals("Απόρριψη Θέματος"))
                            buttonSelectQuestion.PerformClick();

                        buttonNext.PerformClick();
                    }

                    while (index != previous_index)
                        buttonPrev.PerformClick();
                    break;

                case "ToolStripMenuItemSelectFont":
                    if (fontDialog.ShowDialog() == DialogResult.Cancel)
                        return;

                    richTextBoxToWord.Font = fontDialog.Font;
                    break;
            }
        }

        //μία συνάρτηση τυχαίας επιλογής
        private List<T> RandomSelectionFromList<T>(List<T> list, int times)
        {
            //πρώτα ανακατεύουμε τη λίστα
            for (int i = 1; i < list.Count; i++)
            {
                int rand = random.Next(0, 2);

                if (rand == 0)
                {
                    T temp = list[i];
                    list[i] = list[0];
                    list[0] = temp;
                }
            }

            if (times > list.Count)
                return list;

            //ύστερα κόβουμε στοιχεία, ώστε να έχει ακριβώς όσα μας είπε ο χρήστης.
            int itemsToRemove = list.Count - times;
            for (int i = 0; i < itemsToRemove; i++)
                list.RemoveAt(0);

            return list;
        }

        //to update the questions, I set all the labels to be the corresponding properties
        private void updateQuestions()
        {
            //but if there are no questions available, nothing happens.
            if (DummyThemaList.Count == 0)
            {
                labelQuestion.Text = "Η τράπεζα θεμάτων είναι άδεια.";
                labelChapter.Text = "Πηγαίνετε στο κύριο μενου, πατήστε \"Προσθήκη Θέματος\" κι όταν φτιάξετε το θέμα σας, θα το βρείτε εδώ!";
                labelRightAnswer.Text = labelDifficulty.Text = labelAnswers.Text = "";
                return;
            }

            Thema th = DummyThemaList[index];

            labelQuestion.Text = (index + 1).ToString() + ") " + th.Question;

            string stringGreekNumerals = "α,β,γ,δ,ε,στ,ζ,η,θ,ι,ια,ιβ,ιγ,ιδ,ιε,ιστ,ιζ,ιη,ιθ,κ,κα,κβ,κγ,κδ,κε,κστ,κζ,κη,κθ";
            string[] GreekNumerals = stringGreekNumerals.Split(',');

            int j = 0;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < th.Answers.Count; i++)
            {
                sb.Append(GreekNumerals[j] + ") ");
                sb.Append(th.Answers[i]);
                sb.Append(Environment.NewLine);

                if (j > 27)
                    j = 0;
                else
                    j++;
            }

            labelAnswers.Text = sb.ToString();
            labelRightAnswer.Text = GreekNumerals[th.RightAnswerIndex] + ") " + th.Answers[th.RightAnswerIndex]; //αυτό σημαίνει "η σωστή απάντηση" λμαο.

            labelAnswers.Location = new Point((Width / 2 - labelAnswers.Width / 2), labelAnswers.Location.Y);
            labelRightAnswer.Location = new Point((Width / 2 - labelAnswers.Width / 2), labelRightAnswer.Location.Y);

            labelChapter.Text = "Κεφάλαιο: " + th.Chapter;

            switch (th.Difficulty)
            {
                case 1:
                    labelDifficulty.Text = "Βαθμός δυσκολίας: Εύκολος";
                    break;
                case 2:
                    labelDifficulty.Text = "Βαθμός δυσκολίας: Μέτριος";
                    break;
                case 3:
                    labelDifficulty.Text = "Βαθμός δυσκολίας: Δύσκολος";
                    break;
            }

            CheckLabelSize();
        }

        private void updateButtons()
        {
            if (DummyThemaList.Count == 0)
            {
                buttonPrev.Enabled = buttonNext.Enabled = buttonEditQuestion.Enabled = buttonDeleteQuestion.Enabled = false;
                buttonDeleteQuestion.BackColor = Color.DarkGray;
                buttonDeleteQuestion.ForeColor = Color.Black;
            }
            else if (DummyThemaList.Count == 1)
            {
                buttonPrev.Enabled = buttonNext.Enabled = false;
                buttonEditQuestion.Enabled = buttonDeleteQuestion.Enabled = true;
                buttonDeleteQuestion.BackColor = Color.DarkRed;
                buttonDeleteQuestion.ForeColor = Color.White;
            }
            else
            {
                buttonPrev.Enabled = buttonNext.Enabled = buttonEditQuestion.Enabled = buttonDeleteQuestion.Enabled = true;
                buttonDeleteQuestion.BackColor = Color.DarkRed;
                buttonDeleteQuestion.ForeColor = Color.White;
            }

            if (!SelectMode)
                return;

            if (SelectedThemas.Contains(DummyThemaList[index]))
            {
                buttonSelectQuestion.BackColor = Color.Red;
                buttonSelectQuestion.Text = "Απόρριψη Θέματος";
                labelQuestion.ForeColor = Color.Green;
            }
            else
            {
                buttonSelectQuestion.BackColor = Color.Green;
                buttonSelectQuestion.Text = "Επιλογή Θέματος";
                labelQuestion.ForeColor = Color.Black;
            }


            if (SelectedThemas.Count > 0)
            {
                buttonGenerateWord.Enabled = true;
                buttonGenerateWord.BackColor = Color.RoyalBlue;
                buttonGenerateWord.ForeColor = Color.White;
            }
            else
            {
                buttonGenerateWord.Enabled = false;
                buttonGenerateWord.BackColor = Color.DarkGray;
                buttonGenerateWord.ForeColor = Color.White;
            }
        }

        private void updateLabels()
        {
            switch (SelectedThemas.Count)
            {
                default:
                    labelOverview.Text = "Θα παραχθούν συνολικά " + SelectedThemas.Count.ToString() + " ερωτήσεις από ";
                    labelOverview.Text += (SelectedChapters.Count == 1) ? "ένα κεφάλαιο" : SelectedChapters.Count.ToString() + " κεφάλαια.";
                    break;
                case 0:
                    labelOverview.Text = "Δεν θα παραχθεί καμμία ερώτηση.";
                    break;
                case 1:
                    labelOverview.Text = "Θα παραχθεί μία ερώτηση από ένα κεφάλαιο.";
                    break;
            }

            float percentage = (float)SelectedThemas.Count * 100 / (float)Thema.AllQuestions.Count;
            labelOverview.Text += " (" + percentage.ToString() + "%)";
        }

        private void Form2_Resize(object sender, EventArgs e)
        {
            CheckLabelSize();
        }

        private void CheckLabelSize()
        {
            Font f;

            f = new Font("Arial", 16f);
            labelQuestion.Font = f;

            float analogy = (float)labelQuestion.Size.Width / (float)this.Width;

            if (analogy > 1.6)
            {
                f = new Font("Arial", 8f);
                labelQuestion.Font = f;
            }

            else if (analogy > 1.2)
            {
                f = new Font("Arial", 10f);
                labelQuestion.Font = f;
            }

            else if (analogy > 0.9)
            {
                f = new Font("Arial", 13f);
                labelQuestion.Font = f;
            }
        }
    }
}
