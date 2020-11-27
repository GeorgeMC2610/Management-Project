using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Management_Project
{
    [Serializable]
    class Thema
    {
        public static List<Thema> AllQuestions = new List<Thema>();

        public Thema(int difficulty, int rightAnswerIndex, string Question, string Chapter, params string[] Answers)
        {
            this.difficulty       = difficulty;
            this.rightAnswerIndex = rightAnswerIndex;
            this.Question         = Question;
            this.Chapter          = Chapter;

            foreach (string Answer in Answers)
                this.Answers.Add(Answer);

            AllQuestions.Add(this);
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

        //STARTING OF STATIC METHODS
        public static void SaveQuestions()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream     stream    = new FileStream("Questions.ser", FileMode.OpenOrCreate, FileAccess.Write);

            formatter.Serialize(stream, AllQuestions);
            stream.Close();
        }

        public static void AcquireQuestions()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream     stream    = new FileStream("Questions.ser", FileMode.Open, FileAccess.Read);

            AllQuestions = (List<Thema>)formatter.Deserialize(stream);
        }
    }
}
