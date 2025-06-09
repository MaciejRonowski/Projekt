using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notatnik
{
    public partial class Form1 : Form
    { 
       
        private void UstawTrybJasny()
        { //do ustawiania trybu jasnego
            this.BackColor = Color.White;

            textBox1.BorderStyle = BorderStyle.None;
            textBox1.BackColor = Color.White;
            textBox1.ForeColor = Color.Black;

            menuStrip1.BackColor = SystemColors.Control;
            menuStrip1.ForeColor = Color.Black;

            statusStrip1.BackColor = SystemColors.Control;
            statusStrip1.ForeColor = Color.Black;

            // Zapamiętaj zaznaczenie użytkownika
            int selStart = textBox1.SelectionStart;
            int selLength = textBox1.SelectionLength;

            // Zastosuj styl do całego tekstu
            textBox1.SelectAll();
            textBox1.SelectionFont = new Font("Segoe UI Emoji", 12);
            textBox1.SelectionColor = Color.Black;
            textBox1.SelectionBackColor = Color.White;

            // Przywróć zaznaczenie użytkownika
            textBox1.SelectionStart = selStart;
            textBox1.SelectionLength = selLength;

            textBox1.Refresh();
        }

        private void UstawTrybCiemny()
        { //do ustawiania trybu ciemnego
            this.BackColor = Color.FromArgb(30, 30, 30);

            textBox1.BorderStyle = BorderStyle.None;
            textBox1.BackColor = Color.FromArgb(45, 45, 45);
            textBox1.ForeColor = Color.White;

            menuStrip1.BackColor = Color.FromArgb(40, 40, 40);
            menuStrip1.ForeColor = Color.White;

            statusStrip1.BackColor = Color.FromArgb(40, 40, 40);
            statusStrip1.ForeColor = Color.White;

            // Zapamiętaj zaznaczenie użytkownika
            int selStart = textBox1.SelectionStart;
            int selLength = textBox1.SelectionLength;

            // Zastosuj styl do całego tekstu
            textBox1.SelectAll();
            textBox1.SelectionFont = new Font("Segoe UI Emoji", 12);
            textBox1.SelectionColor = Color.White;
            textBox1.SelectionBackColor = Color.FromArgb(45, 45, 45);

            // Przywróć zaznaczenie użytkownika
            textBox1.SelectionStart = selStart;
            textBox1.SelectionLength = selLength;

            textBox1.Refresh();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void nowyToolStripMenuItem_Click(object sender, EventArgs e)
        { //nowy plik
            textBox1.Clear();
        }

        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        { //funkcja otwierania plików
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Pliki tekstowe (*.txt)|*.txt|Wszystkie pliki (*.*)|*.*";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(openFile.FileName);
            }
        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //zapisywanie
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Pliki tekstowe (*.txt)|*.txt";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFile.FileName, textBox1.Text);
            }
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //zamknięcie aplikacji
            Application.Exit();
        }

        private void zmieńCzcionkęToolStripMenuItem_Click(object sender, EventArgs e)
        { //zmiana czcionki
            FontDialog fontDialog = new FontDialog();
            fontDialog.Font = textBox1.SelectionFont ?? textBox1.Font;
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.SelectionFont = fontDialog.Font;
            }
        }

        private void zmieńKolorToolStripMenuItem_Click(object sender, EventArgs e)
        { //zmiana koloru tekstu
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.SelectionColor = colorDialog.Color;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int znaki = textBox1.Text.Length;

            int slowa = textBox1.Text
                .Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Length;

            int linie = textBox1.Lines.Length;

            toolStripStatusLabel1.Text = $"Znaki: {znaki} | Słowa: {slowa} | Linie: {linie}";
        }
        private void cofnijToolStripMenuItem_Click(object sender, EventArgs e)
        { //funkcja cofnij
            if (textBox1.CanUndo)
            {
                textBox1.Undo();
            }
        }
        private void ponówToolStripMenuItem_Click(object sender, EventArgs e)
        { //funkcja ponów
            if (textBox1.CanRedo)
            {
                textBox1.Redo();
            }
        }

        private void trybJasnyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UstawTrybJasny();
        }

        private void trybCiemnyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UstawTrybCiemny();
        }

        private void drukujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //funkcja drukowania
            PrintDialog pd = new PrintDialog();
            pd.Document = printDocument1;

            if (pd.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string text = textBox1.Text;
            Font font = textBox1.Font;

            // Wydruk tekstu
            e.Graphics.DrawString(text, font, Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top);
        }

        private void wstawEmojiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEmoji emojiOkno = new FormEmoji();
            var pozycjaOkna = this.Location;
            pozycjaOkna.Offset(100, 100);
            emojiOkno.StartPosition = FormStartPosition.Manual;
            emojiOkno.Location = pozycjaOkna;

            emojiOkno.EmojiWybrane += (emoji) =>
            {
                textBox1.SelectedText = emoji;
            };

            emojiOkno.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UstawTrybJasny();
        }
    }
    
}
