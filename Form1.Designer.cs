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
            this.editQuestionsButton.BackColor = System.Drawing.Color.DarkGray;
            this.editQuestionsButton.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editQuestionsButton.ForeColor = System.Drawing.Color.Black;
            this.editQuestionsButton.Location = new System.Drawing.Point(10, 427);
            this.editQuestionsButton.Name = "editQuestionsButton";
            this.editQuestionsButton.Size = new System.Drawing.Size(546, 47);
            this.editQuestionsButton.TabIndex = 1;
            this.editQuestionsButton.Text = "ΠΡΟΒΟΛΗ/ΠΡΟΣΘΗΚΗ/ΤΡΟΠΟΠΟΙΗΣΗ ΘΕΜΑΤΩΝ";
            this.editQuestionsButton.UseVisualStyleBackColor = false;
            this.editQuestionsButton.Click += new System.EventHandler(this.editQuestionsButton_Click);
            // 
            // deleteAllQuestionsButton
            // 
            this.deleteAllQuestionsButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteAllQuestionsButton.BackColor = System.Drawing.Color.DarkRed;
            this.deleteAllQuestionsButton.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteAllQuestionsButton.ForeColor = System.Drawing.Color.White;
            this.deleteAllQuestionsButton.Location = new System.Drawing.Point(566, 427);
            this.deleteAllQuestionsButton.Name = "deleteAllQuestionsButton";
            this.deleteAllQuestionsButton.Size = new System.Drawing.Size(546, 47);
            this.deleteAllQuestionsButton.TabIndex = 2;
            this.deleteAllQuestionsButton.Text = "ΔΙΑΓΡΑΦΗ ΟΛΩΝ ΤΩΝ ΘΕΜΑΤΩΝ";
            this.deleteAllQuestionsButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 539);
            this.Controls.Add(this.deleteAllQuestionsButton);
            this.Controls.Add(this.editQuestionsButton);
            this.Controls.Add(this.wordFileButton);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Κύριο Μενού";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button wordFileButton;
        private System.Windows.Forms.Button editQuestionsButton;
        private System.Windows.Forms.Button deleteAllQuestionsButton;
    }
}

