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
            //βάζουμε σε τάξη τις δυσκολίες ερωτήσεων
            EasyQuestions   = (from th in AllQuestions where th.Difficulty == 1 select th).ToList();
            NormalQuestions = (from th in AllQuestions where th.Difficulty == 2 select th).ToList();
            HardQuestions   = (from th in AllQuestions where th.Difficulty == 3 select th).ToList();

            //βάζουμε σε τάξη τα κεφάλαια
            Chapters = (from th in AllQuestions where !(Chapters.Contains(th.Chapter)) select Chapter).ToList();

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
            catch (FileNotFoundException e1)
            {
                MessageBox.Show("Μήνυμα σφάλματος: " + e1.Message + "\n\nΤο αρχείο με τις ερωτήσεις (Questions.ser) δεν βρέθηκε. Θέλετε να τρέξετε την εφαρμογή, ώστε να φτιάξει από μόνη της νέο αρχείο;", "Αρχείο Ερωτήσεων", MessageBoxButtons.OKCancel);
            }
            catch (SerializationException)
            {
                //do nothing.
            }
        }
    }
}
