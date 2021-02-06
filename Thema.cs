using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_Project
{
    [Serializable]
    class Thema
    {
        public static List<Thema> AllQuestions    = new List<Thema>();
        public static List<Thema> EasyQuestions   = new List<Thema>();
        public static List<Thema> NormalQuestions = new List<Thema>();
        public static List<Thema> HardQuestions   = new List<Thema>();
        public static List<string> Chapters       = new List<string>();
        public static List<List<Thema>> QuestionsByChapter = new List<List<Thema>>();
        public static int mostAnswers;

        public Thema(int difficulty, int rightAnswerIndex, string Question, string Chapter, params string[] Answers)
        {
            this.difficulty       = difficulty;
            this.rightAnswerIndex = rightAnswerIndex;
            this.Question         = Question;
            this.Chapter          = Chapter;

            foreach (string Answer in Answers)
                this.Answers.Add(Answer);

            AllQuestions.Add(this);
            RearrangeThemata();
        }

        public static void RearrangeThemata()
        {
            EasyQuestions.Clear();
            NormalQuestions.Clear();
            HardQuestions.Clear();
            Chapters.Clear();
            QuestionsByChapter.Clear();

            //βάζουμε σε τάξη τις δυσκολίες ερωτήσεων
            EasyQuestions   = (from th in AllQuestions where th.Difficulty == 1 select th).ToList();
            NormalQuestions = (from th in AllQuestions where th.Difficulty == 2 select th).ToList();
            HardQuestions   = (from th in AllQuestions where th.Difficulty == 3 select th).ToList();

            //βάζουμε σε τάξη τα κεφάλαια
            foreach (Thema th in AllQuestions)
                if (!Chapters.Contains(th.Chapter))
                    Chapters.Add(th.Chapter);

            //βάζουμε λίστες με ερωτήσεις ανά κεφάλαιο
            foreach (string ch in Chapters)
            {
                var tempList = (from th in AllQuestions where th.Chapter.Equals(ch) select th).ToList();
                QuestionsByChapter.Add(tempList);
            }

            //και έχουμε ως γνωστό τον μέγιστο αριθμό απαντήσεων σε μία ερώτηση
            mostAnswers = 0;
            foreach (Thema th in AllQuestions)
                if (mostAnswers < th.Answers.Count)
                    mostAnswers = th.Answers.Count;
        }

        public string Question { get; set; }
        public string Chapter  { get; set; }
        public List<string> Answers = new List<string>();
        private int rightAnswerIndex;
        private int difficulty;

        public int RightAnswerIndex
        {
            get
            {
                return rightAnswerIndex;
            }
            set
            {
                rightAnswerIndex = (value < 0 || value > Answers.Count) ? 1 : value;    
            }
        }

        public int Difficulty
        {
            get
            {
                return difficulty;
            }
            set
            {
                difficulty = (value < 1 || value > 3) ? 1 : value;
            }
        }

        //START OF STATIC METHODS
        public static void SaveQuestions()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream     stream    = new FileStream("Questions.ser", FileMode.OpenOrCreate, FileAccess.Write);

            formatter.Serialize(stream, AllQuestions);
            stream.Close();
        }

        public static void AcquireQuestions()
        {
            try
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream("Questions.ser", FileMode.Open, FileAccess.Read);

                AllQuestions = (List<Thema>)formatter.Deserialize(stream);
                stream.Close();

                RearrangeThemata();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("ΠΡΟΣΟΧΗ: Δεν βρέθηκε το αρχείο με τις ερωτήσεις (Questions.ser). Θα παραχθεί αυτόματα καινούργιο.", "Αρχείο Ερωτήσεων", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SerializationException e2)
            {
                MessageBox.Show("Κάτι πήγε στραβά, κατά την ανάκτηση των Θεμάτων της βάσης. Προσπαθήστε ξανά, κατά προτίμηση με άλλο αρχείο.\n\nΜήνυμα σφάλματος: " + e2.Message, "Σφάλμα", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
