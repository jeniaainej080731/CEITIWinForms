using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Main : Form
    {
        private System.Windows.Forms.Timer infoToolTipTimer;
        private string originalText;
        private float originalWidth, originalHeight;
        private Dictionary<Control, Rectangle> controlOriginalSizes = new Dictionary<Control, Rectangle>();
        private Dictionary<Control, float> controlOriginalFonts = new Dictionary<Control, float>();

        public Main()
        {
            InitializeComponent();
            SetTimerForToolTip();
            SetToolTips();
            SetRescaling(); // понятия не имел как нормально сделать масштабирование 
                            // психанул и сделал через чат
        }

        public void SetRescaling()
        {
            this.Resize += Main_Resize;
            originalWidth = this.ClientSize.Width;
            originalHeight = this.ClientSize.Height;
            SaveOriginalSizes(this);
        }

        private void SaveOriginalSizes(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                controlOriginalSizes[control] = new Rectangle(control.Left, control.Top, control.Width, control.Height);
                controlOriginalFonts[control] = control.Font.Size;

                if (control.Controls.Count > 0)
                {
                    SaveOriginalSizes(control);
                }
            }
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            float scaleX = this.ClientSize.Width / originalWidth;
            float scaleY = this.ClientSize.Height / originalHeight;

            ResizeControls(this, scaleX, scaleY);
        }

        private void ResizeControls(Control parent, float scaleX, float scaleY)
        {
            foreach (Control control in parent.Controls)
            {
                if (controlOriginalSizes.ContainsKey(control))
                {
                    Rectangle originalRect = controlOriginalSizes[control];

                    control.Left = (int)(originalRect.Left * scaleX);
                    control.Top = (int)(originalRect.Top * scaleY);
                    control.Width = (int)(originalRect.Width * scaleX);
                    control.Height = (int)(originalRect.Height * scaleY);
                    control.Font = new Font(control.Font.FontFamily, controlOriginalFonts[control] * Math.Min(scaleX, scaleY));
                }

                if (control.Controls.Count > 0)
                {
                    ResizeControls(control, scaleX, scaleY);
                }
            }
        }

        private void SetTimerForToolTip()
        {
            infoToolTipTimer = new System.Windows.Forms.Timer
            {
                Interval = 2000
            };
            infoToolTipTimer.Tick += OnInfoToolTipTimerTick;
        }

        private void SetToolTips()
        {
            InfoToolTip.SetToolTip(FormattingButton, "Formats the text based on the selected option.");
            InfoToolTip.SetToolTip(CalculateButton, "Calculates the total number of words in the text.");
            InfoToolTip.SetToolTip(DeletingSpacesCheckBox, "Removes all spaces from the text when checked.");
            InfoToolTip.SetToolTip(DeleteSpacesButton, "Removes extra spaces from the text.");
            InfoToolTip.SetToolTip(CodingCheckBox, "Replaces 'c' with 'e' in the text when checked.");
            InfoToolTip.SetToolTip(DeleteRadioButton, "Deletes the text that matches the input.");
            InfoToolTip.SetToolTip(MirrorRadioButton, "Reverses the text that matches the input.");
            InfoToolTip.SetToolTip(FindRepeatsRadioButton, "Counts the number of times the input text is repeated.");
        }

        private void FormattingButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(InputTextBox.Text))
            {
                ShowToolTip("Field can't be empty", InputTextBox);
                return;
            }

            string searchText = InputTextBox.Text.Trim();

            if (DeleteRadioButton.Checked)
            {
                DeleteText(searchText);
            }
            else if (MirrorRadioButton.Checked)
            {
                MirrorText(searchText);
            }
            else if (FindRepeatsRadioButton.Checked)
            {
                CountRepeats(searchText);
            }
        }

        private void DeleteText(string searchText)
        {
            string text = MainTextRichTextBox.Text;
            int textLength = text.Length;
            int searchLength = searchText.Length;
            int startIndex = 0;

            while ((startIndex = text.IndexOf(searchText, startIndex)) != -1)
            {
                bool leftBoundary = startIndex == 0 || char.IsWhiteSpace(text[startIndex - 1]);
                bool rightBoundary = (startIndex + searchLength >= textLength) || char.IsWhiteSpace(text[startIndex + searchLength]);

                if (leftBoundary && rightBoundary)
                {
                    MainTextRichTextBox.Select(startIndex, searchLength);
                    MainTextRichTextBox.SelectedText = string.Empty;
                    text = MainTextRichTextBox.Text;
                    textLength = text.Length;
                }
                else
                {
                    startIndex += searchLength;
                }
            }
        }


        private void MirrorText(string searchText)
        {
            string text = MainTextRichTextBox.Text;
            int textLength = text.Length;
            int searchLength = searchText.Length;
            int startIndex = 0;

            while ((startIndex = text.IndexOf(searchText, startIndex)) != -1)
            {
                bool leftBoundary = startIndex == 0 || char.IsWhiteSpace(text[startIndex - 1]);
                bool rightBoundary = (startIndex + searchLength >= textLength) || char.IsWhiteSpace(text[startIndex + searchLength]);

                if (leftBoundary && rightBoundary)
                {
                    MainTextRichTextBox.Select(startIndex, searchLength);
                    MainTextRichTextBox.SelectedText = Reverse(searchText);
                    text = MainTextRichTextBox.Text;
                    textLength = text.Length;
                }
                else
                {
                    startIndex += searchLength;
                }
            }
        }

        private void CountRepeats(string searchText)
        {
            int count = 0;
            string text = MainTextRichTextBox.Text;
            int textLength = text.Length;
            int searchLength = searchText.Length;

            for (int i = 0; i <= textLength - searchLength; i++)
            {
                if (text.Substring(i, searchLength) == searchText)
                {
                    bool leftBoundary = i == 0 || char.IsWhiteSpace(text[i - 1]);
                    bool rightBoundary = i + searchLength == textLength || char.IsWhiteSpace(text[i + searchLength]);

                    if (leftBoundary && rightBoundary)
                    {
                        count++;
                    }
                }
            }

            MessageBox.Show(
                $"Count repeats: {count}",
                "Result",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void OnInfoToolTipTimerTick(object sender, EventArgs e)
        {
            InfoToolTip.Hide(InputTextBox);
            infoToolTipTimer.Stop();
        }

        private void ShowToolTip(string message, Control control)
        {
            InfoToolTip.Show(message, control, 0, -20);
            infoToolTipTimer.Start();
        }

        private void InputTextBox_TextChanged(object sender, EventArgs e)
        {
            HighlightText(InputTextBox.Text);
        }

        private void HighlightText(string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText))
            {
                MainTextRichTextBox.SelectAll();
                MainTextRichTextBox.SelectionColor = Color.Black;
                return; //-
            }

            int startIndex = 0;
            MainTextRichTextBox.SelectAll();
            MainTextRichTextBox.SelectionColor = Color.Black;

            while ((startIndex = MainTextRichTextBox.Text.IndexOf(searchText, startIndex, StringComparison.OrdinalIgnoreCase)) != -1)
            {
                MainTextRichTextBox.Select(startIndex, searchText.Length);
                MainTextRichTextBox.SelectionColor = Color.Red;
                startIndex += searchText.Length;
            }
        }

        public string Reverse(string text)
        {
            char[] array = text.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            int wordCount = CountWords(MainTextRichTextBox.Text);
            CountOfWordsLabel.Text = $"Total words: {wordCount}";
        }

        private int CountWords(string text)
        {
            if (string.IsNullOrWhiteSpace(text)) return 0;

            string[] words = text.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }

        private void DeletingSpacesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (DeletingSpacesCheckBox.Checked)
            {
                originalText = MainTextRichTextBox.Text;
                MainTextRichTextBox.Text = MainTextRichTextBox.Text.Replace(" ", "");
            }
            else
            {
                MainTextRichTextBox.Text = originalText;
            }
        }

        private void DeleteSpacesButton_Click(object sender, EventArgs e)
        {
            string text = MainTextRichTextBox.Text.Trim();
            MainTextRichTextBox.Text = string.Join(" ", text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
        }

        private void CodingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CodingCheckBox.Checked)
            {
                originalText = MainTextRichTextBox.Text;
                MainTextRichTextBox.Text = new string(originalText.Select(ch => (char)(ch + 2)).ToArray());
            }
            else
            {
                MainTextRichTextBox.Text = originalText;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            DeleteSpacesButton.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void DeleteSpacesLabel_Click(object sender, EventArgs e)
        {
            string text = MainTextRichTextBox.Text.Trim();
            MainTextRichTextBox.Text = string.Join(" ", text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
        }
    }
}
