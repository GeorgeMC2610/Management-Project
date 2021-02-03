using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
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
            new Form2(false).Show();
        }

        private void deleteAllQuestionsButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Έχετε σιγουρευτεί ότι θέλετε να σβήσετε ΟΛΑ τα θέματα από την τράπεζα; (" + Thema.AllQuestions.Count.ToString() + ((Thema.AllQuestions.Count == 1)? " θέμα)" : " θέματα)") + ".\n\n Δεν υπάρχει τρόπος για την επαναφορά τους, αν σβησθούν.", "ΣΒΗΣΙΜΟ ΟΛΩΝ ΤΩΝ ΘΕΜΑΤΩΝ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Thema.AllQuestions.Clear();
            }
                
            labelAvailableQuestions.Text = Thema.AllQuestions.Count.ToString() + ((Thema.AllQuestions.Count == 1) ? " Διαθέσιμο Θέμα" : " Διαθέσιμα Θέματα");
            checkButton();
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
            for (int i = 0; i < Application.OpenForms.Count; i++)
                Application.OpenForms[i].Close();
        }

        private void wordFileButton_Click(object sender, EventArgs e)
        {
            DialogResult input = MessageBox.Show("Θα θέλατε να γίνει χειροκίνητη επιλογή θεμάτων από την τράπεζα;", "Χειρισμός Παραγωγής Αρχείου", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            switch(input)
            {
                case DialogResult.Yes:
                    Form2 form2 = new Form2(true);
                    form2.Show();
                    Hide();
                    break;
                case DialogResult.No:
                    Form4 form4 = new Form4();
                    form4.Show();
                    Hide();
                    break;
                default:
                    break;
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void toolStripMenuItem1_Δημιουργοί_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Το project αυτό δημιουργήθηκε από τους φοιτητές του ΠΑΠΕΙ Γιώργο Σεϊμένη και Λευτέρη " +
                "Λαμπράκο για το μάθημα επιλογής του 3ου εξαμήνου «Management» (2020-2021)", "Δημιουργοί");
        }

        private void toolStripMenuItem2_Σκοπός_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Γιώργος Σεϊμένης: giorgosseimenis@gmail.com\nΛευτέρης Λαμπράκος: lefterislamprakos36@gmail.com", "Επικοινωνία Με Τους Δημιουργούς");
        }

        private void toolStripMenuItem2_prosthikh_neou_thematos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Δεξιά της οθόνης σας κάτω από την φράση «Επεξεργασία τράπεζας» θα βρείτε ένα ΠΡΑΣΙΝΟ " +
                "κουμπί,ονόματι ΠΡΟΣΘΗΚΗ ΝΕΟΥ ΘΕΜΑΤΟΣ. Πατώντας αυτό το κουμπί θα μπορείτε να ξεκινήσετε τη" +
                " δημιουργία και την επεξεργασία ενός νέου θέματος! Μπορείτε να επιλέξετε: \n\n Ερώτηση" +
                " \n Κεφάλαιο \n Βαθμό δυσκολίας \n Αριθμό πιθανών απαντήσεων \n\nΣτο τέλος μπορείτε να επιλέξετε" +
                " ΕΠΙΣΚΟΠΗΣΗ ΘΕΜΑΤΟΣ για να δείτε τη τελική μορφή της ερώτησης ή ΠΡΟΣΘΗΚΗ ΕΡΩΤΗΣΗΣ ΣΤΗΝ ΤΡΑΠΕΖΑ" +
                " εφόσον αποφασίσετε ότι η ερώτηση σας είναι έτοιμη να μπει στη τράπεζα θεμάτων.Πάντα θα έχετε" +
                " τη δυνατότητα προβολής και διαγραφής κάποιου υπαρκτού θέματος,οπότε μην αγχώνεστε αν κάποια" +
                " ερώτηση είναι λάθος καθώς θα μπορείτε να την αλλάξετε! \n\nΑν θέλετε να επιστρέψετε στην αρχική" +
                " διαφάνεια πατήστε πάνω δεξιά το κουμπί «Επιστρογή στο Μενού»", "Προσθήκη Νέου Θέματος");
        }

        private void toolStripMenuItem3_diagrafh_olwn_twn_thematwn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Δεξιά της οθόνης σας βρίσκεται ένα ΚΟΚΚΙΝΟ κουμπί ονόματι ΔΙΑΓΡΑΦΗ ΟΛΩΝ ΤΩΝ ΘΕΜΑΤΩΝ." +
                " Το κουμπί αυτό διαγράφει ΟΛΑ τα θέματα που έχουν δημιουργηθεί. \n\nΤα θέματα που θα διαγραφούν" +
                " ΔΕΝ γίνεται να ανακτηθούν εφόσον έχουν διαγραφτεί.", "ΔΙΑΓΡΑΦΗ ΟΛΩΝ ΤΩΝ ΘΕΜΑΤΩΝ");
        }

        private void toolStripMenuItem4_episkophsh_thematwn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Δεξιά της οθόνης σας βρίσκεται ένα ΓΚΡΙ κουμπί ονόματι ΕΠΙΣΚΟΠΗΣΗ ΘΕΜΑΤΩΝ.\n\nΤο" +
                " κουμπί αυτό θα σας εμφανίσει τις ερωτήσεις και τις πιθανές απαντήσεις των θεμάτων,η σωστή" +
                " ερώτηση πάντα θα υπογραμμίζεται με πράσινο και ο βαθμός δυσκολίας με το κεφάλαιο θα αναγράφονται" +
                " πάνω αριστερά. \n\nΜπορείτε να επιστρέψετε στο αρχικό μενού πατώντας «Επιστροφή στο μενού»." +
                " \n\nΣτο κάτω μέρος της οθόνης παρουσιάζονται δύο κουμπιά:\n ΕΠΕΞΕΡΓΑΣΙΑ ΘΕΜΑΤΟΣ: Σας επιτρέπει" +
                " την διαμόρφωση της ερώτησης.\n ΔΙΑΓΡΑΦΗ ΘΕΜΑΤΟΣ: Διαγράφει την επιλεγμένη ερώτηση", "ΕΠΙΣΚΟΠΗΣΗ" +
                " ΘΕΜΑΤΩΝ");
        }

        private void toolStripMenuItem1_ti_einai_auth_h_egarmogh_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Αυτή η εφαρμογή σας παρέχει τη δυνατότητα να δημιουργήσετε τη δική σας Τράπεζα Θεμάτων! " +
                "Μπορείτε να δημιουργήσετε τις δικές σας ερωτήσεις ή να εισάγετε έτοιμες από ένα text αρχείο. Τα θέματα" +
                " που θα δημιουργήσετε μπορούν να παραχτούν αργότερα σε ένα αρχείο word!", "ΕΦΑΡΜΟΓΗ"); 
        }
    }
}
