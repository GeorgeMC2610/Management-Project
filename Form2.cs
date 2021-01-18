using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_Project
{
    public partial class Form2 : Form
    {
        //global variable for question index.
        int index = 0;
        List<Thema> DummyThemaList = new List<Thema>();

        public Form2(bool SelectMode)
        {
            InitializeComponent();
            buttonSelectQuestion.Visible = buttonGenerateWord.Visible = comboBoxSorting.Visible = SelectMode;
            buttonSelectQuestion.Enabled = buttonGenerateWord.Enabled = comboBoxSorting.Enabled = SelectMode;

            buttonEditQuestion.Visible = buttonDeleteQuestion.Visible = !SelectMode;
            buttonEditQuestion.Enabled = buttonDeleteQuestion.Enabled = !SelectMode;

            this.BackColor = (SelectMode) ? SystemColors.GradientInactiveCaption : SystemColors.Menu;
            labelRightAnswer.BackColor = (SelectMode) ? Color.LimeGreen : Color.LightGreen;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DummyThemaList.AddRange(Thema.AllQuestions);
            comboBoxSorting.SelectedIndex = 0;
            updateQuestions();
            updateButtons();
        }

        private void AnyButtonClicked(object sender, EventArgs e)
        {
            Button buttonClicked = (Button)sender;


            switch (buttonClicked.Name)
            {
                case "buttonExit":
                    Thema.SaveQuestions();
                    new Form1().Show();
                    Close();
                    break;

                case "buttonPrev":
                    index = (index == 0) ? DummyThemaList.Count - 1 : index - 1;
                    updateButtons();
                    updateQuestions();
                    break;

                case "buttonNext":
                    index = (index == DummyThemaList.Count - 1) ? 0 : index + 1;
                    updateButtons();
                    updateQuestions();
                    break;

                case "buttonEditQuestion":
                    break;

                case "buttonDeleteQuestion":
                    if (MessageBox.Show("Αν διαγραφεί το θέμα από την τράπεζα, δεν υπάρχει τρόπος επαναφοράς. Έχετε σιγουρευτεί για αυτήν την ενέργεια;", "Διαγραφή Θέματος", MessageBoxButtons.YesNo) == DialogResult.No)
                        return;

                    DummyThemaList.RemoveAt(index);
                    index = (index == 0) ? DummyThemaList.Count - 1 : index - 1;
                    updateButtons();
                    updateQuestions();
                    break;

                case "buttonSelectQuestion":
                    break;

                case "buttonGenerateWord":
                    break;
            }
        }

        //to update the questions, I set all the labels to be the corresponding properties
        private void updateQuestions()
        {
            //but if there are no questions available, nothing happens.
            if (DummyThemaList.Count == 0)
            {
                labelQuestion.Text = "Η τράπεζα θεμάτων είναι άδεια.";
                labelChapter.Text = "Πηγαίνετε στο κύριο μενου, πατήστε \"Προσθήκη Θέματος\" κι όταν φτιάξετε το θέμα σας, θα το βρείτε εδώ!";
                labelRightAnswer.Text = labelDifficulty.Text = labelAnswers.Text = "";
                return;
            }

            Thema th = DummyThemaList[index];

            labelQuestion.Text = (index + 1).ToString() + ") " + th.Question;

            string stringGreekNumerals = "α,β,γ,δ,ε,στ,ζ,η,θ,ι,ια,ιβ,ιγ,ιδ,ιε,ιστ,ιζ,ιη,ιθ,κ,κα,κβ,κγ,κδ,κε,κστ,κζ,κη,κθ";
            string[] GreekNumerals = stringGreekNumerals.Split(',');

            int j = 0;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < th.Answers.Count; i++)
            {
                sb.Append(GreekNumerals[j] + ") ");
                sb.Append(th.Answers[i]);
                sb.Append(Environment.NewLine);

                if (j > 27)
                    j = 0;
                else
                    j++;
            }

            labelAnswers.Text = sb.ToString();
            labelRightAnswer.Text = GreekNumerals[th.RightAnswerIndex] + ") " + th.Answers[th.RightAnswerIndex]; //αυτό σημαίνει "η σωστή απάντηση" λμαο.

            labelChapter.Text = "Κεφάλαιο: " + th.Chapter;

            switch (th.Difficulty)
            {
                case 1:
                    labelDifficulty.Text = "Βαθμός δυσκολίας: Εύκολος";
                    break;
                case 2:
                    labelDifficulty.Text = "Βαθμός δυσκολίας: Μέτριος";
                    break;
                case 3:
                    labelDifficulty.Text = "Βαθμός δυσκολίας: Δύσκολος";
                    break;
            }

            CheckLabelSize();
        }

        private void updateButtons()
        {
            if (DummyThemaList.Count == 0)
            {
                buttonPrev.Enabled = buttonNext.Enabled = buttonEditQuestion.Enabled = buttonDeleteQuestion.Enabled = false;
                buttonDeleteQuestion.BackColor = Color.DarkGray;
                buttonDeleteQuestion.ForeColor = Color.Black;
            }
            else if (DummyThemaList.Count == 1)
            {
                buttonPrev.Enabled = buttonNext.Enabled = false;
                buttonEditQuestion.Enabled = buttonDeleteQuestion.Enabled = true;
                buttonDeleteQuestion.BackColor = Color.DarkRed;
                buttonDeleteQuestion.ForeColor = Color.White;
            }
            else
            {
                buttonPrev.Enabled = buttonNext.Enabled = buttonEditQuestion.Enabled = buttonDeleteQuestion.Enabled = true;
                buttonDeleteQuestion.BackColor = Color.DarkRed;
                buttonDeleteQuestion.ForeColor = Color.White;
            }
        }

        private void Form2_Resize(object sender, EventArgs e)
        {
            CheckLabelSize();
        }

        private void CheckLabelSize()
        {
            Font f;
            var analogy = labelQuestion.Size.Width / this.Width;

            f = new Font("Arial", 16f);
            labelQuestion.Font = f;


            if (analogy > 0.60 && analogy < 0.75)
            {
                f = new Font("Arial", 13f);
                labelQuestion.Font = f;
            }

            else if (analogy > 0.75 && analogy < 0.90)
            {
                f = new Font("Arial", 10f);
                labelQuestion.Font = f;
            }

            else if (analogy > 0.90)
            {
                f = new Font("Arial", 8f);
                labelQuestion.Font = f;
            }

        }
    }
}
