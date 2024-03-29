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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.buttonGenerateWordFile = new System.Windows.Forms.Button();
            this.richTextBoxToWord = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownMaxAnswers = new System.Windows.Forms.NumericUpDown();
            this.buttonIncludeAllChapters = new System.Windows.Forms.Button();
            this.numericUpDownEasyQuestions = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownNormalQuestions = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownHardQuestions = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.labelChapterDesc = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelOverview = new System.Windows.Forms.Label();
            this.comboBoxChapters = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxSorting = new System.Windows.Forms.ComboBox();
            this.checkBoxReverse = new System.Windows.Forms.CheckBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.labelTotalDifficultyQuestions = new System.Windows.Forms.Label();
            this.checkBoxRandomizedAnswers = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSelectFont = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemIncludeAllQuestions = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAllDifficulties = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemEasyQuestions = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemNormalQuestions = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemHardQuestions = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemClearSelections = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemClearSelectionsFromAllChapters = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemClearSelectionsFromThisChapter = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxAnswers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEasyQuestions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNormalQuestions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHardQuestions)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGenerateWordFile
            // 
            this.buttonGenerateWordFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGenerateWordFile.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonGenerateWordFile.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerateWordFile.ForeColor = System.Drawing.Color.White;
            this.buttonGenerateWordFile.Location = new System.Drawing.Point(14, 505);
            this.buttonGenerateWordFile.Name = "buttonGenerateWordFile";
            this.buttonGenerateWordFile.Size = new System.Drawing.Size(1158, 44);
            this.buttonGenerateWordFile.TabIndex = 0;
            this.buttonGenerateWordFile.Text = "ΠΑΡΑΓΩΓΗ ΔΙΑΓΩΝΙΣΜΑΤΟΣ ΣΕ ΜΟΡΦΗ WORD";
            this.buttonGenerateWordFile.UseVisualStyleBackColor = false;
            this.buttonGenerateWordFile.Click += new System.EventHandler(this.buttonGenerateWordFile_Click);
            // 
            // richTextBoxToWord
            // 
            this.richTextBoxToWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxToWord.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxToWord.Location = new System.Drawing.Point(848, 354);
            this.richTextBoxToWord.Name = "richTextBoxToWord";
            this.richTextBoxToWord.Size = new System.Drawing.Size(194, 121);
            this.richTextBoxToWord.TabIndex = 1;
            this.richTextBoxToWord.Text = "";
            this.richTextBoxToWord.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Συμπερίληψη Ερωτήσεων Δυσκολίας";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 34);
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
            this.label3.Location = new System.Drawing.Point(844, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Μέγιστος Αριθμός Απαντήσεων";
            // 
            // numericUpDownMaxAnswers
            // 
            this.numericUpDownMaxAnswers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownMaxAnswers.Location = new System.Drawing.Point(848, 105);
            this.numericUpDownMaxAnswers.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownMaxAnswers.Name = "numericUpDownMaxAnswers";
            this.numericUpDownMaxAnswers.Size = new System.Drawing.Size(57, 22);
            this.numericUpDownMaxAnswers.TabIndex = 10;
            this.numericUpDownMaxAnswers.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownMaxAnswers.ValueChanged += new System.EventHandler(this.numericUpDownMaxAnswers_ValueChanged);
            // 
            // buttonIncludeAllChapters
            // 
            this.buttonIncludeAllChapters.BackColor = System.Drawing.Color.Green;
            this.buttonIncludeAllChapters.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIncludeAllChapters.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonIncludeAllChapters.Location = new System.Drawing.Point(55, 112);
            this.buttonIncludeAllChapters.Name = "buttonIncludeAllChapters";
            this.buttonIncludeAllChapters.Size = new System.Drawing.Size(288, 49);
            this.buttonIncludeAllChapters.TabIndex = 15;
            this.buttonIncludeAllChapters.Text = "Να συμπεριληφθούν όλα τα θέματα από όλα τα κεφάλαια";
            this.buttonIncludeAllChapters.UseVisualStyleBackColor = false;
            this.buttonIncludeAllChapters.Click += new System.EventHandler(this.buttonIncludeAllChapters_Click);
            // 
            // numericUpDownEasyQuestions
            // 
            this.numericUpDownEasyQuestions.Location = new System.Drawing.Point(55, 250);
            this.numericUpDownEasyQuestions.Name = "numericUpDownEasyQuestions";
            this.numericUpDownEasyQuestions.Size = new System.Drawing.Size(63, 22);
            this.numericUpDownEasyQuestions.TabIndex = 16;
            this.numericUpDownEasyQuestions.ValueChanged += new System.EventHandler(this.numericUpDownEasyQuestions_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(124, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Εύκολων";
            // 
            // numericUpDownNormalQuestions
            // 
            this.numericUpDownNormalQuestions.Location = new System.Drawing.Point(55, 278);
            this.numericUpDownNormalQuestions.Name = "numericUpDownNormalQuestions";
            this.numericUpDownNormalQuestions.Size = new System.Drawing.Size(63, 22);
            this.numericUpDownNormalQuestions.TabIndex = 18;
            this.numericUpDownNormalQuestions.ValueChanged += new System.EventHandler(this.numericUpDownNormalQuestions_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(124, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Μέτριων";
            // 
            // numericUpDownHardQuestions
            // 
            this.numericUpDownHardQuestions.Location = new System.Drawing.Point(55, 306);
            this.numericUpDownHardQuestions.Name = "numericUpDownHardQuestions";
            this.numericUpDownHardQuestions.Size = new System.Drawing.Size(63, 22);
            this.numericUpDownHardQuestions.TabIndex = 20;
            this.numericUpDownHardQuestions.ValueChanged += new System.EventHandler(this.numericUpDownHardQuestions_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(124, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Δύσκολων";
            // 
            // labelChapterDesc
            // 
            this.labelChapterDesc.AutoSize = true;
            this.labelChapterDesc.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChapterDesc.Location = new System.Drawing.Point(52, 83);
            this.labelChapterDesc.Name = "labelChapterDesc";
            this.labelChapterDesc.Size = new System.Drawing.Size(193, 16);
            this.labelChapterDesc.TabIndex = 23;
            this.labelChapterDesc.Text = "x θέματα από αυτό το κεφάλαιο";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(911, 107);
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
            this.labelOverview.Location = new System.Drawing.Point(19, 482);
            this.labelOverview.Name = "labelOverview";
            this.labelOverview.Size = new System.Drawing.Size(320, 18);
            this.labelOverview.TabIndex = 25;
            this.labelOverview.Text = "x ερωτήσεις από x κεφάλαια θα παραχθούν";
            // 
            // comboBoxChapters
            // 
            this.comboBoxChapters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChapters.FormattingEnabled = true;
            this.comboBoxChapters.Location = new System.Drawing.Point(55, 56);
            this.comboBoxChapters.Name = "comboBoxChapters";
            this.comboBoxChapters.Size = new System.Drawing.Size(288, 24);
            this.comboBoxChapters.TabIndex = 26;
            this.comboBoxChapters.SelectedIndexChanged += new System.EventHandler(this.comboBoxChapters_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(844, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 19);
            this.label9.TabIndex = 27;
            this.label9.Text = "Ταξινόμηση Θεμάτων";
            // 
            // comboBoxSorting
            // 
            this.comboBoxSorting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSorting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSorting.FormattingEnabled = true;
            this.comboBoxSorting.Items.AddRange(new object[] {
            "Ανά Κεφάλαιο",
            "Ανά Δυσκολία",
            "Ανά Αλφαβητική Σειρά (Ερωτήσεων)",
            "Ανά Αλφαβητική Σειρά (Κεφαλαίων)",
            "Σε Σειρά Προσθήκης",
            "Καμμία (Να ανακατευθούν)"});
            this.comboBoxSorting.Location = new System.Drawing.Point(848, 264);
            this.comboBoxSorting.Name = "comboBoxSorting";
            this.comboBoxSorting.Size = new System.Drawing.Size(288, 24);
            this.comboBoxSorting.TabIndex = 28;
            this.comboBoxSorting.SelectedIndexChanged += new System.EventHandler(this.comboBoxSorting_SelectedIndexChanged);
            // 
            // checkBoxReverse
            // 
            this.checkBoxReverse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxReverse.AutoSize = true;
            this.checkBoxReverse.Location = new System.Drawing.Point(848, 294);
            this.checkBoxReverse.Name = "checkBoxReverse";
            this.checkBoxReverse.Size = new System.Drawing.Size(91, 20);
            this.checkBoxReverse.TabIndex = 29;
            this.checkBoxReverse.Text = "Αντίστροφη";
            this.checkBoxReverse.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.DarkRed;
            this.buttonExit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonExit.Location = new System.Drawing.Point(1025, 27);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(147, 30);
            this.buttonExit.TabIndex = 30;
            this.buttonExit.Text = "Επιστροφή στο Μενού";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "rtf";
            this.saveFileDialog1.FileName = "Diagonisma.rtf";
            this.saveFileDialog1.Filter = "Rich Text Format files|*.rtf";
            this.saveFileDialog1.Title = "Αποθήκευση αρχείου σε μορφή .rtf";
            // 
            // labelTotalDifficultyQuestions
            // 
            this.labelTotalDifficultyQuestions.AutoSize = true;
            this.labelTotalDifficultyQuestions.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalDifficultyQuestions.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelTotalDifficultyQuestions.Location = new System.Drawing.Point(52, 341);
            this.labelTotalDifficultyQuestions.Name = "labelTotalDifficultyQuestions";
            this.labelTotalDifficultyQuestions.Size = new System.Drawing.Size(254, 16);
            this.labelTotalDifficultyQuestions.TabIndex = 31;
            this.labelTotalDifficultyQuestions.Text = "x συνολικά θέματα από όλες τις δυσκολίες";
            // 
            // checkBoxRandomizedAnswers
            // 
            this.checkBoxRandomizedAnswers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxRandomizedAnswers.AutoSize = true;
            this.checkBoxRandomizedAnswers.Location = new System.Drawing.Point(848, 133);
            this.checkBoxRandomizedAnswers.Name = "checkBoxRandomizedAnswers";
            this.checkBoxRandomizedAnswers.Size = new System.Drawing.Size(112, 20);
            this.checkBoxRandomizedAnswers.TabIndex = 32;
            this.checkBoxRandomizedAnswers.Text = "Ανακατεμμένες";
            this.checkBoxRandomizedAnswers.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemOptions});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItemOptions
            // 
            this.ToolStripMenuItemOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemSelectFont,
            this.ToolStripMenuItemIncludeAllQuestions,
            this.ToolStripMenuItemClearSelections});
            this.ToolStripMenuItemOptions.Name = "ToolStripMenuItemOptions";
            this.ToolStripMenuItemOptions.Size = new System.Drawing.Size(149, 20);
            this.ToolStripMenuItemOptions.Text = "Επιπρόσθετες Ρυθμίσεις";
            // 
            // ToolStripMenuItemSelectFont
            // 
            this.ToolStripMenuItemSelectFont.Name = "ToolStripMenuItemSelectFont";
            this.ToolStripMenuItemSelectFont.Size = new System.Drawing.Size(409, 22);
            this.ToolStripMenuItemSelectFont.Text = "Επιλογή Γραμματοσειράς";
            this.ToolStripMenuItemSelectFont.Click += new System.EventHandler(this.ToolStripMenuItemSelectFont_Click);
            // 
            // ToolStripMenuItemIncludeAllQuestions
            // 
            this.ToolStripMenuItemIncludeAllQuestions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemAllDifficulties,
            this.ToolStripMenuItemEasyQuestions,
            this.ToolStripMenuItemNormalQuestions,
            this.ToolStripMenuItemHardQuestions});
            this.ToolStripMenuItemIncludeAllQuestions.Name = "ToolStripMenuItemIncludeAllQuestions";
            this.ToolStripMenuItemIncludeAllQuestions.Size = new System.Drawing.Size(409, 22);
            this.ToolStripMenuItemIncludeAllQuestions.Text = "Να συμπεριληφθούν όλα τα θέματα του τρέχοντος κεφαλαίου";
            // 
            // ToolStripMenuItemAllDifficulties
            // 
            this.ToolStripMenuItemAllDifficulties.Name = "ToolStripMenuItemAllDifficulties";
            this.ToolStripMenuItemAllDifficulties.Size = new System.Drawing.Size(208, 22);
            this.ToolStripMenuItemAllDifficulties.Text = "Όλων των δυσκολιών";
            this.ToolStripMenuItemAllDifficulties.Click += new System.EventHandler(this.ToolStripMenuItemAllDifficulties_Click);
            // 
            // ToolStripMenuItemEasyQuestions
            // 
            this.ToolStripMenuItemEasyQuestions.Name = "ToolStripMenuItemEasyQuestions";
            this.ToolStripMenuItemEasyQuestions.Size = new System.Drawing.Size(208, 22);
            this.ToolStripMenuItemEasyQuestions.Text = "Της εύκολης δυσκολίας";
            this.ToolStripMenuItemEasyQuestions.Click += new System.EventHandler(this.ToolStripMenuItemEasyQuestions_Click);
            // 
            // ToolStripMenuItemNormalQuestions
            // 
            this.ToolStripMenuItemNormalQuestions.Name = "ToolStripMenuItemNormalQuestions";
            this.ToolStripMenuItemNormalQuestions.Size = new System.Drawing.Size(208, 22);
            this.ToolStripMenuItemNormalQuestions.Text = "Της μέτριας δυσκολίας";
            this.ToolStripMenuItemNormalQuestions.Click += new System.EventHandler(this.ToolStripMenuItemNormalQuestions_Click);
            // 
            // ToolStripMenuItemHardQuestions
            // 
            this.ToolStripMenuItemHardQuestions.Name = "ToolStripMenuItemHardQuestions";
            this.ToolStripMenuItemHardQuestions.Size = new System.Drawing.Size(208, 22);
            this.ToolStripMenuItemHardQuestions.Text = "Της δύσκολης δυσκολίας";
            this.ToolStripMenuItemHardQuestions.Click += new System.EventHandler(this.ToolStripMenuItemHardQuestions_Click);
            // 
            // ToolStripMenuItemClearSelections
            // 
            this.ToolStripMenuItemClearSelections.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemClearSelectionsFromAllChapters,
            this.ToolStripMenuItemClearSelectionsFromThisChapter});
            this.ToolStripMenuItemClearSelections.Name = "ToolStripMenuItemClearSelections";
            this.ToolStripMenuItemClearSelections.Size = new System.Drawing.Size(409, 22);
            this.ToolStripMenuItemClearSelections.Text = "Να μην συμπεριληφθεί τίποτα";
            // 
            // ToolStripMenuItemClearSelectionsFromAllChapters
            // 
            this.ToolStripMenuItemClearSelectionsFromAllChapters.Name = "ToolStripMenuItemClearSelectionsFromAllChapters";
            this.ToolStripMenuItemClearSelectionsFromAllChapters.Size = new System.Drawing.Size(206, 22);
            this.ToolStripMenuItemClearSelectionsFromAllChapters.Text = "Από κανένα κεφάλαιο";
            this.ToolStripMenuItemClearSelectionsFromAllChapters.Click += new System.EventHandler(this.ToolStripMenuItemClearSelectionsFromAllChapters_Click);
            // 
            // ToolStripMenuItemClearSelectionsFromThisChapter
            // 
            this.ToolStripMenuItemClearSelectionsFromThisChapter.Name = "ToolStripMenuItemClearSelectionsFromThisChapter";
            this.ToolStripMenuItemClearSelectionsFromThisChapter.Size = new System.Drawing.Size(206, 22);
            this.ToolStripMenuItemClearSelectionsFromThisChapter.Text = "Από το τρέχον κεφάλαιο";
            this.ToolStripMenuItemClearSelectionsFromThisChapter.Click += new System.EventHandler(this.ToolStripMenuItemClearSelectionsFromThisChapter_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.checkBoxRandomizedAnswers);
            this.Controls.Add(this.labelTotalDifficultyQuestions);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.checkBoxReverse);
            this.Controls.Add(this.comboBoxSorting);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBoxChapters);
            this.Controls.Add(this.labelOverview);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelChapterDesc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDownHardQuestions);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDownNormalQuestions);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownEasyQuestions);
            this.Controls.Add(this.buttonIncludeAllChapters);
            this.Controls.Add(this.numericUpDownMaxAnswers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxToWord);
            this.Controls.Add(this.buttonGenerateWordFile);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Τράπεζα Θεμάτων - Παραγωγή Αρχείου Word - Τυχαία Επιλογή Θεμάτων";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form4_FormClosed);
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxAnswers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEasyQuestions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNormalQuestions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHardQuestions)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Button buttonIncludeAllChapters;
        private System.Windows.Forms.NumericUpDown numericUpDownEasyQuestions;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownNormalQuestions;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownHardQuestions;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelChapterDesc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelOverview;
        private System.Windows.Forms.ComboBox comboBoxChapters;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxSorting;
        private System.Windows.Forms.CheckBox checkBoxReverse;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label labelTotalDifficultyQuestions;
        private System.Windows.Forms.CheckBox checkBoxRandomizedAnswers;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemOptions;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSelectFont;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemIncludeAllQuestions;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAllDifficulties;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemEasyQuestions;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemNormalQuestions;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemHardQuestions;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemClearSelections;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemClearSelectionsFromAllChapters;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemClearSelectionsFromThisChapter;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}