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

        //αλλάζουμε το πόσες ερωτήσεις επιλέγονται, βάσει των numericupdown
        private void numericUpDownEasyQuestions_ValueChanged(object sender, EventArgs e)
        {
            var temp = from th in Thema.EasyQuestions where (th.Chapter.Equals(comboBoxChapters.Text) && !QuestionsToBeIncluded.Contains(th)) select th;
            QuestionsToBeIncluded.Add();
            updateLabelTotalDifficultyQuestions();
            updateLabelOverview();
            checkIfButtonCanBeEnabled();
        }

        private void numericUpDownNormalQuestions_ValueChanged(object sender, EventArgs e)
        {
            selectedNormalQuestions[comboBoxChapters.SelectedIndex] = (int)numericUpDownNormalQuestions.Value;
            updateLabelTotalDifficultyQuestions();
            updateLabelOverview();
            checkIfButtonCanBeEnabled();
        }

        private void numericUpDownHardQuestions_ValueChanged(object sender, EventArgs e)
        {
            selectedHardQuestions[comboBoxChapters.SelectedIndex] = (int)numericUpDownHardQuestions.Value;
            updateLabelTotalDifficultyQuestions();
            updateLabelOverview();
            checkIfButtonCanBeEnabled();
        }

        //λέμε στον χρήστη πόσα θέματα επιλέγονται από κάθε δυσκολία στο κεφάλαιο.
        private void updateLabelTotalDifficultyQuestions()
        {
            //τα προσθέτουμε όλα μαζί και ύστερα τα εμφανίζουμε ανάλογα στον χρήστη
            int totalDifficultyQuestions = selectedEasyQuestions[comboBoxChapters.SelectedIndex] + selectedNormalQuestions[comboBoxChapters.SelectedIndex] + selectedHardQuestions[comboBoxChapters.SelectedIndex];
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
            selectedQuestions = selectedEasyQuestions.Sum() + selectedNormalQuestions.Sum() + selectedHardQuestions.Sum();

            //ύστερα βλέπουμε πόσα είναι τα κεφάλαια
            for (int i = 0; i < selectedEasyQuestions.Length; i++)
            {
                if (selectedEasyQuestions[i] + selectedNormalQuestions[i] + selectedHardQuestions[i] != 0)
                    selectedChapters++;
            }

            //και μετά κάνουμε πράγματα με το label
            switch (selectedQuestions)
            {
                default:
                    labelOverview.Text = "Θα παραχθούν συνολικά " + selectedQuestions.ToString() + " ερωτήσεις από ";
                    labelOverview.Text += (selectedChapters == 1)? "ένα κεφάλαιο" : selectedChapters.ToString() + " κεφάλαια";
                    break;
                case 0:
                    labelOverview.Text = "Δεν θα παραχθεί καμμία ερώτηση.";
                    break;
                case 1:
                    labelOverview.Text = "Θα παραχθεί μία ερώτηση από ένα κεφάλαιο";
                    break;
            }

            float percentage = (float) selectedQuestions * 100 / (float) Thema.AllQuestions.Count;
            labelOverview.Text += " (" + percentage.ToString() + "%)";
        }

        //φτάνουμε σε αυτό το σημείο κάθε φορά που μπορούμε να πάμε να παράξουμε το αρχείο
        private void checkIfButtonCanBeEnabled()
        {
            //απενεργοποιούμε το κουμπί αν δεν υπάρχουν ερωτήσεις για παραγωγή
            if (selectedQuestions == 0)
            {
                buttonGenerateWordFile.Enabled   = false;
                buttonGenerateWordFile.BackColor = Color.DarkGray;
                buttonGenerateWordFile.ForeColor = Color.Black;
            }
            //αν οι ερωτήσεις είναι λίγες, θα πρέπει να βάλουμε ξεχωριστό χρώμα
            else if (selectedQuestions < (int) Math.Round((float)Thema.AllQuestions.Count * 0.15))
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

        //OVERLOADS για να ανακατέψουμε λίστες.
        private List<T> randomizeList<T> (List<T> list)
        {
            Random random = new Random();

            //ξεκινώντας από το δεύτερο στοιχείο, αρχίζουμε και ανακατεύουμε τη λίστα
            for (int i = 1; i < list.Count; i++)
            {
                int rng = random.Next(2);
                if (rng == 1)
                {
                    T temp = list[0];
                    list[0] = list[i];
                    list[i] = temp;
                }
            }

            return list;
        }

        private T[] randomizeList<T> (T[] array)
        {
            Random random = new Random();

            //ξεκινώντας από το δεύτερο στοιχείο, αρχίζουμε και ανακατεύουμε τον πίνακα
            for (int i = 1; i < array.Length; i++)
            {
                int rng = random.Next(2);
                if (rng == 1)
                {
                    T temp = array[0];
                    array[0] = array[i];
                    array[i] = temp;
                }
            }

            return array;
        }

        private void numericUpDownMaxAnswers_ValueChanged(object sender, EventArgs e)
        {

        }

        private List<T> randomChoice<T> (List<T> list, int choices)
        {
            Random random = new Random();

            //αν οι επιλογές είναι οι ίδιες με την ίδια τη λίστα, τότε, του επιστρέφουμε την ίδια τη λίστα, απλά ανακτεμμένη;
            if (choices == list.Count)
                return randomizeList(list);

            list = randomizeList(list);
            int times = list.Count - choices;
            list.RemoveRange(0, times);

            return list;
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

        private void printArray<T>(T[] array)
        {
            if (array.Length == 1)
            {
                Console.WriteLine("[" + array[0] + "]");
                return;
            }

            StringBuilder sb = new StringBuilder();

            sb.Append("[");
            for (int i = 0; i < array.Length - 1; i++)
                sb.Append(array[i] + ", ");

            sb.Append(array[array.Length - 1] + "]");
            Console.WriteLine(sb.ToString());
        }

        //όταν πατιένται το κουμπί επιλέγουμε τις ερωτήσεις βάσει των κριτηρίων
        private void buttonGenerateWordFile_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            richTextBoxToWord.Text = "";
            
            int i = 0;
            foreach (string ch in comboBoxChapters.Items)
            {
                //Για κάθε δυσκολία τραβάμε όσες ερωτήσεις μας έχει πει ο χρήστης.
                //ΠΡΩΤΑ τραβάμε ΟΛΕΣ τις ερωτήσεις από κάθε δυσκολία σε 3 ξεχωριστές λίστες, και με την randomChoice κρατάμε μόνον όσες θέλουμε εμείς.
                List<Thema> EasyQuestionsToBeIncluded = new List<Thema>();

                foreach (Thema th in Thema.AllQuestions)
                {
                    if (th.Difficulty == 1 && th.Chapter.Equals(ch))
                        EasyQuestionsToBeIncluded.Add(th);
                }

                //Αν ΔΕΝ έχουμε μαζέψει όσες εύκολες ερωτήσεις έχει πει ο χρήστης, κόβουμε όσες έχει πει ο χρήστης
                if (selectedEasyQuestions[i] < EasyQuestionsToBeIncluded.Count)
                    EasyQuestionsToBeIncluded = randomChoice(EasyQuestionsToBeIncluded, selectedEasyQuestions[i]);

                List<Thema> NormalQuestionsToBeIncluded = new List<Thema>();

                foreach (Thema th in Thema.AllQuestions)
                {
                    if (th.Difficulty == 2 && th.Chapter.Equals(ch))
                        NormalQuestionsToBeIncluded.Add(th);
                }

                //Αν ΔΕΝ έχουμε μαζέψει όσες μέτριες ερωτήσεις έχει πει ο χρήστης, κόβουμε όσες έχει πει ο χρήστης
                if (selectedNormalQuestions[i] < NormalQuestionsToBeIncluded.Count)
                    NormalQuestionsToBeIncluded = randomChoice(NormalQuestionsToBeIncluded, selectedNormalQuestions[i]);

                List<Thema> HardQuestionsToBeIncluded = new List<Thema>();

                foreach (Thema th in Thema.AllQuestions)
                {
                    if (th.Difficulty == 3 && th.Chapter.Equals(ch))
                        HardQuestionsToBeIncluded.Add(th);
                }

                //Αν ΔΕΝ έχουμε μαζέψει όσες δύσκολες ερωτήσεις έχει πει ο χρήστης, κόβουμε όσες έχει πει ο χρήστης
                if (selectedHardQuestions[i] < HardQuestionsToBeIncluded.Count)
                    HardQuestionsToBeIncluded = randomChoice(HardQuestionsToBeIncluded, selectedHardQuestions[i]);

                QuestionsToBeIncluded.AddRange(EasyQuestionsToBeIncluded);
                QuestionsToBeIncluded.AddRange(NormalQuestionsToBeIncluded);
                QuestionsToBeIncluded.AddRange(HardQuestionsToBeIncluded);

                i++;
            }

            //Ελέγχουμε αν οι απαντήσεις είναι ακριβώς έτσι όπως θέλουμε
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
                        th.Answers = randomChoice(th.Answers, (int)numericUpDownMaxAnswers.Value);

                        //αν δεν βρεις την σωστή απάντηση μέσα στη λίστα, βάλ' την
                        if (!th.Answers.Contains(rightAnswer))
                            th.Answers[random.Next(th.Answers.Count)] = rightAnswer;
                    }
                    //αν δεν πρέπει να 'χουμε ανακατεμμένες απαντήσεις
                    else
                    {
                        //κράτα την σωστή απάντηση και μετά κόψε τις υπόλοιπες
                        string rightAnswer = th.Answers[th.RightAnswerIndex];

                        int count = th.Answers.Count - (int) numericUpDownMaxAnswers.Value;
                        for (i = 0; i < count; i++)
                            th.Answers.RemoveAt(th.Answers.Count - 1);

                        //αν η απάντηση βρισκόταν σε μεγαλύτερη θέση από τις απαντήσεις που κόψαμε, τη βάζουμε ως τελευταία.
                        th.Answers[th.Answers.Count - 1] = (th.RightAnswerIndex + 1 > numericUpDownMaxAnswers.Value) ? rightAnswer : th.Answers[th.Answers.Count - 1];
                    }
                }
                //αλλιώς ανάκατεψε τις απαντήσεις αν πρέπει. Αν δεν πρέπει, σημαίνει ότι τις αφήνουμε όπως είναι.
                else
                {
                    if (checkBoxRandomizedAnswers.Checked)
                        th.Answers = randomizeList(th.Answers);
                } 
            }

            switch (comboBoxSorting.SelectedIndex)
            {
                //στην περίπτωση που ο χρήστης έχει επιλέξει κανονική κατάταξη, δεν κάνουμε τίποτα. Τα θέματα είναι ήδη σε σειρά προσθήκης
                case 0:
                    break;
                //χρησιμοποιούμε Linq για την ταξινόμηση ανά attribute ερώτησης
                case 1:
                    QuestionsToBeIncluded = QuestionsToBeIncluded.OrderBy(th => th.Question).ToList();
                    break;
                //χρησιμοποιούμε Linq για την ταξινόμηση ανά attribute κεφαλαίου
                case 2:
                    QuestionsToBeIncluded = QuestionsToBeIncluded.OrderBy(th => th.Chapter).ToList();
                    break;
                case 3:
                    QuestionsToBeIncluded = QuestionsToBeIncluded.OrderBy(ch => comboBoxChapters.SelectedItem).ToList();
                    break;
                //χρησιμοποιούμε Linq για την ταξινόμηση ανά attribute δυσκολίας
                case 4:
                    QuestionsToBeIncluded = QuestionsToBeIncluded.OrderBy(th => th.Difficulty).ToList();
                    break;
                //χρησιμοποιούμε την φτιαχτή randomizeList για να παραχθεί μία τυχαία λίστα.
                case 5:
                    QuestionsToBeIncluded = randomizeList(QuestionsToBeIncluded);
                    break;
            }

            if (checkBoxReverse.Checked)
                QuestionsToBeIncluded.Reverse();

            i = 0;
            foreach (Thema th in QuestionsToBeIncluded)
            {
                richTextBoxToWord.AppendText((i+1).ToString() +  ") " + th.Question + Environment.NewLine);

                int j = 0;
                string stringGreekNumerals = "α,β,γ,δ,ε,στ,ζ,η,θ,ι,ια,ιβ,ιγ,ιδ,ιε,ιστ,ιζ,ιη,ιθ,κ,κα,κβ,κγ,κδ,κε,κστ,κζ,κη,κθ";
                string[] GreekNumerals = stringGreekNumerals.Split(',');
                foreach (string answer in th.Answers)
                {
                    richTextBoxToWord.AppendText(GreekNumerals[j] + ". " + answer + Environment.NewLine);
                    j++;
                }

                richTextBoxToWord.AppendText(Environment.NewLine);
                i++;
            }

            richTextBoxToWord.SaveFile(saveFileDialog1.FileName);
        }

        private void comboBoxChapters_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedChapter = comboBoxChapters.Text;
            CheckNumericUpDownMaxValues();
            updateLabelOverview();
            checkIfButtonCanBeEnabled();
        }

        private void CheckNumericUpDownMaxValues()
        {
            //θέτουμε για το παρών επιλεγμένο κεφάλαιο, να έχει τις μέγιστες επιλεγμένες ερωτήσεις 
            numericUpDownEasyQuestions.Maximum   = 
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
            numericUpDownMaxAnswers.Maximum = Thema.mostAnswers;

            //βάζουμε τα κεφάλαια στο comboBox
            comboBoxChapters.Items.AddRange(Thema.Chapters.ToArray());
            comboBoxChapters.SelectedIndex = comboBoxSorting.SelectedIndex = 0;

            //βάζουμε για κάθε κεφάλαιο, πόσες ερωτήσεις υπάρχουν από κάθε δυσκολία
            foreach (string ch in comboBoxChapters.Items)
            {
                var tempEasyQuestions = from th in Thema.AllQuestions where th.Difficulty == 1 && th.Chapter.Equals(ch) select th.Difficulty;
                easyQuestions.AddRange(tempEasyQuestions);

                var tempNormalQuestions = from th in Thema.AllQuestions where th.Difficulty == 2 && th.Chapter.Equals(ch) select th.Difficulty;
                normalQuestions.AddRange(tempNormalQuestions);

                var tempHardQuestions = from th in Thema.AllQuestions where th.Difficulty == 3 && th.Chapter.Equals(ch) select th.Difficulty;
                hardQuestions.AddRange(tempHardQuestions);
            }

            //μέγιστος αριθμός απαντήσεων ανά ερώτηση

            //όλες οι ερωτήσεις ανά δυσκολία


            //όλες οι ερωτήσεις


            //οι επιλεγμένες ερωτήσεις


            //γεμίζουμε τους πίνακες με μηδενικά
            MaxAndSelectedChapters = new int[comboBoxChapters.Items.Count, 2];




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
