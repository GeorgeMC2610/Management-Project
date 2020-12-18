﻿namespace Management_Project
{
    partial class Form4
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
            this.buttonGenerateWordFile = new System.Windows.Forms.Button();
            this.richTextBoxToWord = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownMaxAnswers = new System.Windows.Forms.NumericUpDown();
            this.textBoxChapterSelect = new System.Windows.Forms.TextBox();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonIncludeAllChapters = new System.Windows.Forms.Button();
            this.numericUpDownEasyQuestions = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownNormalQuestions = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownHardQuestions = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownChaptersIncluded = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelOverview = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxAnswers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEasyQuestions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNormalQuestions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHardQuestions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChaptersIncluded)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGenerateWordFile
            // 
            this.buttonGenerateWordFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGenerateWordFile.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonGenerateWordFile.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerateWordFile.ForeColor = System.Drawing.Color.White;
            this.buttonGenerateWordFile.Location = new System.Drawing.Point(14, 404);
            this.buttonGenerateWordFile.Name = "buttonGenerateWordFile";
            this.buttonGenerateWordFile.Size = new System.Drawing.Size(958, 44);
            this.buttonGenerateWordFile.TabIndex = 0;
            this.buttonGenerateWordFile.Text = "ΠΑΡΑΓΩΓΗ ΔΙΑΓΩΝΙΣΜΑΤΟΣ ΣΕ ΜΟΡΦΗ WORD";
            this.buttonGenerateWordFile.UseVisualStyleBackColor = false;
            // 
            // richTextBoxToWord
            // 
            this.richTextBoxToWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxToWord.Location = new System.Drawing.Point(422, 57);
            this.richTextBoxToWord.Name = "richTextBoxToWord";
            this.richTextBoxToWord.Size = new System.Drawing.Size(194, 44);
            this.richTextBoxToWord.TabIndex = 1;
            this.richTextBoxToWord.Text = "";
            this.richTextBoxToWord.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Συμπερίληψη Ερωτήσεων Δυσκολίας";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Συμπερίληψη Κεφαλαίων";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(691, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Μέγιστος Αριθμός Απαντήσεων";
            // 
            // numericUpDownMaxAnswers
            // 
            this.numericUpDownMaxAnswers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownMaxAnswers.Location = new System.Drawing.Point(695, 55);
            this.numericUpDownMaxAnswers.Name = "numericUpDownMaxAnswers";
            this.numericUpDownMaxAnswers.Size = new System.Drawing.Size(57, 22);
            this.numericUpDownMaxAnswers.TabIndex = 10;
            // 
            // textBoxChapterSelect
            // 
            this.textBoxChapterSelect.Location = new System.Drawing.Point(55, 183);
            this.textBoxChapterSelect.Name = "textBoxChapterSelect";
            this.textBoxChapterSelect.ReadOnly = true;
            this.textBoxChapterSelect.Size = new System.Drawing.Size(288, 22);
            this.textBoxChapterSelect.TabIndex = 11;
            // 
            // buttonNext
            // 
            this.buttonNext.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.Location = new System.Drawing.Point(349, 182);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(23, 24);
            this.buttonNext.TabIndex = 12;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = true;
            // 
            // buttonPrev
            // 
            this.buttonPrev.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrev.Location = new System.Drawing.Point(25, 182);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(24, 24);
            this.buttonPrev.TabIndex = 13;
            this.buttonPrev.Text = "<";
            this.buttonPrev.UseVisualStyleBackColor = true;
            // 
            // buttonIncludeAllChapters
            // 
            this.buttonIncludeAllChapters.BackColor = System.Drawing.Color.Green;
            this.buttonIncludeAllChapters.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIncludeAllChapters.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonIncludeAllChapters.Location = new System.Drawing.Point(55, 261);
            this.buttonIncludeAllChapters.Name = "buttonIncludeAllChapters";
            this.buttonIncludeAllChapters.Size = new System.Drawing.Size(288, 49);
            this.buttonIncludeAllChapters.TabIndex = 15;
            this.buttonIncludeAllChapters.Text = "Να συμπεριληφθούν όλων των ερωτήσεων από όλα τα κεφάλαια";
            this.buttonIncludeAllChapters.UseVisualStyleBackColor = false;
            // 
            // numericUpDownEasyQuestions
            // 
            this.numericUpDownEasyQuestions.Location = new System.Drawing.Point(55, 51);
            this.numericUpDownEasyQuestions.Name = "numericUpDownEasyQuestions";
            this.numericUpDownEasyQuestions.Size = new System.Drawing.Size(63, 22);
            this.numericUpDownEasyQuestions.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(124, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Εύκολων";
            // 
            // numericUpDownNormalQuestions
            // 
            this.numericUpDownNormalQuestions.Location = new System.Drawing.Point(55, 79);
            this.numericUpDownNormalQuestions.Name = "numericUpDownNormalQuestions";
            this.numericUpDownNormalQuestions.Size = new System.Drawing.Size(63, 22);
            this.numericUpDownNormalQuestions.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(124, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Μέτριων";
            // 
            // numericUpDownHardQuestions
            // 
            this.numericUpDownHardQuestions.Location = new System.Drawing.Point(55, 107);
            this.numericUpDownHardQuestions.Name = "numericUpDownHardQuestions";
            this.numericUpDownHardQuestions.Size = new System.Drawing.Size(63, 22);
            this.numericUpDownHardQuestions.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(124, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Δύσκολων";
            // 
            // numericUpDownChaptersIncluded
            // 
            this.numericUpDownChaptersIncluded.Location = new System.Drawing.Point(55, 211);
            this.numericUpDownChaptersIncluded.Name = "numericUpDownChaptersIncluded";
            this.numericUpDownChaptersIncluded.Size = new System.Drawing.Size(63, 22);
            this.numericUpDownChaptersIncluded.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(124, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(201, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "Ερωτήσεις από αυτό το κεφάλαιο";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(758, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = "(Max.) Απαντήσεις ανά θέμα";
            // 
            // labelOverview
            // 
            this.labelOverview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelOverview.AutoSize = true;
            this.labelOverview.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOverview.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelOverview.Location = new System.Drawing.Point(19, 382);
            this.labelOverview.Name = "labelOverview";
            this.labelOverview.Size = new System.Drawing.Size(320, 18);
            this.labelOverview.TabIndex = 25;
            this.labelOverview.Text = "x ερωτήσεις από x κεφάλαια θα παραχθούν";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.labelOverview);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDownChaptersIncluded);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDownHardQuestions);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDownNormalQuestions);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownEasyQuestions);
            this.Controls.Add(this.buttonIncludeAllChapters);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.textBoxChapterSelect);
            this.Controls.Add(this.numericUpDownMaxAnswers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxToWord);
            this.Controls.Add(this.buttonGenerateWordFile);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form4";
            this.Text = "Παραγωγή Αρχείου Word";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxAnswers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEasyQuestions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNormalQuestions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHardQuestions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChaptersIncluded)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGenerateWordFile;
        private System.Windows.Forms.RichTextBox richTextBoxToWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxAnswers;
        private System.Windows.Forms.TextBox textBoxChapterSelect;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonIncludeAllChapters;
        private System.Windows.Forms.NumericUpDown numericUpDownEasyQuestions;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownNormalQuestions;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownHardQuestions;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownChaptersIncluded;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelOverview;
    }
}