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
            Thema.AcquireQuestions();
            checkButton();
            labelAvailableQuestions.Text = Thema.AllQuestions.Count.ToString() + ((Thema.AllQuestions.Count == 1) ? " Διαθέσιμο Θέμα" : " Διαθέσιμα Θέματα");
        }

        private void checkButton()
        {
            if (Thema.AllQuestions.Count == 0)
            {
                wordFileButton.Enabled = false;
                wordFileButton.BackColor = Color.Gray;
                wordFileButton.ForeColor = Color.Black;
            }
            else
            {
                wordFileButton.Enabled = true;
                wordFileButton.BackColor = SystemColors.HotTrack;
                wordFileButton.ForeColor = Color.White;
            }
        }

        private void editQuestionsButton_Click(object sender, EventArgs e)
        {
            Hide();
            new Form2().Show();
        }

        private void deleteAllQuestionsButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Έχετε σιγουρευτεί ότι θέλετε να σβήσετε ΟΛΑ τα θέματα από την τράπεζα; (" + Thema.AllQuestions.Count.ToString() + ((Thema.AllQuestions.Count == 1)? " θέμα)" : " θέματα)") + ".\n\n Δεν υπάρχει τρόπος για την επαναφορά τους, αν σβησθούν.", "ΣΒΗΣΙΜΟ ΟΛΩΝ ΤΩΝ ΘΕΜΑΤΩΝ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Thema.AllQuestions.Clear();
            }
                
            labelAvailableQuestions.Text = Thema.AllQuestions.Count.ToString() + ((Thema.AllQuestions.Count == 1) ? " Διαθέσιμο Θέμα" : " Διαθέσιμα Θέματα");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FormAddQuestion().Show();
            Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Thema.SaveQuestions();
        }

        private void wordFileButton_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();

            Hide(); 
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem1_Δημιουργοί_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Το project αυτό δημιουργήθηκε από τους φοιτητές του ΠΑΠΕΙ Γιώργο Σεϊμένη και Λευτέρη Λαμπράκο για το μάθημα επιλογής του 3ου εξαμήνου «Management» (2020-2021)", "Δημιουργοί");
        }

        private void toolStripMenuItem2_Σκοπός_Click(object sender, EventArgs e)
        {
            MessageBox.Show("κείμενο εντός του message box", "Σκοπός");
        }

        private void toolStripMenuItem2_prosthikh_neou_thematos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Δεξιά της οθόνης σας κάτω απο την φράση «Επεξεργασία τράπεζας» θα βρείτε ένα ΠΡΑΣΙΝΟ κουμπί,ονόματι ΠΡΟΣΘΗΚΗ ΝΕΟΥ ΘΕΜΑΤΟΣ. Πατώντας αυτό το κουμπί θα μπορείτε να ξεκινήσετε τη δημιουργία και την επεξεργασία ενός νέου θέματος! Μπορείτε να επιλέξετε: \n\n Ερώτηση \n Κεφάλαιο \n Βαθμό δυσκολίας \n Αριθμό πιθανών απαντήσεων \n\n Στο τέλος μπορείτε να επιλέξετε ΕΠΙΣΚΟΠΗΣΗ ΘΕΜΑΤΟΣ για να δείτε τη τελική μορφή της ερώτησης ή ΠΡΟΣΘΗΚΗ ΕΡΩΤΗΣΗΣ ΣΤΗΝ ΤΡΑΠΕΖΑ εφόσον αποφασίσετε ότι η ερώτηση σας είναι έτοιμη να μπει στη τράπεζα θεμάτων.Πάντα θα έχετε τη δυνατότητα προβολής,επεξεργασίας και διαγραγής κάποιου υπαρκτού θέματος,οπότε μην αγχώνεστε αν κάποια ερώτηση είναι λάθος καθώς θα μπορείτε να την αλλάξετε! \n\n Αν θέλετε να επιστρέψετε στην αρχική διαγάνεια πατήστε πάνω δεξιά το κουμπί «Επιστρογή στο Μενού»", "Προσθήκη Νέου Θέματος");
        }
    }
}
