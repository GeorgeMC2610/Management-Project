namespace Management_Project
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
            this.labelQuestions = new System.Windows.Forms.Label();
            this.numericUpDownQuestions = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownMaxAnswers = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuestions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxAnswers)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGenerateWordFile
            // 
            this.buttonGenerateWordFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGenerateWordFile.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonGenerateWordFile.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerateWordFile.ForeColor = System.Drawing.Color.White;
            this.buttonGenerateWordFile.Location = new System.Drawing.Point(14, 488);
            this.buttonGenerateWordFile.Name = "buttonGenerateWordFile";
            this.buttonGenerateWordFile.Size = new System.Drawing.Size(1193, 44);
            this.buttonGenerateWordFile.TabIndex = 0;
            this.buttonGenerateWordFile.Text = "ΠΑΡΑΓΩΓΗ ΔΙΑΓΩΝΙΣΜΑΤΟΣ ΣΕ ΜΟΡΦΗ WORD";
            this.buttonGenerateWordFile.UseVisualStyleBackColor = false;
            // 
            // richTextBoxToWord
            // 
            this.richTextBoxToWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxToWord.Location = new System.Drawing.Point(908, 104);
            this.richTextBoxToWord.Name = "richTextBoxToWord";
            this.richTextBoxToWord.Size = new System.Drawing.Size(199, 109);
            this.richTextBoxToWord.TabIndex = 1;
            this.richTextBoxToWord.Text = "";
            this.richTextBoxToWord.Visible = false;
            // 
            // labelQuestions
            // 
            this.labelQuestions.AutoSize = true;
            this.labelQuestions.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestions.Location = new System.Drawing.Point(51, 29);
            this.labelQuestions.Name = "labelQuestions";
            this.labelQuestions.Size = new System.Drawing.Size(168, 19);
            this.labelQuestions.TabIndex = 2;
            this.labelQuestions.Text = "Αριθμός Ερωτήσεων";
            // 
            // numericUpDownQuestions
            // 
            this.numericUpDownQuestions.Location = new System.Drawing.Point(56, 55);
            this.numericUpDownQuestions.Name = "numericUpDownQuestions";
            this.numericUpDownQuestions.Size = new System.Drawing.Size(63, 22);
            this.numericUpDownQuestions.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Συμπερίληψη Ερωτήσεων Δυσκολίας";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(56, 126);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(77, 20);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Εύκολης";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(56, 152);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(73, 20);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "Μέτριας";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Location = new System.Drawing.Point(56, 178);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(85, 20);
            this.checkBox3.TabIndex = 7;
            this.checkBox3.Text = "Δύσκολης";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Συμπερίληψη Κεφαλαίων";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(479, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Μέγιστος Αριθμός Απαντήσεων";
            // 
            // numericUpDownMaxAnswers
            // 
            this.numericUpDownMaxAnswers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numericUpDownMaxAnswers.Location = new System.Drawing.Point(483, 55);
            this.numericUpDownMaxAnswers.Name = "numericUpDownMaxAnswers";
            this.numericUpDownMaxAnswers.Size = new System.Drawing.Size(63, 22);
            this.numericUpDownMaxAnswers.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(55, 251);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(288, 22);
            this.textBox1.TabIndex = 11;
            // 
            // buttonNext
            // 
            this.buttonNext.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.Location = new System.Drawing.Point(349, 251);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(23, 23);
            this.buttonNext.TabIndex = 12;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = true;
            // 
            // buttonPrev
            // 
            this.buttonPrev.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrev.Location = new System.Drawing.Point(26, 251);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(23, 23);
            this.buttonPrev.TabIndex = 13;
            this.buttonPrev.Text = "<";
            this.buttonPrev.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 545);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.numericUpDownMaxAnswers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownQuestions);
            this.Controls.Add(this.labelQuestions);
            this.Controls.Add(this.richTextBoxToWord);
            this.Controls.Add(this.buttonGenerateWordFile);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuestions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxAnswers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGenerateWordFile;
        private System.Windows.Forms.RichTextBox richTextBoxToWord;
        private System.Windows.Forms.Label labelQuestions;
        private System.Windows.Forms.NumericUpDown numericUpDownQuestions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxAnswers;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrev;
    }
}