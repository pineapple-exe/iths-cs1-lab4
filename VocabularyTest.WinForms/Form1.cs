using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace VocabularyTest.WinForms
{
    public partial class Form1 : Form
    {
        private static LatestSession latestSession;
        private static bool PracticeMode;
        private string CorrectTranslation;

        public Form1()
        {
            InitializeComponent();
            WordListUtils.FolderCheck();
            RefreshListNamesBox();
        }

        private void RefreshListNamesBox()
        {
            ListNamesBox.Items.Clear();
            ListNamesBox.Items.AddRange(WordList.GetLists());
        }

        private void ShowNumberOfWords()
        {
            if ((WordListGrid.Rows.Count - 1) <= 0)
            {
                ActualNumWordsLabel.Text = "0";
            }
            else
            {
                ActualNumWordsLabel.Text = (WordListGrid.Rows.Count - 1).ToString();
            }
        }

        private void ClearGridAndName()
        {
            WordListGrid.Rows.Clear();
            WordListGrid.Columns.Clear();
            NameBox.Text = null;
        }

        private void RefreshPracticeLabel()
        {
            if (ListNamesBox.SelectedItem != null)
            {
                PracticeLabel.Text = $"Selected: {ListNamesBox.SelectedItem}";
                return;
            }
            PracticeLabel.Text = "No wordlist selected.";
        }

        private void PracticeModeAppearance()
        {
            TranslateFromXToYLabel.Visible = PracticeMode;
            TranslateThisLabel.Visible = PracticeMode;
            UserTranslationBox.Visible = PracticeMode;
            NextButton.Visible = PracticeMode;

            if (PracticeMode)
            {
                PracticeButton.Text = "Stop";
            }
            else
            {
                PracticeButton.Text = "Start";
            }
        }

        private void Practice()
        {
            if (PracticeMode)
            {
                PracticeModeAppearance();

                WordList listToPractice = WordList.LoadList(ListNamesBox.Text);
                Word wordOfPractice = listToPractice.GetWordToPractice();
                string fromLanguage = listToPractice.Languages[wordOfPractice.FromLanguage];
                string toLanguage = listToPractice.Languages[wordOfPractice.ToLanguage];

                CorrectTranslation = wordOfPractice.Translations[wordOfPractice.ToLanguage];

                TranslateFromXToYLabel.Text = $"Translate from {fromLanguage} to {toLanguage}.";
                TranslateThisLabel.Text = wordOfPractice.Translations[wordOfPractice.FromLanguage];
            }
        }

        private void CorrectOrNot(bool goodGirl)
        {
            if (goodGirl)
            {
                CorrectOrNotLabel.Text = "Correct!";
                latestSession.Score++;
            }
            else
            {
                CorrectOrNotLabel.Text = "Incorrect!";
            }
            CorrectOrNotLabel.Visible = true;
            CorrectOrNotTimer.Enabled = true;
            UserTranslationBox.Text = null;
        }

        private void SessionInfo()
        {
            if (PracticeMode)
            {
                SessionInfoLabel.Visible = true;
                SessionInfoLabel.Text = $"Words practiced: {latestSession.PracticedWords}";
            }
            else if (!PracticeMode && latestSession != null)
            {
                string n = Environment.NewLine;

                LatestSessionLabel.Visible = true;
                LatestSessionLabel.Text = "Latest session:";

                SessionInfoLabel.Visible = true;
                SessionInfoLabel.Text = $"List: {latestSession.Name} {n}Words practiced: {latestSession.PracticedWords} {n}Score: {latestSession.Score}";
            }
        }

        private void ContinuePractice()
        {
            latestSession.PracticedWords++;
            CorrectOrNot(UserTranslationBox.Text.ToLower() == CorrectTranslation.ToLower());
            SessionInfo();
            Practice();
        }

        private bool IsRowEmpty(DataGridViewRow row)
        {
            foreach (DataGridViewTextBoxCell cell in row.Cells)
            {
                if (!string.IsNullOrEmpty(cell.Value?.ToString()))
                {
                    return false;
                }
            }
            return true;
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            ClearGridAndName();
            ShowNumberOfWords();
        }

        private void ListNamesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListNamesBox.SelectedItem != null)
            {
                ClearGridAndName();
                PracticeButton.Enabled = true;

                NameBox.Text = ListNamesBox.SelectedItem.ToString();

                WordList selectedWList = WordList.LoadList(NameBox.Text);

                foreach (string language in selectedWList.Languages)
                {
                    WordListGrid.Columns.Add(language, language);
                }

                List<string[]> words = new List<string[]>();
                selectedWList.List(0, t => words.Add(t));

                foreach (string[] translations in words)
                {
                    WordListGrid.Rows.Add(translations);
                }

                ShowNumberOfWords();
                RefreshPracticeLabel();
            }
        }

        private void DuplicateButton_Click(object sender, EventArgs e)
        {
            string oldPath = WordListUtils.GeneratePath(ListNamesBox.SelectedItem.ToString());
            string originalContent = File.ReadAllText(oldPath);

            string nameSuffix = "_copy";
            int copyCount = 1;
            
            while (File.Exists(WordListUtils.GeneratePath(ListNamesBox.SelectedItem + nameSuffix)))
            {
                copyCount++;
                nameSuffix = "_copy" + copyCount;
            }

            string newPath = WordListUtils.GeneratePath(ListNamesBox.SelectedItem + nameSuffix);
            File.WriteAllText(newPath, originalContent);

            RefreshListNamesBox();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            List<string> languages = new List<string>();
            foreach (DataGridViewTextBoxColumn column in WordListGrid.Columns)
            {
                languages.Add(column.HeaderText);
            }

            WordList currentList = new WordList(NameBox.Text, languages.ToArray());
            List<string> translations = new List<string>();

            foreach (DataGridViewRow row in WordListGrid.Rows)
            {
                if (IsRowEmpty(row))
                {
                    continue;
                }

                foreach (DataGridViewTextBoxCell cell in row.Cells)
                {
                    translations.Add(cell.Value?.ToString() ?? "");
                }

                if (translations.Any(t => String.IsNullOrWhiteSpace(t)))
                {
                    string n = Environment.NewLine;
                    MessageBox.Show($"Could not save list.{n+n}Symmetry required between number of translations and number of languages.");
                    return;
                }
                currentList.Add(translations.ToArray());
                translations.Clear();
            }
            currentList.Save();
            RefreshListNamesBox();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (ListNamesBox.SelectedItem != null)
            {
                DialogResult yesOrNo = MessageBox.Show("Are you sure you want to delete this list?", "Delete wordlist", MessageBoxButtons.YesNo);
                if (yesOrNo == DialogResult.Yes)
                {
                    File.Delete(WordListUtils.GeneratePath(ListNamesBox.SelectedItem.ToString()));
                    RefreshListNamesBox();
                    ClearGridAndName();
                    RefreshPracticeLabel();
                }
            }
        }

        private void AddLanguageButton_Click(object sender, EventArgs e)
        {
            if (NewLanguageBox.Text != "")
            {
                if (NameBox.Text == "")
                {
                    NamePrecedesLanguageLabel.Visible = true;
                    NamePrecedesLanguageTimer.Enabled = true;
                    return;
                }
                WordListGrid.Columns.Add(NewLanguageBox.Text, NewLanguageBox.Text);
                NewLanguageBox.Text = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PracticeButton_Click(object sender, EventArgs e)
        {
            if (WordList.LoadList(ListNamesBox.SelectedItem.ToString()).Count() < 2)
            {
                NoWordsLabel.Visible = true;
                NoWordsTimer.Enabled = true;
                return;
            }

            if (PracticeMode)
            {
                PracticeMode = false;
                PracticeButton.Text = "Start";
                PracticeModeAppearance();
            }
            else
            {
                latestSession = new LatestSession(ListNamesBox.Text);
                PracticeMode = true;
                PracticeButton.Text = "Stop";
                Practice();
            }
            SessionInfo();
        }

        private void TabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (PracticeMode == true)
            {
                e.Cancel = true;
                NoPeekingLabel.Visible = true;
                NoPeekingLabelTimer.Enabled = true;
            }
        }

        private void NoPeekingLabelTimer_Tick(object sender, EventArgs e)
        {
            NoPeekingLabel.Visible = false;
            NoPeekingLabelTimer.Enabled = false;
        }

        private void CorrectOrNotTimer_Tick(object sender, EventArgs e)
        {
            CorrectOrNotLabel.Visible = false;
            CorrectOrNotTimer.Enabled = false;
        }

        private void NamePrecedesLanguageTimer_Tick(object sender, EventArgs e)
        {
            NamePrecedesLanguageLabel.Visible = false;
            NamePrecedesLanguageTimer.Enabled = false;
        }

        private void NoWordsTimer_Tick(object sender, EventArgs e)
        {
            NoWordsLabel.Visible = false;
            NoWordsTimer.Enabled = false;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            ContinuePractice();
        }

        private void UserTranslationBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                ContinuePractice();
            }
        }

        private void RemoveWordButton_Click(object sender, EventArgs e)
        {
            var rowsToRemove = new List<DataGridViewRow>();

            foreach (DataGridViewRow row in WordListGrid.SelectedRows)
            {
                if (!IsRowEmpty(row))
                {
                    rowsToRemove.Add(row);
                }
            }

            if (rowsToRemove.Count > 0)
            {
                DialogResult yesOrNo = MessageBox.Show("Are you sure you want to remove the selected words?", "Delete words", MessageBoxButtons.YesNo);
                if (yesOrNo == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in rowsToRemove)
                    {
                        WordListGrid.Rows.RemoveAt(row.Index);
                    }
                }
            }
        }
    }
}
