namespace VocabularyTest.WinForms
{
    partial class VocabularyTestForm
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
            this.components = new System.ComponentModel.Container();
            this.ListNamesBox = new System.Windows.Forms.ListBox();
            this.NewButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.DuplicateButton = new System.Windows.Forms.Button();
            this.WordListGrid = new System.Windows.Forms.DataGridView();
            this.AddLanguageButton = new System.Windows.Forms.Button();
            this.NewLanguageLabel = new System.Windows.Forms.Label();
            this.NewLanguageBox = new System.Windows.Forms.TextBox();
            this.NumWordsLabel = new System.Windows.Forms.Label();
            this.ActualNumWordsLabel = new System.Windows.Forms.Label();
            this.PracticeButton = new System.Windows.Forms.Button();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.ListLabTab = new System.Windows.Forms.TabPage();
            this.RemoveWordButton = new System.Windows.Forms.Button();
            this.NamePrecedesLanguageLabel = new System.Windows.Forms.Label();
            this.PracticeTab = new System.Windows.Forms.TabPage();
            this.NoWordsLabel = new System.Windows.Forms.Label();
            this.LatestSessionLabel = new System.Windows.Forms.Label();
            this.SessionInfoLabel = new System.Windows.Forms.Label();
            this.CorrectOrNotLabel = new System.Windows.Forms.Label();
            this.TranslateThisLabel = new System.Windows.Forms.Label();
            this.UserTranslationBox = new System.Windows.Forms.TextBox();
            this.TranslateFromXToYLabel = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.Button();
            this.NoPeekingLabel = new System.Windows.Forms.Label();
            this.PracticeLabel = new System.Windows.Forms.Label();
            this.NoPeekingLabelTimer = new System.Windows.Forms.Timer(this.components);
            this.CorrectOrNotTimer = new System.Windows.Forms.Timer(this.components);
            this.NamePrecedesLanguageTimer = new System.Windows.Forms.Timer(this.components);
            this.NoWordsTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.WordListGrid)).BeginInit();
            this.TabControl.SuspendLayout();
            this.ListLabTab.SuspendLayout();
            this.PracticeTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListNamesBox
            // 
            this.ListNamesBox.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListNamesBox.ForeColor = System.Drawing.Color.Gray;
            this.ListNamesBox.FormattingEnabled = true;
            this.ListNamesBox.ItemHeight = 19;
            this.ListNamesBox.Location = new System.Drawing.Point(30, 60);
            this.ListNamesBox.Name = "ListNamesBox";
            this.ListNamesBox.Size = new System.Drawing.Size(188, 308);
            this.ListNamesBox.TabIndex = 0;
            this.ListNamesBox.SelectedIndexChanged += new System.EventHandler(this.ListNamesBox_SelectedIndexChanged);
            // 
            // NewButton
            // 
            this.NewButton.Location = new System.Drawing.Point(31, 374);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(91, 26);
            this.NewButton.TabIndex = 1;
            this.NewButton.Text = "New";
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(31, 406);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(91, 26);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(128, 374);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(91, 26);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(280, 23);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(100, 24);
            this.NameBox.TabIndex = 5;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(227, 26);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(47, 18);
            this.NameLabel.TabIndex = 6;
            this.NameLabel.Text = "Name:";
            // 
            // DuplicateButton
            // 
            this.DuplicateButton.Location = new System.Drawing.Point(128, 406);
            this.DuplicateButton.Name = "DuplicateButton";
            this.DuplicateButton.Size = new System.Drawing.Size(90, 26);
            this.DuplicateButton.TabIndex = 7;
            this.DuplicateButton.Text = "Duplicate";
            this.DuplicateButton.UseVisualStyleBackColor = true;
            this.DuplicateButton.Click += new System.EventHandler(this.DuplicateButton_Click);
            // 
            // WordListGrid
            // 
            this.WordListGrid.BackgroundColor = System.Drawing.Color.White;
            this.WordListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WordListGrid.GridColor = System.Drawing.Color.Gray;
            this.WordListGrid.Location = new System.Drawing.Point(230, 61);
            this.WordListGrid.Name = "WordListGrid";
            this.WordListGrid.RowHeadersWidth = 51;
            this.WordListGrid.RowTemplate.Height = 24;
            this.WordListGrid.Size = new System.Drawing.Size(609, 299);
            this.WordListGrid.TabIndex = 8;
            // 
            // AddLanguageButton
            // 
            this.AddLanguageButton.Location = new System.Drawing.Point(724, 375);
            this.AddLanguageButton.Name = "AddLanguageButton";
            this.AddLanguageButton.Size = new System.Drawing.Size(90, 26);
            this.AddLanguageButton.TabIndex = 9;
            this.AddLanguageButton.Text = "Add";
            this.AddLanguageButton.UseVisualStyleBackColor = true;
            this.AddLanguageButton.Click += new System.EventHandler(this.AddLanguageButton_Click);
            // 
            // NewLanguageLabel
            // 
            this.NewLanguageLabel.AutoSize = true;
            this.NewLanguageLabel.Location = new System.Drawing.Point(504, 379);
            this.NewLanguageLabel.Name = "NewLanguageLabel";
            this.NewLanguageLabel.Size = new System.Drawing.Size(98, 18);
            this.NewLanguageLabel.TabIndex = 10;
            this.NewLanguageLabel.Text = "New language:";
            // 
            // NewLanguageBox
            // 
            this.NewLanguageBox.Location = new System.Drawing.Point(615, 376);
            this.NewLanguageBox.Name = "NewLanguageBox";
            this.NewLanguageBox.Size = new System.Drawing.Size(100, 24);
            this.NewLanguageBox.TabIndex = 11;
            // 
            // NumWordsLabel
            // 
            this.NumWordsLabel.AutoSize = true;
            this.NumWordsLabel.Location = new System.Drawing.Point(417, 26);
            this.NumWordsLabel.Name = "NumWordsLabel";
            this.NumWordsLabel.Size = new System.Drawing.Size(118, 18);
            this.NumWordsLabel.TabIndex = 12;
            this.NumWordsLabel.Text = "Number of words:";
            // 
            // ActualNumWordsLabel
            // 
            this.ActualNumWordsLabel.AutoSize = true;
            this.ActualNumWordsLabel.Location = new System.Drawing.Point(546, 26);
            this.ActualNumWordsLabel.Name = "ActualNumWordsLabel";
            this.ActualNumWordsLabel.Size = new System.Drawing.Size(12, 18);
            this.ActualNumWordsLabel.TabIndex = 13;
            this.ActualNumWordsLabel.Text = " ";
            // 
            // PracticeButton
            // 
            this.PracticeButton.Enabled = false;
            this.PracticeButton.Location = new System.Drawing.Point(377, 59);
            this.PracticeButton.Name = "PracticeButton";
            this.PracticeButton.Size = new System.Drawing.Size(91, 31);
            this.PracticeButton.TabIndex = 14;
            this.PracticeButton.Text = "Start";
            this.PracticeButton.UseVisualStyleBackColor = true;
            this.PracticeButton.Click += new System.EventHandler(this.PracticeButton_Click);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.ListLabTab);
            this.TabControl.Controls.Add(this.PracticeTab);
            this.TabControl.Location = new System.Drawing.Point(12, 12);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(879, 485);
            this.TabControl.TabIndex = 15;
            this.TabControl.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.TabControl_Selecting);
            // 
            // ListLabTab
            // 
            this.ListLabTab.BackColor = System.Drawing.Color.Thistle;
            this.ListLabTab.Controls.Add(this.RemoveWordButton);
            this.ListLabTab.Controls.Add(this.NamePrecedesLanguageLabel);
            this.ListLabTab.Controls.Add(this.ListNamesBox);
            this.ListLabTab.Controls.Add(this.WordListGrid);
            this.ListLabTab.Controls.Add(this.NameBox);
            this.ListLabTab.Controls.Add(this.NewLanguageBox);
            this.ListLabTab.Controls.Add(this.NewButton);
            this.ListLabTab.Controls.Add(this.NewLanguageLabel);
            this.ListLabTab.Controls.Add(this.DeleteButton);
            this.ListLabTab.Controls.Add(this.ActualNumWordsLabel);
            this.ListLabTab.Controls.Add(this.NameLabel);
            this.ListLabTab.Controls.Add(this.DuplicateButton);
            this.ListLabTab.Controls.Add(this.NumWordsLabel);
            this.ListLabTab.Controls.Add(this.SaveButton);
            this.ListLabTab.Controls.Add(this.AddLanguageButton);
            this.ListLabTab.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListLabTab.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ListLabTab.Location = new System.Drawing.Point(4, 25);
            this.ListLabTab.Name = "ListLabTab";
            this.ListLabTab.Padding = new System.Windows.Forms.Padding(3);
            this.ListLabTab.Size = new System.Drawing.Size(871, 456);
            this.ListLabTab.TabIndex = 0;
            this.ListLabTab.Text = "ListLab";
            // 
            // RemoveWordButton
            // 
            this.RemoveWordButton.Location = new System.Drawing.Point(712, 23);
            this.RemoveWordButton.Name = "RemoveWordButton";
            this.RemoveWordButton.Size = new System.Drawing.Size(115, 25);
            this.RemoveWordButton.TabIndex = 16;
            this.RemoveWordButton.Text = "Remove row";
            this.RemoveWordButton.UseVisualStyleBackColor = true;
            this.RemoveWordButton.Click += new System.EventHandler(this.RemoveWordButton_Click);
            // 
            // NamePrecedesLanguageLabel
            // 
            this.NamePrecedesLanguageLabel.AutoSize = true;
            this.NamePrecedesLanguageLabel.BackColor = System.Drawing.Color.White;
            this.NamePrecedesLanguageLabel.Location = new System.Drawing.Point(363, 190);
            this.NamePrecedesLanguageLabel.Name = "NamePrecedesLanguageLabel";
            this.NamePrecedesLanguageLabel.Size = new System.Drawing.Size(290, 18);
            this.NamePrecedesLanguageLabel.TabIndex = 14;
            this.NamePrecedesLanguageLabel.Text = "Please enter a name before adding languages!";
            this.NamePrecedesLanguageLabel.Visible = false;
            // 
            // PracticeTab
            // 
            this.PracticeTab.BackColor = System.Drawing.Color.Thistle;
            this.PracticeTab.Controls.Add(this.NoWordsLabel);
            this.PracticeTab.Controls.Add(this.LatestSessionLabel);
            this.PracticeTab.Controls.Add(this.SessionInfoLabel);
            this.PracticeTab.Controls.Add(this.CorrectOrNotLabel);
            this.PracticeTab.Controls.Add(this.TranslateThisLabel);
            this.PracticeTab.Controls.Add(this.UserTranslationBox);
            this.PracticeTab.Controls.Add(this.TranslateFromXToYLabel);
            this.PracticeTab.Controls.Add(this.NextButton);
            this.PracticeTab.Controls.Add(this.NoPeekingLabel);
            this.PracticeTab.Controls.Add(this.PracticeLabel);
            this.PracticeTab.Controls.Add(this.PracticeButton);
            this.PracticeTab.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PracticeTab.ForeColor = System.Drawing.SystemColors.GrayText;
            this.PracticeTab.Location = new System.Drawing.Point(4, 25);
            this.PracticeTab.Name = "PracticeTab";
            this.PracticeTab.Padding = new System.Windows.Forms.Padding(3);
            this.PracticeTab.Size = new System.Drawing.Size(871, 456);
            this.PracticeTab.TabIndex = 1;
            this.PracticeTab.Text = "Practice";
            // 
            // NoWordsLabel
            // 
            this.NoWordsLabel.AutoSize = true;
            this.NoWordsLabel.Location = new System.Drawing.Point(359, 187);
            this.NoWordsLabel.Name = "NoWordsLabel";
            this.NoWordsLabel.Size = new System.Drawing.Size(126, 18);
            this.NoWordsLabel.TabIndex = 25;
            this.NoWordsLabel.Text = "Contains no words.";
            this.NoWordsLabel.Visible = false;
            // 
            // LatestSessionLabel
            // 
            this.LatestSessionLabel.AutoSize = true;
            this.LatestSessionLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LatestSessionLabel.Location = new System.Drawing.Point(649, 31);
            this.LatestSessionLabel.Name = "LatestSessionLabel";
            this.LatestSessionLabel.Size = new System.Drawing.Size(102, 18);
            this.LatestSessionLabel.TabIndex = 24;
            this.LatestSessionLabel.Text = "Latest session:";
            this.LatestSessionLabel.Visible = false;
            // 
            // SessionInfoLabel
            // 
            this.SessionInfoLabel.AutoSize = true;
            this.SessionInfoLabel.Location = new System.Drawing.Point(649, 50);
            this.SessionInfoLabel.Name = "SessionInfoLabel";
            this.SessionInfoLabel.Size = new System.Drawing.Size(96, 18);
            this.SessionInfoLabel.TabIndex = 23;
            this.SessionInfoLabel.Text = "<sessionInfo>";
            this.SessionInfoLabel.Visible = false;
            // 
            // CorrectOrNotLabel
            // 
            this.CorrectOrNotLabel.AutoSize = true;
            this.CorrectOrNotLabel.Location = new System.Drawing.Point(395, 345);
            this.CorrectOrNotLabel.Name = "CorrectOrNotLabel";
            this.CorrectOrNotLabel.Size = new System.Drawing.Size(132, 18);
            this.CorrectOrNotLabel.TabIndex = 22;
            this.CorrectOrNotLabel.Text = "Correct or Incorrect!";
            this.CorrectOrNotLabel.Visible = false;
            // 
            // TranslateThisLabel
            // 
            this.TranslateThisLabel.AutoSize = true;
            this.TranslateThisLabel.Location = new System.Drawing.Point(398, 246);
            this.TranslateThisLabel.Name = "TranslateThisLabel";
            this.TranslateThisLabel.Size = new System.Drawing.Size(59, 18);
            this.TranslateThisLabel.TabIndex = 21;
            this.TranslateThisLabel.Text = "<word>";
            this.TranslateThisLabel.Visible = false;
            // 
            // UserTranslationBox
            // 
            this.UserTranslationBox.Location = new System.Drawing.Point(320, 285);
            this.UserTranslationBox.Name = "UserTranslationBox";
            this.UserTranslationBox.Size = new System.Drawing.Size(132, 24);
            this.UserTranslationBox.TabIndex = 20;
            this.UserTranslationBox.Visible = false;
            this.UserTranslationBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserTranslationBox_KeyPress);
            // 
            // TranslateFromXToYLabel
            // 
            this.TranslateFromXToYLabel.AutoSize = true;
            this.TranslateFromXToYLabel.Location = new System.Drawing.Point(309, 205);
            this.TranslateFromXToYLabel.Name = "TranslateFromXToYLabel";
            this.TranslateFromXToYLabel.Size = new System.Drawing.Size(144, 18);
            this.TranslateFromXToYLabel.TabIndex = 19;
            this.TranslateFromXToYLabel.Text = "Translate this to that...";
            this.TranslateFromXToYLabel.Visible = false;
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(465, 286);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 18;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Visible = false;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // NoPeekingLabel
            // 
            this.NoPeekingLabel.AutoSize = true;
            this.NoPeekingLabel.Location = new System.Drawing.Point(3, 7);
            this.NoPeekingLabel.Name = "NoPeekingLabel";
            this.NoPeekingLabel.Size = new System.Drawing.Size(177, 18);
            this.NoPeekingLabel.TabIndex = 17;
            this.NoPeekingLabel.Text = "No peeking during practice!";
            this.NoPeekingLabel.Visible = false;
            // 
            // PracticeLabel
            // 
            this.PracticeLabel.AutoSize = true;
            this.PracticeLabel.Location = new System.Drawing.Point(311, 96);
            this.PracticeLabel.Name = "PracticeLabel";
            this.PracticeLabel.Padding = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.PracticeLabel.Size = new System.Drawing.Size(234, 18);
            this.PracticeLabel.TabIndex = 16;
            this.PracticeLabel.Text = "No wordlist selected.";
            this.PracticeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NoPeekingLabelTimer
            // 
            this.NoPeekingLabelTimer.Interval = 4000;
            this.NoPeekingLabelTimer.Tick += new System.EventHandler(this.NoPeekingLabelTimer_Tick);
            // 
            // CorrectOrNotTimer
            // 
            this.CorrectOrNotTimer.Interval = 4000;
            this.CorrectOrNotTimer.Tick += new System.EventHandler(this.CorrectOrNotTimer_Tick);
            // 
            // NamePrecedesLanguageTimer
            // 
            this.NamePrecedesLanguageTimer.Interval = 4000;
            this.NamePrecedesLanguageTimer.Tick += new System.EventHandler(this.NamePrecedesLanguageTimer_Tick);
            // 
            // NoWordsTimer
            // 
            this.NoWordsTimer.Interval = 4000;
            this.NoWordsTimer.Tick += new System.EventHandler(this.NoWordsTimer_Tick);
            // 
            // VocabularyTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 508);
            this.Controls.Add(this.TabControl);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "VocabularyTestForm";
            this.Text = "VocabularyTest";
            ((System.ComponentModel.ISupportInitialize)(this.WordListGrid)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.ListLabTab.ResumeLayout(false);
            this.ListLabTab.PerformLayout();
            this.PracticeTab.ResumeLayout(false);
            this.PracticeTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListNamesBox;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button DuplicateButton;
        private System.Windows.Forms.DataGridView WordListGrid;
        private System.Windows.Forms.Button AddLanguageButton;
        private System.Windows.Forms.Label NewLanguageLabel;
        private System.Windows.Forms.TextBox NewLanguageBox;
        private System.Windows.Forms.Label NumWordsLabel;
        private System.Windows.Forms.Label ActualNumWordsLabel;
        private System.Windows.Forms.Button PracticeButton;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage ListLabTab;
        private System.Windows.Forms.TabPage PracticeTab;
        private System.Windows.Forms.Label PracticeLabel;
        private System.Windows.Forms.Label NoPeekingLabel;
        private System.Windows.Forms.Timer NoPeekingLabelTimer;
        private System.Windows.Forms.TextBox UserTranslationBox;
        private System.Windows.Forms.Label TranslateFromXToYLabel;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label TranslateThisLabel;
        private System.Windows.Forms.Label CorrectOrNotLabel;
        private System.Windows.Forms.Timer CorrectOrNotTimer;
        private System.Windows.Forms.Label SessionInfoLabel;
        private System.Windows.Forms.Label LatestSessionLabel;
        private System.Windows.Forms.Label NamePrecedesLanguageLabel;
        private System.Windows.Forms.Timer NamePrecedesLanguageTimer;
        private System.Windows.Forms.Button RemoveWordButton;
        private System.Windows.Forms.Label NoWordsLabel;
        private System.Windows.Forms.Timer NoWordsTimer;
    }
}

