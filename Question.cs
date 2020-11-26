using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Project
{
    [Serializable]
    class Thema
    {
        public static List<Thema> AllQuestions = new List<Thema>();

        public string Question { get; set; }
        public List<string> Answers = new List<string>();

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
                difficulty = (value < 1 || value > 4) ? 1 : value;
            }
        }

        private int rightAnswerIndex;
        private int difficulty;

    }
}
