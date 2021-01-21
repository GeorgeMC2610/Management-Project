using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Management_Project
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        Random random = new Random();
        List<Thema> QuestionsToBeIncluded = new List<Thema>();
        decimal[,] SelectedQuestions, MaxAvailableQuestions;
        int totalSelectedQuestions;


        //αλλάζουμε το πόσες ερωτήσεις επιλέγονται, βάσει των numericupdown
        private void numericUpDownEasyQuestions_ValueChanged(object sender, EventArgs e)
        {
            SelectedQuestions[comboBoxChapters.SelectedIndex, 0] = numericUpDownEasyQuestions.Value;

            UpdateOverviewLabels();
            CheckIfButtonCanBeEnabled();
        }

        private void numericUpDownNormalQuestions_ValueChanged(object sender, EventArgs e)
        {
            SelectedQuestions[comboBoxChapters.SelectedIndex, 1] = numericUpDownNormalQuestions.Value;

            UpdateOverviewLabels();
            CheckIfButtonCanBeEnabled();
        }

        private void numericUpDownHardQuestions_ValueChanged(object sender, EventArgs e)
        {
            SelectedQuestions[comboBoxChapters.SelectedIndex, 2] = numericUpDownHardQuestions.Value;

            UpdateOverviewLabels();
            CheckIfButtonCanBeEnabled();
        }

        //λέμε στον χρήστη πόσα θέματα θα παραχθούν συνολικά, αλλά και πόσα επιλέγονται από κάθε δυσκολία στο κεφάλαιο.
        private void UpdateOverviewLabels()
        {
            //τα προσθέτουμε όλα μαζί και ύστερα τα εμφανίζουμε ανάλογα στον χρήστη
            int totalDifficultyQuestions = (int) (SelectedQuestions[comboBoxChapters.SelectedIndex, 0] + SelectedQuestions[comboBoxChapters.SelectedIndex, 1] + SelectedQuestions[comboBoxChapters.SelectedIndex, 2]);
            switch (totalDifficultyQuestions)
            {
                default:
                    labelTotalDifficultyQuestions.Text = totalDifficultyQuestions.ToString() + " θέματα θα επιλεγούν από το κεφάλαιο με τις παραπάνω δυσκολίες";
                    break;
                case 0:
                    labelTotalDifficultyQuestions.Text = "Δεν θα επιλεγούν θέματα από αυτό το κεφάλαιο.";
                    break;
                case 1:
                    labelTotalDifficultyQuestions.Text = "Ένα θέμα θα επιλεγεί από το κεφάλαιο αυτό με την παραπάνω δυσκολία";
                    break;
            }

            //Πρώτα βλέπουμε πόσες ερωτήσεις είναι μαζί.
            int selectedChapters = 0;
            totalSelectedQuestions = 0;
            foreach (int i in SelectedQuestions)
                totalSelectedQuestions += i;

            //ύστερα βλέπουμε πόσα είναι τα κεφάλαια
            for (int i = 0; i < comboBoxChapters.Items.Count; i++)
            {
                if (SelectedQuestions[i, 0] + SelectedQuestions[i, 1] + SelectedQuestions[i, 2] != 0)
                    selectedChapters++;
            }

            //και μετά κάνουμε πράγματα με το label
            switch (totalSelectedQuestions)
            {
                default:
                    labelOverview.Text = "Θα παραχθούν συνολικά " + totalSelectedQuestions.ToString() + " ερωτήσεις από ";
                    labelOverview.Text += (selectedChapters == 1) ? "ένα κεφάλαιο" : selectedChapters.ToString() + " κεφάλαια";
                    break;
                case 0:
                    labelOverview.Text = "Δεν θα παραχθεί καμμία ερώτηση.";
                    break;
                case 1:
                    labelOverview.Text = "Θα παραχθεί μία ερώτηση από ένα κεφάλαιο";
                    break;
            }

            float percentage = (float)totalSelectedQuestions * 100 / (float)Thema.AllQuestions.Count;
            labelOverview.Text += " (" + percentage.ToString() + "%)";
        }

        //φτάνουμε σε αυτό το σημείο κάθε φορά που μπορούμε να πάμε να παράξουμε το αρχείο
        private void CheckIfButtonCanBeEnabled()
        {
            //απενεργοποιούμε το κουμπί αν δεν υπάρχουν ερωτήσεις για παραγωγή
            if (totalSelectedQuestions == 0)
            {
                buttonGenerateWordFile.Enabled   = false;
                buttonGenerateWordFile.BackColor = Color.DarkGray;
                buttonGenerateWordFile.ForeColor = Color.Black;
            }
            //αν οι ερωτήσεις είναι λίγες, θα πρέπει να βάλουμε ξεχωριστό χρώμα
            else if (totalSelectedQuestions < 3)
            {
                buttonGenerateWordFile.Enabled   = true;
                buttonGenerateWordFile.BackColor = Color.Gold;
                buttonGenerateWordFile.ForeColor = Color.Black;
            }
            //αλλιώς το κουμπί παίρνει την κανονική μορφή του.
            else
            {
                buttonGenerateWordFile.Enabled   = true;
                buttonGenerateWordFile.BackColor = Color.RoyalBlue;
                buttonGenerateWordFile.ForeColor = Color.White;
            }
        }

        //κλείνουμε τη φόρμα με ασφαλή τρόπο
        private void button1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            Close();
        }

        private void buttonIncludeAllChapters_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Θέλετε πραγματικά να συμπεριλάβετε κάθε ερώτηση από κάθε δυσκολία από όλα τα κεφάλαια;", buttonIncludeAllChapters.Text, MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int currentSelectedIndex = comboBoxChapters.SelectedIndex;

            //εδώ είναι σαν να πατάμε κάθε κάθε φορά τα μάξιμουμ σε κάθε κεφάλαιο. Οπότε η δουλειά γίνεται αυτόματα για εμάς
            for (int i = 0; i < comboBoxChapters.Items.Count; i++)
            {
                comboBoxChapters.SelectedIndex = i;

                numericUpDownEasyQuestions.Value   = numericUpDownEasyQuestions.Maximum;
                numericUpDownNormalQuestions.Value = numericUpDownNormalQuestions.Maximum;
                numericUpDownHardQuestions.Value   = numericUpDownHardQuestions.Maximum;
            }

            comboBoxChapters.SelectedIndex = currentSelectedIndex;
        }

        private void numericUpDownMaxAnswers_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxSorting_SelectedIndexChanged(object sender, EventArgs e)
        {
            //απενεργοποιούμε το checkbox, αφού δεν έχει νόημα να αναποδογυρίσει μία τυχαία λίστα
            if (comboBoxSorting.SelectedIndex == 5)
            {
                checkBoxReverse.Checked = false;
                checkBoxReverse.Enabled = false;
            }
            else
                checkBoxReverse.Enabled = true;
        }

        //όταν πατιένται το κουμπί επιλέγουμε τις ερωτήσεις βάσει των κριτηρίων
        private void buttonGenerateWordFile_Click(object sender, EventArgs e)
        {
            //αν οι ερωτήσεις είναι λίγες, ενημερώνουμε τον χρήστη.
            if (totalSelectedQuestions < 3)
                if (MessageBox.Show("Έχετε επιλέξει λιγότερες από 3 ερωτήσεις, για το διαγώνισμα. Είστε σίγουρος, ότι δεν θέλετε να συμπεριλάβετε και άλλες;", "Ελάχιστες ερωτήσεις", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    return;

            //αν ο χρήστης δεν επιλέξει μέρος για να σώσει το αρχείο, δεν κάνουμε τίποτα.
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            //πρώτα πρέπει να σιγουρευτούμε ότι είναι άδειο το rich text box.
            QuestionsToBeIncluded.Clear();
            richTextBoxToWord.Text = "";

            //για κάθε κεφάλαιο, προσθέτουμε όσες ερωτήσεις έχει πει ο χρήστης.
            int i = 0;
            foreach (string ch in Thema.Chapters)
            {
                //για κάθε δυσκολία, επιλέγουμε όσες ερωτήσεις μας έχει πει ο χρήστης
                var TempEasyQuestions = (from th in Thema.EasyQuestions where th.Chapter.Equals(ch) select th).ToList();
                TempEasyQuestions = RandomSelectionFromList(TempEasyQuestions, (int) SelectedQuestions[i, 0]);
                QuestionsToBeIncluded.AddRange(TempEasyQuestions);

                var TempNormalQuestions = (from th in Thema.NormalQuestions where th.Chapter.Equals(ch) select th).ToList();
                TempNormalQuestions = RandomSelectionFromList(TempNormalQuestions, (int)SelectedQuestions[i, 1]);
                QuestionsToBeIncluded.AddRange(TempNormalQuestions);

                var TempHardQuestions = (from th in Thema.HardQuestions where th.Chapter.Equals(ch) select th).ToList();
                TempHardQuestions = RandomSelectionFromList(TempHardQuestions, (int)SelectedQuestions[i, 2]);
                QuestionsToBeIncluded.AddRange(TempHardQuestions);

                i++;
            }

            //κοιτάμε αν οι απαντήσεις είναι όπως πρέπει 
            foreach (Thema th in QuestionsToBeIncluded)
            {
                Random random = new Random();
                //Αν οι απαντήσεις που πρόκειται να μπουν είναι μεγαλύτερες σε πλήθος από τις μέγιστες επιτρεπόμενες
                if (th.Answers.Count > numericUpDownMaxAnswers.Value)
                {
                    //αν πρέπει να έχουμε ανακτεμμένες απαντήσεις
                    if (checkBoxRandomizedAnswers.Checked)
                    {
                        //κράτα την σωστή απάντηση και μετά κόψε μερικά στοιχεία από τη λίστα
                        string rightAnswer = th.Answers[th.RightAnswerIndex];
                        th.Answers = RandomSelectionFromList(th.Answers, (int)numericUpDownMaxAnswers.Value);
                        //αν δεν βρεις την σωστή απάντηση μέσα στη λίστα, βάλ' την
                        if (!th.Answers.Contains(rightAnswer))
                            th.Answers[random.Next(th.Answers.Count)] = rightAnswer;
                    }
                    //αν δεν πρέπει να 'χουμε ανακατεμμένες απαντήσεις
                    else
                    {
                        //κράτα την σωστή απάντηση και μετά κόψε τις υπόλοιπες
                        string rightAnswer = th.Answers[th.RightAnswerIndex];
                        int count = th.Answers.Count - (int)numericUpDownMaxAnswers.Value;
                        for (i = 0; i < count; i++)
                            th.Answers.RemoveAt(th.Answers.Count - 1);
                        //αν η απάντηση βρισκόταν σε μεγαλύτερη θέση από τις απαντήσεις που κόψαμε, τη βάζουμε ως τελευταία.
                        th.Answers[th.Answers.Count - 1] = (th.RightAnswerIndex + 1 > numericUpDownMaxAnswers.Value) ? rightAnswer : th.Answers[th.Answers.Count - 1];
                    }
                }
                //αλλιώς ανάκατεψε τις απαντήσεις αν πρέπει. Αν δεν πρέπει, σημαίνει ότι τις αφήνουμε όπως είναι.
                else if (checkBoxRandomizedAnswers.Checked)
                    th.Answers = RandomSelectionFromList(th.Answers, th.Answers.Count);
            }

            //ύστερα ταξινομούμε τα θέματα με τη σειρά που έχει προσδιορίσει ο χρήστης
            switch (comboBoxSorting.SelectedIndex)
            {
                //στην περίπτωση που ο χρήστης έχει επιλέξει κανονική κατάταξη, δεν κάνουμε τίποτα. Τα θέματα είναι ήδη ανά κεφάλαιο
                case 0:
                    break;
                //χρησιμοποιούμε Linq για την ταξινόμηση ανά attribute ερώτησης
                case 1:
                    QuestionsToBeIncluded = QuestionsToBeIncluded.OrderBy(th => th.Difficulty).ToList();
                    break;
                //χρησιμοποιούμε Linq για την ταξινόμηση ανά attribute κεφαλαίου
                case 2:
                    QuestionsToBeIncluded = QuestionsToBeIncluded.OrderBy(th => th.Question).ToList();
                    break;
                case 3:
                    QuestionsToBeIncluded = QuestionsToBeIncluded.OrderBy(th => th.Chapter).ToList();
                    break;
                //χρησιμοποιούμε Linq για την ταξινόμηση ανά attribute δυσκολίας
                case 4:
                    QuestionsToBeIncluded = QuestionsToBeIncluded.OrderBy(th => Thema.AllQuestions).ToList();
                    break;
                //χρησιμοποιούμε την φτιαχτή RandomSelectionFromList για να παραχθεί μία τυχαία λίστα.
                case 5:
                    QuestionsToBeIncluded = RandomSelectionFromList(QuestionsToBeIncluded, QuestionsToBeIncluded.Count);
                    break;
            }

            if (checkBoxReverse.Checked)
                QuestionsToBeIncluded.Reverse();

            //ύστερα παράγουμε το αρχείο μέσω του richtextbox
            i = 0;
            foreach (Thema th in QuestionsToBeIncluded)
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

            richTextBoxToWord.SaveFile(saveFileDialog1.FileName);
            Thema.AcquireQuestions();
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

        private void comboBoxChapters_SelectedIndexChanged(object sender, EventArgs e)
        {
            //για να μην υπάρξει πρόβλημα με τις τιμές όταν αλλάζουν τα κεφάλαια, πρώτα θέτουμε το μέγιστο να 'ναι ένας υπερβολικά μεγάλος αριθμός.
            numericUpDownEasyQuestions.Maximum   = decimal.MaxValue;
            numericUpDownNormalQuestions.Maximum = decimal.MaxValue;
            numericUpDownHardQuestions.Maximum   = decimal.MaxValue;

            //κάθε φορά που αλλάζει το κεφάλαιο θα πρέπει να βλέπουμε τι είχε επιλέξει ο χρήστης και να το θέσουμε ανάλογα.
            numericUpDownEasyQuestions.Value     = SelectedQuestions[comboBoxChapters.SelectedIndex, 0];
            numericUpDownNormalQuestions.Value   = SelectedQuestions[comboBoxChapters.SelectedIndex, 1];
            numericUpDownHardQuestions.Value     = SelectedQuestions[comboBoxChapters.SelectedIndex, 2];

            //θέτουμε για το παρών επιλεγμένο κεφάλαιο, να έχει τις μέγιστες επιλεγμένες ερωτήσεις 
            numericUpDownEasyQuestions.Maximum   = MaxAvailableQuestions[comboBoxChapters.SelectedIndex, 0];
            numericUpDownNormalQuestions.Maximum = MaxAvailableQuestions[comboBoxChapters.SelectedIndex, 1];
            numericUpDownHardQuestions.Maximum   = MaxAvailableQuestions[comboBoxChapters.SelectedIndex, 2];

            //θα πρέπει να ενημερώσουμε και τα διαθέσιμα θέματα ανά κεφάλαιο
            int totalChapterQuestions = (int)(MaxAvailableQuestions[comboBoxChapters.SelectedIndex, 0] + MaxAvailableQuestions[comboBoxChapters.SelectedIndex, 1] + MaxAvailableQuestions[comboBoxChapters.SelectedIndex, 2]);
            labelChapterDesc.Text = (totalChapterQuestions == 1) ? "Ένα θέμα από αυτό το κεφάλαιο" : totalChapterQuestions.ToString() + " θέματα από αυτό το κεφάλαιο";
        }

        private void ToolStripMenuItemSelectFont_Click(object sender, EventArgs e)
        {
            //ο χρήστης μπορεί να διαλέξει εκείνος την γραμματοσειρά την οποία θέλει να έχει το διαγώνισμα.
            if (fontDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            richTextBoxToWord.Font = fontDialog1.Font;
        }

        private void ToolStripMenuItemAllDifficulties_Click(object sender, EventArgs e)
        {
            //αφού ο Χρήστης θέλει να συμπεριληφθούν
            numericUpDownEasyQuestions.Value   = numericUpDownEasyQuestions.Maximum;
            numericUpDownNormalQuestions.Value = numericUpDownNormalQuestions.Maximum;
            numericUpDownHardQuestions.Value   = numericUpDownHardQuestions.Maximum;
        }

        //για κάθε δυσκολία, ο χρήστης έχει τη δυνατότητα να συμπεριλάβει όλες τις ερωτήσεις
        private void ToolStripMenuItemEasyQuestions_Click(object sender, EventArgs e)
        {
            numericUpDownEasyQuestions.Value = numericUpDownEasyQuestions.Maximum;
        }

        private void ToolStripMenuItemNormalQuestions_Click(object sender, EventArgs e)
        {
            numericUpDownNormalQuestions.Value = numericUpDownNormalQuestions.Maximum;
        }

        private void ToolStripMenuItemHardQuestions_Click(object sender, EventArgs e)
        {
            numericUpDownHardQuestions.Value = numericUpDownHardQuestions.Maximum;
        }

        private void ToolStripMenuItemClearSelectionsFromAllChapters_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Είστε σίγουρος ότι θέλετε να εκκαθαρισθούν οι επιλογές σας;", "Να μην συμπεριληφθεί τίποτα από κανένα κεφάλαιο.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            int currentSelectedIndex = comboBoxChapters.SelectedIndex;

            //θέτουμε για κάθε κεφάλαιο το 0, ώστε να μην συμπεριληφθεί τίποτα
            for (int i = 0; i < comboBoxChapters.Items.Count; i++)
            {
                comboBoxChapters.SelectedIndex = i;

                numericUpDownEasyQuestions.Value   = 0;
                numericUpDownNormalQuestions.Value = 0;
                numericUpDownHardQuestions.Value   = 0;
            }

            comboBoxChapters.SelectedIndex = currentSelectedIndex;
        }

        private void ToolStripMenuItemClearSelectionsFromThisChapter_Click(object sender, EventArgs e)
        {
            //αφού ο χρήστης δεν θέλει να συμπεριληφθεί τίποτα από το τρέχον κεφάλαιο, απλά μηδενίζουμε τα domainUpDown.
            numericUpDownEasyQuestions.Value   = 0;
            numericUpDownNormalQuestions.Value = 0;
            numericUpDownHardQuestions.Value   = 0;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //θέτουμε τον μέγιστο αριθμό απαντήσεων ανά ερώτηση να είναι ο πρώτος, ώστε να κάνουμε απλή εύρεση μεγίστου
            numericUpDownMaxAnswers.Maximum = Thema.mostAnswers;
            numericUpDownMaxAnswers.Value   = numericUpDownMaxAnswers.Maximum;

            //ορίζουμε τους δισδιάστατους πίνακές μας ανάλογα
            SelectedQuestions     = new decimal[Thema.Chapters.Count, 3];
            MaxAvailableQuestions = new decimal[Thema.Chapters.Count, 3];

            //μηδενίζουμε το πόσες ερωτήσεις είναι επιλεγμένες
            for (int i = 0; i < Thema.Chapters.Count; i++)
                for (int j = 0; j < 3; j++)
                    SelectedQuestions[i, j] = 0;

            totalSelectedQuestions = 0;

            //θέτουμε το πόσες ερωτήσεις μπορούν να επιλεγούν ανά δυσκολία και κεφάλαιο
            for (int i = 0; i < Thema.Chapters.Count; i++)
            {
                var EasyQuestionsByChapter  = (from th in Thema.QuestionsByChapter[i] where th.Difficulty == 1 select th).ToList();
                MaxAvailableQuestions[i, 0] = EasyQuestionsByChapter.Count;

                var NormalQuestionsByChapter = (from th in Thema.QuestionsByChapter[i] where th.Difficulty == 2 select th).ToList();
                MaxAvailableQuestions[i, 1]  = NormalQuestionsByChapter.Count;

                var HardQuestionsByChapter  = (from th in Thema.QuestionsByChapter[i] where th.Difficulty == 3 select th).ToList();
                MaxAvailableQuestions[i, 2] = HardQuestionsByChapter.Count;
            }

            //βάζουμε τα κεφάλαια στο comboBox
            comboBoxChapters.Items.AddRange(Thema.Chapters.ToArray());
            comboBoxChapters.SelectedIndex = comboBoxSorting.SelectedIndex = 0;

            //το θέτουμε ως μηδέν για να μην υπάρχει περίπτωση να υπάρχει κενό επιλεγμένο κεφάλαιο.
            comboBoxChapters.SelectedIndex = 0;
            comboBoxSorting.SelectedIndex  = 0;

            //καλούμε αυτές τις μεθόδους ώστε να αρχικοποιηθούν τα πάντα
            UpdateOverviewLabels();
            CheckIfButtonCanBeEnabled();
        }
    }
}
