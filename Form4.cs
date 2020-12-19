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

        //ΓΤΧΜ ΟΛΟ ΛΙΣΤΕΣ ΦΤΙΑΧΝΩ
        List<int> easyQuestions     = new List<int>();
        List<int> normalQuestions   = new List<int>();
        List<int> hardQuestions     = new List<int>();
        int[] selectedEasyQuestions;
        int[] selectedNormalQuestions;
        int[] selectedHardQuestions;

        int totalEasyQuestions, totalNormalQuestions, totalHardQuestions, totalQuestions, maxAvailableAnswers;

        //αλλάζουμε το πόσες ερωτήσεις επιλέγονται, βάσει των numericupdown
        private void numericUpDownEasyQuestions_ValueChanged(object sender, EventArgs e)
        {
            selectedEasyQuestions[comboBoxChapters.SelectedIndex] = (int)numericUpDownEasyQuestions.Value;
        }

        private void numericUpDownNormalQuestions_ValueChanged(object sender, EventArgs e)
        {
            selectedNormalQuestions[comboBoxChapters.SelectedIndex] = (int)numericUpDownNormalQuestions.Value;
        }

        private void numericUpDownHardQuestions_ValueChanged(object sender, EventArgs e)
        {
            selectedHardQuestions[comboBoxChapters.SelectedIndex] = (int)numericUpDownHardQuestions.Value;
        }

        //κλείνουμε τη φόρμα με ασφαλή τρόπο
        private void button1_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            Close();
        }

        //όταν πατιένται το κουμπί επιλέγουμε τις ερωτήσεις βάσει των κριτηρίων
        private void buttonGenerateWordFile_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (Thema th in Thema.AllQuestions)
            {
                richTextBoxToWord.AppendText((i+1).ToString() + ") " + th.Question + "\n");
                foreach (string answer in th.Answers)
                    richTextBoxToWord.AppendText(answer + "\n");

                richTextBoxToWord.AppendText("\n\n");
                i++;
            }

            richTextBoxToWord.SaveFile("Questions.rtf");
        }

        private void comboBoxChapters_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckNumericUpDownMaxValues();
        }

        private void CheckNumericUpDownMaxValues()
        {
            //θέτουμε για το παρών επιλεγμένο κεφάλαιο, να έχει τις μέγιστες επιλεγμένες ερωτήσεις 
            numericUpDownEasyQuestions.Maximum   = easyQuestions[comboBoxChapters.SelectedIndex];
            numericUpDownNormalQuestions.Maximum = normalQuestions[comboBoxChapters.SelectedIndex];
            numericUpDownHardQuestions.Maximum   = hardQuestions[comboBoxChapters.SelectedIndex];

            //κάθε φορά που αλλάζει το κεφάλαιο θα πρέπει να βλέπουμε τι είχε επιλέξει ο χρήστης και να το θέσουμε ανάλογα.
            numericUpDownEasyQuestions.Value     = selectedEasyQuestions[comboBoxChapters.SelectedIndex];
            numericUpDownNormalQuestions.Value   = selectedNormalQuestions[comboBoxChapters.SelectedIndex];
            numericUpDownHardQuestions.Value     = selectedHardQuestions[comboBoxChapters.SelectedIndex];

            //θα πρέπει να ενημερώσουμε και τα διαθέσιμα θέματα ανά κεφάλαιο
            int totalChapterQuestions = easyQuestions[comboBoxChapters.SelectedIndex] + normalQuestions[comboBoxChapters.SelectedIndex] + hardQuestions[comboBoxChapters.SelectedIndex];
            labelChapterDesc.Text = (totalChapterQuestions == 1) ? "Ένα θέμα από αυτό το κεφάλαιο" : totalChapterQuestions.ToString() + " θέματα από αυτό το κεφάλαιο";
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //θέτουμε τον μέγιστο αριθμό απαντήσεων ανά ερώτηση να είναι ο πρώτος, ώστε να κάνουμε απλή εύρεση μεγίστου
            maxAvailableAnswers = Thema.AllQuestions[0].Answers.Count;

            //βάζουμε τα κεφάλαια στο comboBox
            foreach (Thema th in Thema.AllQuestions)
            {
                if (!comboBoxChapters.Items.Contains(th.Chapter))
                    comboBoxChapters.Items.Add(th.Chapter);

                if (th.Answers.Count > maxAvailableAnswers)
                    maxAvailableAnswers = th.Answers.Count;
            }

            //δεν μπορώ να σκεφτώ καλύτερο τρόπο ΓΤΣΜ
            //βάζουμε για κάθε κεφάλαιο, πόσες ερωτήσεις υπάρχουν από κάθε δυσκολία
            foreach (string ch in comboBoxChapters.Items)
            {
                int easyQCounter = 0, normalQCounter = 0, hardQCounter = 0;
                foreach (Thema th in Thema.AllQuestions)
                {
                    if (th.Difficulty == 1 && th.Chapter.Equals(ch))
                        easyQCounter++;
                    else if (th.Difficulty == 2 && th.Chapter.Equals(ch))
                        normalQCounter++;
                    else if (th.Difficulty == 3 && th.Chapter.Equals(ch))
                        hardQCounter++;
                }

                easyQuestions.Add(easyQCounter);
                normalQuestions.Add(normalQCounter);
                hardQuestions.Add(hardQCounter);
            }

            //μέγιστος αριθμός απαντήσεων ανά ερώτηση
            numericUpDownMaxAnswers.Maximum = maxAvailableAnswers;
            numericUpDownMaxAnswers.Value   = numericUpDownMaxAnswers.Maximum;

            //όλες οι ερωτήσεις ανά δυσκολία
            totalEasyQuestions   = easyQuestions.Sum();
            totalNormalQuestions = normalQuestions.Sum();
            totalHardQuestions   = hardQuestions.Sum();

            //όλες οι ερωτήσεις
            totalQuestions = totalEasyQuestions + totalNormalQuestions + totalHardQuestions;

            //οι επιλεγμένες ερωτήσεις
            selectedEasyQuestions   = new int[easyQuestions.Count];
            selectedNormalQuestions = new int[normalQuestions.Count];
            selectedHardQuestions   = new int[hardQuestions.Count];

            //γεμίζουμε τους πίνακες με μηδενικά
            for (int i = 0; i < selectedEasyQuestions.Length; i++)
                selectedEasyQuestions[i] = 0;

            for (int i = 0; i < selectedNormalQuestions.Length; i++)
                selectedNormalQuestions[i] = 0;

            for (int i = 0; i < selectedHardQuestions.Length; i++)
                selectedHardQuestions[i] = 0;

            //το θέτουμε ως μηδέν για να μην υπάρχει περίπτωση να υπάρχει κενό επιλεγμένο κεφάλαιο.
            comboBoxChapters.SelectedIndex = 0;
        }
    }
}
