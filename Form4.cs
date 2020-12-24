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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        List<Thema> QuestionsToBeIncluded = new List<Thema>();
        decimal[,] SelectedQuestions, MaxAvailableQuestions;
        int totalSelectedQuestions;

        //αλλάζουμε το πόσες ερωτήσεις επιλέγονται, βάσει των numericupdown
        private void numericUpDownEasyQuestions_ValueChanged(object sender, EventArgs e)
        {
            SelectedQuestions[comboBoxChapters.SelectedIndex, 0] = numericUpDownEasyQuestions.Value;

            updateLabelTotalDifficultyQuestions();
            updateLabelOverview();
            checkIfButtonCanBeEnabled();
        }

        private void numericUpDownNormalQuestions_ValueChanged(object sender, EventArgs e)
        {
            SelectedQuestions[comboBoxChapters.SelectedIndex, 1] = numericUpDownNormalQuestions.Value;

            updateLabelTotalDifficultyQuestions();
            updateLabelOverview();
            checkIfButtonCanBeEnabled();
        }

        private void numericUpDownHardQuestions_ValueChanged(object sender, EventArgs e)
        {
            SelectedQuestions[comboBoxChapters.SelectedIndex, 2] = numericUpDownHardQuestions.Value;

            updateLabelTotalDifficultyQuestions();
            updateLabelOverview();
            checkIfButtonCanBeEnabled();
        }

        //λέμε στον χρήστη πόσα θέματα επιλέγονται από κάθε δυσκολία στο κεφάλαιο.
        private void updateLabelTotalDifficultyQuestions()
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
        }

        private void updateLabelOverview()
        {
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
                    labelOverview.Text += (selectedChapters == 1)? "ένα κεφάλαιο" : selectedChapters.ToString() + " κεφάλαια";
                    break;
                case 0:
                    labelOverview.Text = "Δεν θα παραχθεί καμμία ερώτηση.";
                    break;
                case 1:
                    labelOverview.Text = "Θα παραχθεί μία ερώτηση από ένα κεφάλαιο";
                    break;
            }

            float percentage = (float) totalSelectedQuestions * 100 / (float) Thema.AllQuestions.Count;
            labelOverview.Text += " (" + percentage.ToString() + "%)";
        }

        //φτάνουμε σε αυτό το σημείο κάθε φορά που μπορούμε να πάμε να παράξουμε το αρχείο
        private void checkIfButtonCanBeEnabled()
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

            //εδώ είναι σαν να πατάμε κάθε κάθε φορά τα μάξιμουμ σε κάθε κεφάλαιο. Οπότε η δουλειά γίνεται αυτόματα για εμάς
            for (int i = 0; i < comboBoxChapters.Items.Count; i++)
            {
                comboBoxChapters.SelectedIndex = i;

                numericUpDownEasyQuestions.Value   = numericUpDownEasyQuestions.Maximum;
                numericUpDownNormalQuestions.Value = numericUpDownNormalQuestions.Maximum;
                numericUpDownHardQuestions.Value   = numericUpDownHardQuestions.Maximum;
            }
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
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            richTextBoxToWord.Text = "";

        }

        private void comboBoxChapters_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckNumericUpDownMaxValues();
        }

        private void CheckNumericUpDownMaxValues()
        {
            //θέτουμε για το παρών επιλεγμένο κεφάλαιο, να έχει τις μέγιστες επιλεγμένες ερωτήσεις 
            numericUpDownEasyQuestions.Maximum   = MaxAvailableQuestions[comboBoxChapters.SelectedIndex, 0];
            numericUpDownNormalQuestions.Maximum = MaxAvailableQuestions[comboBoxChapters.SelectedIndex, 1];
            numericUpDownHardQuestions.Maximum   = MaxAvailableQuestions[comboBoxChapters.SelectedIndex, 2];

            //κάθε φορά που αλλάζει το κεφάλαιο θα πρέπει να βλέπουμε τι είχε επιλέξει ο χρήστης και να το θέσουμε ανάλογα.
            numericUpDownEasyQuestions.Value     = SelectedQuestions[comboBoxChapters.SelectedIndex, 0];
            numericUpDownNormalQuestions.Value   = SelectedQuestions[comboBoxChapters.SelectedIndex, 1];
            numericUpDownHardQuestions.Value     = SelectedQuestions[comboBoxChapters.SelectedIndex, 2];

            //θα πρέπει να ενημερώσουμε και τα διαθέσιμα θέματα ανά κεφάλαιο
            int totalChapterQuestions = (int) (MaxAvailableQuestions[comboBoxChapters.SelectedIndex, 0] + MaxAvailableQuestions[comboBoxChapters.SelectedIndex, 1] + MaxAvailableQuestions[comboBoxChapters.SelectedIndex, 2]);
            labelChapterDesc.Text = (totalChapterQuestions == 1) ? "Ένα θέμα από αυτό το κεφάλαιο" : totalChapterQuestions.ToString() + " θέματα από αυτό το κεφάλαιο";
        }

        private void Form4_Load(object sender, EventArgs e)
        {
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
                MaxAvailableQuestions[i, 0] = (decimal) EasyQuestionsByChapter.Count;

                var NormalQuestionsByChapter = (from th in Thema.QuestionsByChapter[i] where th.Difficulty == 2 select th).ToList();
                MaxAvailableQuestions[i, 1]  = (decimal) NormalQuestionsByChapter.Count;

                var HardQuestionsByChapter  = (from th in Thema.QuestionsByChapter[i] where th.Difficulty == 3 select th).ToList();
                MaxAvailableQuestions[i, 2] = (decimal) HardQuestionsByChapter.Count;
            }

            //θέτουμε τον μέγιστο αριθμό απαντήσεων ανά ερώτηση να είναι ο πρώτος, ώστε να κάνουμε απλή εύρεση μεγίστου
            numericUpDownMaxAnswers.Maximum = Thema.mostAnswers;

            //βάζουμε τα κεφάλαια στο comboBox
            comboBoxChapters.Items.AddRange(Thema.Chapters.ToArray());
            comboBoxChapters.SelectedIndex = comboBoxSorting.SelectedIndex = 0;

            //το θέτουμε ως μηδέν για να μην υπάρχει περίπτωση να υπάρχει κενό επιλεγμένο κεφάλαιο.
            comboBoxChapters.SelectedIndex = 0;
            comboBoxSorting.SelectedIndex  = 0;

            //καλούμε αυτές τις μεθόδους ώστε να αρχικοποιηθούν τα πάντα
            updateLabelTotalDifficultyQuestions();
            updateLabelOverview();
            checkIfButtonCanBeEnabled();
        }
    }
}
