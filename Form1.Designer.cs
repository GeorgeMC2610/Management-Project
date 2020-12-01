namespace Management_Project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.wordFileButton = new System.Windows.Forms.Button();
            this.editQuestionsButton = new System.Windows.Forms.Button();
            this.deleteAllQuestionsButton = new System.Windows.Forms.Button();
            this.labelTrapezaThematon = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelAvailableQuestions = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // wordFileButton
            // 
            this.wordFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wordFileButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.wordFileButton.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordFileButton.ForeColor = System.Drawing.Color.White;
            this.wordFileButton.Location = new System.Drawing.Point(10, 480);
            this.wordFileButton.Name = "wordFileButton";
            this.wordFileButton.Size = new System.Drawing.Size(1103, 47);
            this.wordFileButton.TabIndex = 0;
            this.wordFileButton.Text = "ΠΑΡΑΓΩΓΗ ΑΡΧΕΙΟΥ WORD";
            this.wordFileButton.UseVisualStyleBackColor = false;
            // 
            // editQuestionsButton
            // 
            this.editQuestionsButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editQuestionsButton.BackColor = System.Drawing.Color.Gainsboro;
            this.editQuestionsButton.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editQuestionsButton.ForeColor = System.Drawing.Color.Black;
            this.editQuestionsButton.Location = new System.Drawing.Point(6, 108);
            this.editQuestionsButton.Name = "editQuestionsButton";
            this.editQuestionsButton.Size = new System.Drawing.Size(298, 37);
            this.editQuestionsButton.TabIndex = 1;
            this.editQuestionsButton.Text = "ΠΡΟΒΟΛΗ/ΤΡΟΠΟΠΟΙΗΣΗ ΘΕΜΑΤΩΝ";
            this.editQuestionsButton.UseVisualStyleBackColor = false;
            this.editQuestionsButton.Click += new System.EventHandler(this.editQuestionsButton_Click);
            // 
            // deleteAllQuestionsButton
            // 
            this.deleteAllQuestionsButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteAllQuestionsButton.BackColor = System.Drawing.Color.DarkRed;
            this.deleteAllQuestionsButton.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteAllQuestionsButton.ForeColor = System.Drawing.Color.White;
            this.deleteAllQuestionsButton.Location = new System.Drawing.Point(6, 65);
            this.deleteAllQuestionsButton.Name = "deleteAllQuestionsButton";
            this.deleteAllQuestionsButton.Size = new System.Drawing.Size(298, 37);
            this.deleteAllQuestionsButton.TabIndex = 2;
            this.deleteAllQuestionsButton.Text = "ΔΙΑΓΡΑΦΗ ΟΛΩΝ ΤΩΝ ΘΕΜΑΤΩΝ";
            this.deleteAllQuestionsButton.UseVisualStyleBackColor = false;
            this.deleteAllQuestionsButton.Click += new System.EventHandler(this.deleteAllQuestionsButton_Click);
            // 
            // labelTrapezaThematon
            // 
            this.labelTrapezaThematon.AutoSize = true;
            this.labelTrapezaThematon.Location = new System.Drawing.Point(502, 33);
            this.labelTrapezaThematon.Name = "labelTrapezaThematon";
            this.labelTrapezaThematon.Size = new System.Drawing.Size(114, 15);
            this.labelTrapezaThematon.TabIndex = 3;
            this.labelTrapezaThematon.Text = "Τράπεζα Θεμάτων";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(6, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(298, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "ΠΡΟΣΘΗΚΗ ΝΕΟΥ ΘΕΜΑΤΟΣ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1124, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Linen;
            this.groupBox1.Controls.Add(this.labelAvailableQuestions);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.deleteAllQuestionsButton);
            this.groupBox1.Controls.Add(this.editQuestionsButton);
            this.groupBox1.Location = new System.Drawing.Point(803, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 268);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ΕΠΕΞΕΡΓΑΣΙΑ ΤΡΑΠΕΖΑΣ";
            // 
            // labelAvailableQuestions
            // 
            this.labelAvailableQuestions.AutoSize = true;
            this.labelAvailableQuestions.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvailableQuestions.Location = new System.Drawing.Point(2, 234);
            this.labelAvailableQuestions.Name = "labelAvailableQuestions";
            this.labelAvailableQuestions.Size = new System.Drawing.Size(189, 19);
            this.labelAvailableQuestions.TabIndex = 5;
            this.labelAvailableQuestions.Text = "x Διαθέσιμες Ερωτήσεις";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1124, 539);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelTrapezaThematon);
            this.Controls.Add(this.wordFileButton);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Κύριο Μενού";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button wordFileButton;
        private System.Windows.Forms.Button editQuestionsButton;
        private System.Windows.Forms.Button deleteAllQuestionsButton;
        private System.Windows.Forms.Label labelTrapezaThematon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelAvailableQuestions;
    }
}

