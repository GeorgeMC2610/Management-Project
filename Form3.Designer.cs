﻿namespace Management_Project
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
            this.textBoxChapter = new System.Windows.Forms.TextBox();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.labelAnswer = new System.Windows.Forms.Label();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonConfirmAnswer = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.labelDifficulty = new System.Windows.Forms.Label();
            this.buttonAddPossibleAnswer = new System.Windows.Forms.Button();
            this.buttonReviewThema = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(45, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(966, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestion.Location = new System.Drawing.Point(41, 37);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(80, 19);
            this.labelQuestion.TabIndex = 1;
            this.labelQuestion.Text = "ΕΡΩΤΗΣΗ";
            // 
            // buttonAddQuestion
            // 
            this.buttonAddQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddQuestion.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonAddQuestion.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddQuestion.ForeColor = System.Drawing.Color.White;
            this.buttonAddQuestion.Location = new System.Drawing.Point(608, 508);
            this.buttonAddQuestion.Name = "buttonAddQuestion";
            this.buttonAddQuestion.Size = new System.Drawing.Size(584, 43);
            this.buttonAddQuestion.TabIndex = 2;
            this.buttonAddQuestion.Text = "ΠΡΟΣΘΗΚΗ ΕΡΩΤΗΣΗΣ ΣΤΗΝ ΤΡΑΠΕΖΑ";
            this.buttonAddQuestion.UseVisualStyleBackColor = false;
            this.buttonAddQuestion.Click += new System.EventHandler(this.buttonAddQuestion_Click);
            // 
            // labelChapter
            // 
            this.labelChapter.AutoSize = true;
            this.labelChapter.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChapter.Location = new System.Drawing.Point(41, 109);
            this.labelChapter.Name = "labelChapter";
            this.labelChapter.Size = new System.Drawing.Size(88, 19);
            this.labelChapter.TabIndex = 3;
            this.labelChapter.Text = "ΚΕΦΑΛΑΙΟ";
            // 
            // textBoxChapter
            // 
            this.textBoxChapter.Location = new System.Drawing.Point(45, 131);
            this.textBoxChapter.Name = "textBoxChapter";
            this.textBoxChapter.Size = new System.Drawing.Size(339, 23);
            this.textBoxChapter.TabIndex = 4;
            this.textBoxChapter.TextChanged += new System.EventHandler(this.textBoxChapter_TextChanged);
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Location = new System.Drawing.Point(45, 217);
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(339, 23);
            this.textBoxAnswer.TabIndex = 5;
            // 
            // labelAnswer
            // 
            this.labelAnswer.AutoSize = true;
            this.labelAnswer.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnswer.Location = new System.Drawing.Point(41, 195);
            this.labelAnswer.Name = "labelAnswer";
            this.labelAnswer.Size = new System.Drawing.Size(95, 19);
            this.labelAnswer.TabIndex = 6;
            this.labelAnswer.Text = "Απάντηση 1";
            // 
            // buttonPrev
            // 
            this.buttonPrev.Font = new System.Drawing.Font("Roboto Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrev.Location = new System.Drawing.Point(16, 217);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(23, 23);
            this.buttonPrev.TabIndex = 7;
            this.buttonPrev.Text = "<";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Font = new System.Drawing.Font("Roboto Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.Location = new System.Drawing.Point(390, 216);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(23, 24);
            this.buttonNext.TabIndex = 8;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonConfirmAnswer
            // 
            this.buttonConfirmAnswer.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonConfirmAnswer.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmAnswer.Location = new System.Drawing.Point(45, 246);
            this.buttonConfirmAnswer.Name = "buttonConfirmAnswer";
            this.buttonConfirmAnswer.Size = new System.Drawing.Size(339, 24);
            this.buttonConfirmAnswer.TabIndex = 9;
            this.buttonConfirmAnswer.Text = "Επιβεβαίωση Απάντησης";
            this.buttonConfirmAnswer.UseVisualStyleBackColor = false;
            this.buttonConfirmAnswer.Click += new System.EventHandler(this.buttonConfirmAnswer_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(494, 131);
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
            this.numericUpDown1.TabIndex = 10;
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
            this.labelDifficulty.Location = new System.Drawing.Point(490, 109);
            this.labelDifficulty.Name = "labelDifficulty";
            this.labelDifficulty.Size = new System.Drawing.Size(167, 19);
            this.labelDifficulty.TabIndex = 11;
            this.labelDifficulty.Text = "ΕΠΙΠΕΔΟ ΔΥΣΚΟΛΙΑΣ";
            // 
            // buttonAddPossibleAnswer
            // 
            this.buttonAddPossibleAnswer.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAddPossibleAnswer.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddPossibleAnswer.Location = new System.Drawing.Point(190, 188);
            this.buttonAddPossibleAnswer.Name = "buttonAddPossibleAnswer";
            this.buttonAddPossibleAnswer.Size = new System.Drawing.Size(194, 26);
            this.buttonAddPossibleAnswer.TabIndex = 12;
            this.buttonAddPossibleAnswer.Text = "Προσθήκη Νέας Απάντησης";
            this.buttonAddPossibleAnswer.UseVisualStyleBackColor = false;
            this.buttonAddPossibleAnswer.Click += new System.EventHandler(this.buttonAddPossibleAnswer_Click);
            // 
            // buttonReviewThema
            // 
            this.buttonReviewThema.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReviewThema.BackColor = System.Drawing.Color.Green;
            this.buttonReviewThema.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReviewThema.ForeColor = System.Drawing.Color.White;
            this.buttonReviewThema.Location = new System.Drawing.Point(12, 508);
            this.buttonReviewThema.Name = "buttonReviewThema";
            this.buttonReviewThema.Size = new System.Drawing.Size(584, 43);
            this.buttonReviewThema.TabIndex = 13;
            this.buttonReviewThema.Text = "ΕΠΙΣΚΟΠΗΣΗ ΘΕΜΑΤΟΣ";
            this.buttonReviewThema.UseVisualStyleBackColor = false;
            this.buttonReviewThema.Click += new System.EventHandler(this.buttonReviewThema_Click);
            // 
            // FormAddQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 563);
            this.Controls.Add(this.buttonReviewThema);
            this.Controls.Add(this.buttonAddPossibleAnswer);
            this.Controls.Add(this.labelDifficulty);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.buttonConfirmAnswer);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.labelAnswer);
            this.Controls.Add(this.textBoxAnswer);
            this.Controls.Add(this.textBoxChapter);
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
        private System.Windows.Forms.TextBox textBoxChapter;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.Label labelAnswer;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonConfirmAnswer;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label labelDifficulty;
        private System.Windows.Forms.Button buttonAddPossibleAnswer;
        private System.Windows.Forms.Button buttonReviewThema;
    }
}