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
            this.labelOverview = new System.Windows.Forms.Label();
            this.richTextBoxToWord = new System.Windows.Forms.RichTextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemThemaSelection = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSelectAllThemas = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemClearSelections = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAdditionalOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBoxSorting = new System.Windows.Forms.ToolStripComboBox();
            this.ToolStripMenuItemReverse = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemManageAnswers = new System.Windows.Forms.ToolStripMenuItem();
            this.maxΑπαντήσειςΑνάΘέμαToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripComboBoxMaxAnswers = new System.Windows.Forms.ToolStripComboBox();
            this.σειράΑπαντήσεωνToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBoxAnswerOrder = new System.Windows.Forms.ToolStripComboBox();
            this.menuStrip.SuspendLayout();
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
            // labelOverview
            // 
            resources.ApplyResources(this.labelOverview, "labelOverview");
            this.labelOverview.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelOverview.Name = "labelOverview";
            // 
            // richTextBoxToWord
            // 
            this.richTextBoxToWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.richTextBoxToWord, "richTextBoxToWord");
            this.richTextBoxToWord.Name = "richTextBoxToWord";
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.HighlightText;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemThemaSelection,
            this.ToolStripMenuItemAdditionalOptions,
            this.ToolStripMenuItemManageAnswers});
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.Name = "menuStrip";
            // 
            // ToolStripMenuItemThemaSelection
            // 
            this.ToolStripMenuItemThemaSelection.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemSelectAllThemas,
            this.ToolStripMenuItemClearSelections});
            this.ToolStripMenuItemThemaSelection.Name = "ToolStripMenuItemThemaSelection";
            resources.ApplyResources(this.ToolStripMenuItemThemaSelection, "ToolStripMenuItemThemaSelection");
            // 
            // ToolStripMenuItemSelectAllThemas
            // 
            this.ToolStripMenuItemSelectAllThemas.Name = "ToolStripMenuItemSelectAllThemas";
            resources.ApplyResources(this.ToolStripMenuItemSelectAllThemas, "ToolStripMenuItemSelectAllThemas");
            this.ToolStripMenuItemSelectAllThemas.Click += new System.EventHandler(this.AnyToolStripItemClickedOrChanged);
            // 
            // ToolStripMenuItemClearSelections
            // 
            this.ToolStripMenuItemClearSelections.Name = "ToolStripMenuItemClearSelections";
            resources.ApplyResources(this.ToolStripMenuItemClearSelections, "ToolStripMenuItemClearSelections");
            this.ToolStripMenuItemClearSelections.Click += new System.EventHandler(this.AnyToolStripItemClickedOrChanged);
            // 
            // ToolStripMenuItemAdditionalOptions
            // 
            this.ToolStripMenuItemAdditionalOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBoxSorting,
            this.ToolStripMenuItemReverse});
            this.ToolStripMenuItemAdditionalOptions.Name = "ToolStripMenuItemAdditionalOptions";
            resources.ApplyResources(this.ToolStripMenuItemAdditionalOptions, "ToolStripMenuItemAdditionalOptions");
            // 
            // toolStripComboBoxSorting
            // 
            this.toolStripComboBoxSorting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBoxSorting.Items.AddRange(new object[] {
            resources.GetString("toolStripComboBoxSorting.Items"),
            resources.GetString("toolStripComboBoxSorting.Items1"),
            resources.GetString("toolStripComboBoxSorting.Items2"),
            resources.GetString("toolStripComboBoxSorting.Items3"),
            resources.GetString("toolStripComboBoxSorting.Items4"),
            resources.GetString("toolStripComboBoxSorting.Items5")});
            this.toolStripComboBoxSorting.Name = "toolStripComboBoxSorting";
            resources.ApplyResources(this.toolStripComboBoxSorting, "toolStripComboBoxSorting");
            // 
            // ToolStripMenuItemReverse
            // 
            this.ToolStripMenuItemReverse.CheckOnClick = true;
            this.ToolStripMenuItemReverse.Name = "ToolStripMenuItemReverse";
            resources.ApplyResources(this.ToolStripMenuItemReverse, "ToolStripMenuItemReverse");
            // 
            // ToolStripMenuItemManageAnswers
            // 
            this.ToolStripMenuItemManageAnswers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maxΑπαντήσειςΑνάΘέμαToolStripMenuItem,
            this.σειράΑπαντήσεωνToolStripMenuItem});
            this.ToolStripMenuItemManageAnswers.Name = "ToolStripMenuItemManageAnswers";
            resources.ApplyResources(this.ToolStripMenuItemManageAnswers, "ToolStripMenuItemManageAnswers");
            // 
            // maxΑπαντήσειςΑνάΘέμαToolStripMenuItem
            // 
            this.maxΑπαντήσειςΑνάΘέμαToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripComboBoxMaxAnswers});
            this.maxΑπαντήσειςΑνάΘέμαToolStripMenuItem.Name = "maxΑπαντήσειςΑνάΘέμαToolStripMenuItem";
            resources.ApplyResources(this.maxΑπαντήσειςΑνάΘέμαToolStripMenuItem, "maxΑπαντήσειςΑνάΘέμαToolStripMenuItem");
            // 
            // ToolStripComboBoxMaxAnswers
            // 
            this.ToolStripComboBoxMaxAnswers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ToolStripComboBoxMaxAnswers.Name = "ToolStripComboBoxMaxAnswers";
            resources.ApplyResources(this.ToolStripComboBoxMaxAnswers, "ToolStripComboBoxMaxAnswers");
            // 
            // σειράΑπαντήσεωνToolStripMenuItem
            // 
            this.σειράΑπαντήσεωνToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBoxAnswerOrder});
            this.σειράΑπαντήσεωνToolStripMenuItem.Name = "σειράΑπαντήσεωνToolStripMenuItem";
            resources.ApplyResources(this.σειράΑπαντήσεωνToolStripMenuItem, "σειράΑπαντήσεωνToolStripMenuItem");
            // 
            // toolStripComboBoxAnswerOrder
            // 
            this.toolStripComboBoxAnswerOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBoxAnswerOrder.Items.AddRange(new object[] {
            resources.GetString("toolStripComboBoxAnswerOrder.Items"),
            resources.GetString("toolStripComboBoxAnswerOrder.Items1")});
            this.toolStripComboBoxAnswerOrder.Name = "toolStripComboBoxAnswerOrder";
            resources.ApplyResources(this.toolStripComboBoxAnswerOrder, "toolStripComboBoxAnswerOrder");
            // 
            // Form2
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.Controls.Add(this.richTextBoxToWord);
            this.Controls.Add(this.labelOverview);
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
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Resize += new System.EventHandler(this.Form2_Resize);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
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
        private System.Windows.Forms.Label labelOverview;
        private System.Windows.Forms.RichTextBox richTextBoxToWord;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAdditionalOptions;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxSorting;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemThemaSelection;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSelectAllThemas;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemClearSelections;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemManageAnswers;
        private System.Windows.Forms.ToolStripMenuItem maxΑπαντήσειςΑνάΘέμαToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox ToolStripComboBoxMaxAnswers;
        private System.Windows.Forms.ToolStripMenuItem σειράΑπαντήσεωνToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxAnswerOrder;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemReverse;
    }
}