namespace Management_Project
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.labelQuestion = new System.Windows.Forms.Label();
            this.labelAnswers = new System.Windows.Forms.Label();
            this.labelRightAnswer = new System.Windows.Forms.Label();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.labelDifficulty = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.labelChapter = new System.Windows.Forms.Label();
            this.buttonEditQuestion = new System.Windows.Forms.Button();
            this.buttonDeleteQuestion = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonSelectQuestion = new System.Windows.Forms.Button();
            this.buttonGenerateWord = new System.Windows.Forms.Button();
            this.comboBoxSorting = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoEllipsis = true;
            resources.ApplyResources(this.labelQuestion, "labelQuestion");
            this.labelQuestion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelQuestion.Name = "labelQuestion";
            // 
            // labelAnswers
            // 
            resources.ApplyResources(this.labelAnswers, "labelAnswers");
            this.labelAnswers.BackColor = System.Drawing.Color.Transparent;
            this.labelAnswers.Name = "labelAnswers";
            // 
            // labelRightAnswer
            // 
            resources.ApplyResources(this.labelRightAnswer, "labelRightAnswer");
            this.labelRightAnswer.BackColor = System.Drawing.Color.LightGreen;
            this.labelRightAnswer.Name = "labelRightAnswer";
            // 
            // buttonPrev
            // 
            resources.ApplyResources(this.buttonPrev, "buttonPrev");
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.AnyButtonClicked);
            // 
            // labelDifficulty
            // 
            resources.ApplyResources(this.labelDifficulty, "labelDifficulty");
            this.labelDifficulty.Name = "labelDifficulty";
            // 
            // buttonNext
            // 
            resources.ApplyResources(this.buttonNext, "buttonNext");
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.AnyButtonClicked);
            // 
            // labelChapter
            // 
            resources.ApplyResources(this.labelChapter, "labelChapter");
            this.labelChapter.Name = "labelChapter";
            // 
            // buttonEditQuestion
            // 
            resources.ApplyResources(this.buttonEditQuestion, "buttonEditQuestion");
            this.buttonEditQuestion.Name = "buttonEditQuestion";
            this.buttonEditQuestion.UseVisualStyleBackColor = true;
            this.buttonEditQuestion.Click += new System.EventHandler(this.AnyButtonClicked);
            // 
            // buttonDeleteQuestion
            // 
            resources.ApplyResources(this.buttonDeleteQuestion, "buttonDeleteQuestion");
            this.buttonDeleteQuestion.BackColor = System.Drawing.Color.DarkRed;
            this.buttonDeleteQuestion.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteQuestion.Name = "buttonDeleteQuestion";
            this.buttonDeleteQuestion.UseVisualStyleBackColor = false;
            this.buttonDeleteQuestion.Click += new System.EventHandler(this.AnyButtonClicked);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.DarkRed;
            resources.ApplyResources(this.buttonExit, "buttonExit");
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.AnyButtonClicked);
            // 
            // buttonSelectQuestion
            // 
            resources.ApplyResources(this.buttonSelectQuestion, "buttonSelectQuestion");
            this.buttonSelectQuestion.BackColor = System.Drawing.Color.Green;
            this.buttonSelectQuestion.ForeColor = System.Drawing.Color.White;
            this.buttonSelectQuestion.Name = "buttonSelectQuestion";
            this.buttonSelectQuestion.UseVisualStyleBackColor = false;
            this.buttonSelectQuestion.Click += new System.EventHandler(this.AnyButtonClicked);
            // 
            // buttonGenerateWord
            // 
            resources.ApplyResources(this.buttonGenerateWord, "buttonGenerateWord");
            this.buttonGenerateWord.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonGenerateWord.ForeColor = System.Drawing.Color.White;
            this.buttonGenerateWord.Name = "buttonGenerateWord";
            this.buttonGenerateWord.UseVisualStyleBackColor = false;
            this.buttonGenerateWord.Click += new System.EventHandler(this.AnyButtonClicked);
            // 
            // comboBoxSorting
            // 
            this.comboBoxSorting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSorting.FormattingEnabled = true;
            this.comboBoxSorting.Items.AddRange(new object[] {
            resources.GetString("comboBoxSorting.Items"),
            resources.GetString("comboBoxSorting.Items1"),
            resources.GetString("comboBoxSorting.Items2"),
            resources.GetString("comboBoxSorting.Items3"),
            resources.GetString("comboBoxSorting.Items4"),
            resources.GetString("comboBoxSorting.Items5")});
            resources.ApplyResources(this.comboBoxSorting, "comboBoxSorting");
            this.comboBoxSorting.Name = "comboBoxSorting";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // Form2
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSorting);
            this.Controls.Add(this.buttonGenerateWord);
            this.Controls.Add(this.buttonSelectQuestion);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonDeleteQuestion);
            this.Controls.Add(this.buttonEditQuestion);
            this.Controls.Add(this.labelChapter);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.labelDifficulty);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.labelRightAnswer);
            this.Controls.Add(this.labelAnswers);
            this.Controls.Add(this.labelQuestion);
            this.Name = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Resize += new System.EventHandler(this.Form2_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Label labelAnswers;
        private System.Windows.Forms.Label labelRightAnswer;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Label labelDifficulty;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label labelChapter;
        private System.Windows.Forms.Button buttonEditQuestion;
        private System.Windows.Forms.Button buttonDeleteQuestion;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonSelectQuestion;
        private System.Windows.Forms.Button buttonGenerateWord;
        private System.Windows.Forms.ComboBox comboBoxSorting;
        private System.Windows.Forms.Label label1;
    }
}