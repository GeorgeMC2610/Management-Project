namespace Management_Project
{
    partial class FormAddQuestion
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.buttonAddQuestion = new System.Windows.Forms.Button();
            this.labelChapter = new System.Windows.Forms.Label();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.labelAnswer = new System.Windows.Forms.Label();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.labelDifficulty = new System.Windows.Forms.Label();
            this.buttonAddPossibleAnswer = new System.Windows.Forms.Button();
            this.buttonReviewThema = new System.Windows.Forms.Button();
            this.checkBoxIsRightAnswer = new System.Windows.Forms.CheckBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonDeleteAnswer = new System.Windows.Forms.Button();
            this.buttonClearFields = new System.Windows.Forms.Button();
            this.listBoxChapters = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(45, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(966, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestion.Location = new System.Drawing.Point(41, 22);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(80, 19);
            this.labelQuestion.TabIndex = 1;
            this.labelQuestion.Text = "ΕΡΩΤΗΣΗ";
            // 
            // buttonAddQuestion
            // 
            this.buttonAddQuestion.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonAddQuestion.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonAddQuestion.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddQuestion.ForeColor = System.Drawing.Color.White;
            this.buttonAddQuestion.Location = new System.Drawing.Point(608, 508);
            this.buttonAddQuestion.Name = "buttonAddQuestion";
            this.buttonAddQuestion.Size = new System.Drawing.Size(584, 43);
            this.buttonAddQuestion.TabIndex = 10;
            this.buttonAddQuestion.Text = "ΠΡΟΣΘΗΚΗ ΕΡΩΤΗΣΗΣ ΣΤΗΝ ΤΡΑΠΕΖΑ";
            this.buttonAddQuestion.UseVisualStyleBackColor = false;
            this.buttonAddQuestion.Click += new System.EventHandler(this.buttonAddQuestion_Click);
            // 
            // labelChapter
            // 
            this.labelChapter.AutoSize = true;
            this.labelChapter.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChapter.Location = new System.Drawing.Point(41, 94);
            this.labelChapter.Name = "labelChapter";
            this.labelChapter.Size = new System.Drawing.Size(88, 19);
            this.labelChapter.TabIndex = 3;
            this.labelChapter.Text = "ΚΕΦΑΛΑΙΟ";
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Location = new System.Drawing.Point(45, 202);
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(339, 23);
            this.textBoxAnswer.TabIndex = 3;
            this.textBoxAnswer.TextChanged += new System.EventHandler(this.textBoxAnswer_TextChanged);
            // 
            // labelAnswer
            // 
            this.labelAnswer.AutoSize = true;
            this.labelAnswer.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnswer.Location = new System.Drawing.Point(41, 180);
            this.labelAnswer.Name = "labelAnswer";
            this.labelAnswer.Size = new System.Drawing.Size(95, 19);
            this.labelAnswer.TabIndex = 6;
            this.labelAnswer.Text = "Απάντηση 1";
            // 
            // buttonPrev
            // 
            this.buttonPrev.Font = new System.Drawing.Font("Roboto Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrev.Location = new System.Drawing.Point(16, 202);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(23, 23);
            this.buttonPrev.TabIndex = 5;
            this.buttonPrev.Text = "<";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Font = new System.Drawing.Font("Roboto Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.Location = new System.Drawing.Point(390, 201);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(23, 24);
            this.buttonNext.TabIndex = 4;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(494, 116);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(84, 23);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelDifficulty
            // 
            this.labelDifficulty.AutoSize = true;
            this.labelDifficulty.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDifficulty.Location = new System.Drawing.Point(490, 94);
            this.labelDifficulty.Name = "labelDifficulty";
            this.labelDifficulty.Size = new System.Drawing.Size(167, 19);
            this.labelDifficulty.TabIndex = 11;
            this.labelDifficulty.Text = "ΕΠΙΠΕΔΟ ΔΥΣΚΟΛΙΑΣ";
            // 
            // buttonAddPossibleAnswer
            // 
            this.buttonAddPossibleAnswer.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAddPossibleAnswer.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddPossibleAnswer.Location = new System.Drawing.Point(190, 173);
            this.buttonAddPossibleAnswer.Name = "buttonAddPossibleAnswer";
            this.buttonAddPossibleAnswer.Size = new System.Drawing.Size(194, 26);
            this.buttonAddPossibleAnswer.TabIndex = 6;
            this.buttonAddPossibleAnswer.Text = "Προσθήκη Νέας Απάντησης";
            this.buttonAddPossibleAnswer.UseVisualStyleBackColor = false;
            this.buttonAddPossibleAnswer.Click += new System.EventHandler(this.buttonAddPossibleAnswer_Click);
            // 
            // buttonReviewThema
            // 
            this.buttonReviewThema.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonReviewThema.BackColor = System.Drawing.Color.Green;
            this.buttonReviewThema.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReviewThema.ForeColor = System.Drawing.Color.White;
            this.buttonReviewThema.Location = new System.Drawing.Point(12, 508);
            this.buttonReviewThema.Name = "buttonReviewThema";
            this.buttonReviewThema.Size = new System.Drawing.Size(584, 43);
            this.buttonReviewThema.TabIndex = 9;
            this.buttonReviewThema.Text = "ΕΠΙΣΚΟΠΗΣΗ ΘΕΜΑΤΟΣ";
            this.buttonReviewThema.UseVisualStyleBackColor = false;
            this.buttonReviewThema.Click += new System.EventHandler(this.buttonReviewThema_Click);
            // 
            // checkBoxIsRightAnswer
            // 
            this.checkBoxIsRightAnswer.AutoSize = true;
            this.checkBoxIsRightAnswer.Location = new System.Drawing.Point(45, 231);
            this.checkBoxIsRightAnswer.Name = "checkBoxIsRightAnswer";
            this.checkBoxIsRightAnswer.Size = new System.Drawing.Size(197, 19);
            this.checkBoxIsRightAnswer.TabIndex = 7;
            this.checkBoxIsRightAnswer.Text = "Αυτή είναι η σωστή απάντηση";
            this.checkBoxIsRightAnswer.UseVisualStyleBackColor = true;
            this.checkBoxIsRightAnswer.CheckedChanged += new System.EventHandler(this.checkBoxIsRightAnswer_CheckedChanged);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.BackColor = System.Drawing.Color.Maroon;
            this.buttonExit.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(1028, 32);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(164, 35);
            this.buttonExit.TabIndex = 12;
            this.buttonExit.Text = "Επιστροφή στο Μενού";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonDeleteAnswer
            // 
            this.buttonDeleteAnswer.BackColor = System.Drawing.Color.Maroon;
            this.buttonDeleteAnswer.Enabled = false;
            this.buttonDeleteAnswer.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteAnswer.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteAnswer.Location = new System.Drawing.Point(248, 228);
            this.buttonDeleteAnswer.Name = "buttonDeleteAnswer";
            this.buttonDeleteAnswer.Size = new System.Drawing.Size(136, 24);
            this.buttonDeleteAnswer.TabIndex = 8;
            this.buttonDeleteAnswer.Text = "Διαγραφή Απάντησης";
            this.buttonDeleteAnswer.UseVisualStyleBackColor = false;
            this.buttonDeleteAnswer.Visible = false;
            this.buttonDeleteAnswer.Click += new System.EventHandler(this.buttonDeleteAnswer_Click);
            // 
            // buttonClearFields
            // 
            this.buttonClearFields.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClearFields.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonClearFields.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearFields.ForeColor = System.Drawing.Color.White;
            this.buttonClearFields.Location = new System.Drawing.Point(1028, 73);
            this.buttonClearFields.Name = "buttonClearFields";
            this.buttonClearFields.Size = new System.Drawing.Size(164, 35);
            this.buttonClearFields.TabIndex = 11;
            this.buttonClearFields.Text = "Καθαρισμός Πεδίων";
            this.buttonClearFields.UseVisualStyleBackColor = false;
            this.buttonClearFields.Click += new System.EventHandler(this.buttonClearFields_Click);
            // 
            // listBoxChapters
            // 
            this.listBoxChapters.ItemHeight = 15;
            this.listBoxChapters.Location = new System.Drawing.Point(45, 116);
            this.listBoxChapters.Name = "listBoxChapters";
            this.listBoxChapters.Size = new System.Drawing.Size(372, 34);
            this.listBoxChapters.TabIndex = 1;
            // 
            // FormAddQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 563);
            this.Controls.Add(this.listBoxChapters);
            this.Controls.Add(this.buttonClearFields);
            this.Controls.Add(this.buttonDeleteAnswer);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.checkBoxIsRightAnswer);
            this.Controls.Add(this.buttonReviewThema);
            this.Controls.Add(this.buttonAddPossibleAnswer);
            this.Controls.Add(this.labelDifficulty);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.labelAnswer);
            this.Controls.Add(this.textBoxAnswer);
            this.Controls.Add(this.labelChapter);
            this.Controls.Add(this.buttonAddQuestion);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormAddQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Προσθήκη Νέου Θέματος";
            this.Load += new System.EventHandler(this.FormAddQuestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Button buttonAddQuestion;
        private System.Windows.Forms.Label labelChapter;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.Label labelAnswer;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label labelDifficulty;
        private System.Windows.Forms.Button buttonAddPossibleAnswer;
        private System.Windows.Forms.Button buttonReviewThema;
        private System.Windows.Forms.CheckBox checkBoxIsRightAnswer;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonDeleteAnswer;
        private System.Windows.Forms.Button buttonClearFields;
        private System.Windows.Forms.ListBox listBoxChapters;
    }
}