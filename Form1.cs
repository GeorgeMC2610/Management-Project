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
    public partial class Form1 : Form
    {
        public Form1() 
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) 
        {
            Console.WriteLine(Thema.AllQuestions.Count);
            Thema th1 = new Thema(3, 3, "Πόσες φορές την ημέρα πρέπει να προσεύχονται οι Μουσουλμάνοι;", "---", "Μία", "Δύο", "Πέντε", "Επτά");
            Thema th2 = new Thema(2, 4, "Με πόσα κουμπιά χρειάζεται να φτιαχτεί η ερώτηση;", "---", "Δύο", "Τέσσερα", "Πέντε", "Όσα θέλει ο Χρήστης");
        }

        private void editQuestionsButton_Click(object sender, EventArgs e)
        {
            Hide();
            new Form2().Show();
        }

        private void deleteAllQuestionsButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Έχετε σιγουρευτεί ότι θέλετε να σβήσετε ΟΛΑ τα θέματα από την τράπεζα; (" + Thema.AllQuestions.Count.ToString() + " θέματα).\n\n Δεν υπάρχει τρόπος για την επαναφορά τους, αν σβησθούν.", "ΣΒΗΣΙΜΟ ΟΛΩΝ ΤΩΝ ΘΕΜΑΤΩΝ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Thema.AllQuestions.Clear();
        }
    }
}
