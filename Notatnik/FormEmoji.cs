using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notatnik
{
    public partial class FormEmoji : Form
    {
        public event Action<string> EmojiWybrane;
        public FormEmoji()
        {
            InitializeComponent();
            DodajEmoji();
        }
        private void DodajEmoji()
        {
            string[] emojiLista = new string[]
            {
            "😀", "😂", "😍", "😎", "😭",
            "👍", "👎", "❤️", "🔥", "💡",
            "🎉", "📌", "📝", "✅", "❌"
            };

            int rozmiar = 40;
            int kolumny = 5;

            for (int i = 0; i < emojiLista.Length; i++)
            {
                Button btn = new Button();
                btn.Text = emojiLista[i];
                btn.Font = new Font("Segoe UI Emoji", 18);
                btn.Size = new Size(rozmiar, rozmiar);
                btn.Location = new Point((i % kolumny) * rozmiar, (i / kolumny) * rozmiar);
                btn.Click += (s, e) =>
                {
                    EmojiWybrane?.Invoke(btn.Text);
                    this.Close();
                };
                this.Controls.Add(btn);
            }

            this.ClientSize = new Size(rozmiar * kolumny, ((emojiLista.Length + kolumny - 1) / kolumny) * rozmiar);
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.StartPosition = FormStartPosition.Manual;
            this.Text = "Emoji";
        }
    }
}
