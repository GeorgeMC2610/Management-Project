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

        List<string> Chapters = new List<string>();
        int chapterIndex      = 0;
        List<int> easyQuestions     = new List<int>();
        List<int> normalQuestions   = new List<int>();
        List<int> hardQuestions     = new List<int>();

        private void Form4_Load(object sender, EventArgs e)
        {
            foreach (Thema th in Thema.AllQuestions)
            {
                //γεμίζουμε τα κεφάλαια ώστε να υπάρχουν στο textbox
                if (!Chapters.Contains(th.Chapter))
                    Chapters.Add(th.Chapter);
            }
            textBoxChapterSelect.Text = Chapters[chapterIndex];

            
        }
    }
}
