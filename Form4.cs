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

        List<int> easyQuestions     = new List<int>();
        List<int> normalQuestions   = new List<int>();
        List<int> hardQuestions     = new List<int>();
        int index, totalEasyQuestions, totalNormalQuestions, totalHardQuestions, totalQuestions, maxAvailableAnswers;

        private void Form4_Load(object sender, EventArgs e)
        {
            //εφ' όσον δεν έχουμε επιλέξει κάποιο κεφάλαιο, βάζουμε το index -1, ώστε να ξέρουμε ότι ακόμη δεν έχει επιλεγεί
            index = -1;

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

            //όλες οι ερωτήσεις ανά δυσκολία
            totalEasyQuestions   = easyQuestions.Sum();
            totalNormalQuestions = normalQuestions.Sum();
            totalHardQuestions   = hardQuestions.Sum();

            //όλες οι ερωτήσεις
            totalQuestions = totalEasyQuestions + totalNormalQuestions + totalHardQuestions;
        }
    }
}
