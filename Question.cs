using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Project
{
    class Question
    {
        private int difficulty;
        private int rightanswer;

        public Question(string Ques, string Ans1, string Ans2, string Ans3, string Ans4, int RightAnswer, int Difficulty)
        {
            this.Ques = Ques;
            this.Ans1 = Ans1;
            this.Ans2 = Ans2;
            this.Ans3 = Ans3;
            this.Ans4 = Ans4;
            this.rightanswer = RightAnswer;
            this.difficulty = Difficulty;
        }

        public int Difficulty 
        {
            get
            {
                return difficulty;
            }

            set
            {
                difficulty = (value > 4 || value < 0) ? 1 : value;
            }
        }

        public int RightAnswer 
        { 
            get
            {
                return rightanswer;
            }
            
            set
            {
                rightanswer = (value > 0 && value < 5) ? value : 1;
            }
        }

        public string Ques { get; set; }
        public string Ans1 { get; set; }
        public string Ans2 { get; set; }
        public string Ans3 { get; set; }
        public string Ans4 { get; set; }
    }
}
