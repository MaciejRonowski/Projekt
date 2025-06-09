namespace Notatnik
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otwórzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drukujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zmieńCzcionkęToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zmieńKolorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edycjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cofnijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ponówToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wstawEmojiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyglądToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trybJasnyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trybCiemnyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.textBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.edycjaToolStripMenuItem,
            this.wyglądToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowyToolStripMenuItem,
            this.otwórzToolStripMenuItem,
            this.zapiszToolStripMenuItem,
            this.drukujToolStripMenuItem,
            this.zakończToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // nowyToolStripMenuItem
            // 
            this.nowyToolStripMenuItem.Name = "nowyToolStripMenuItem";
            this.nowyToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.nowyToolStripMenuItem.Text = "Nowy";
            this.nowyToolStripMenuItem.Click += new System.EventHandler(this.nowyToolStripMenuItem_Click);
            // 
            // otwórzToolStripMenuItem
            // 
            this.otwórzToolStripMenuItem.Name = "otwórzToolStripMenuItem";
            this.otwórzToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.otwórzToolStripMenuItem.Text = "Otwórz";
            this.otwórzToolStripMenuItem.Click += new System.EventHandler(this.otwórzToolStripMenuItem_Click);
            // 
            // zapiszToolStripMenuItem
            // 
            this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.zapiszToolStripMenuItem.Text = "Zapisz";
            this.zapiszToolStripMenuItem.Click += new System.EventHandler(this.zapiszToolStripMenuItem_Click);
            // 
            // drukujToolStripMenuItem
            // 
            this.drukujToolStripMenuItem.Name = "drukujToolStripMenuItem";
            this.drukujToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.drukujToolStripMenuItem.Text = "Drukuj";
            this.drukujToolStripMenuItem.Click += new System.EventHandler(this.drukujToolStripMenuItem_Click);
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.zakończToolStripMenuItem.Text = "Zakończ";
            this.zakończToolStripMenuItem.Click += new System.EventHandler(this.zakończToolStripMenuItem_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zmieńCzcionkęToolStripMenuItem,
            this.zmieńKolorToolStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.formatToolStripMenuItem.Text = "Format";
            // 
            // zmieńCzcionkęToolStripMenuItem
            // 
            this.zmieńCzcionkęToolStripMenuItem.Name = "zmieńCzcionkęToolStripMenuItem";
            this.zmieńCzcionkęToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.zmieńCzcionkęToolStripMenuItem.Text = "Zmień czcionkę";
            this.zmieńCzcionkęToolStripMenuItem.Click += new System.EventHandler(this.zmieńCzcionkęToolStripMenuItem_Click);
            // 
            // zmieńKolorToolStripMenuItem
            // 
            this.zmieńKolorToolStripMenuItem.Name = "zmieńKolorToolStripMenuItem";
            this.zmieńKolorToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.zmieńKolorToolStripMenuItem.Text = "Zmień kolor";
            this.zmieńKolorToolStripMenuItem.Click += new System.EventHandler(this.zmieńKolorToolStripMenuItem_Click);
            // 
            // edycjaToolStripMenuItem
            // 
            this.edycjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cofnijToolStripMenuItem,
            this.ponówToolStripMenuItem,
            this.wstawEmojiToolStripMenuItem});
            this.edycjaToolStripMenuItem.Name = "edycjaToolStripMenuItem";
            this.edycjaToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.edycjaToolStripMenuItem.Text = "Edycja";
            // 
            // cofnijToolStripMenuItem
            // 
            this.cofnijToolStripMenuItem.Name = "cofnijToolStripMenuItem";
            this.cofnijToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.cofnijToolStripMenuItem.Text = "Cofnij";
            this.cofnijToolStripMenuItem.Click += new System.EventHandler(this.cofnijToolStripMenuItem_Click);
            // 
            // ponówToolStripMenuItem
            // 
            this.ponówToolStripMenuItem.Name = "ponówToolStripMenuItem";
            this.ponówToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.ponówToolStripMenuItem.Text = "Ponów";
            this.ponówToolStripMenuItem.Click += new System.EventHandler(this.ponówToolStripMenuItem_Click);
            // 
            // wstawEmojiToolStripMenuItem
            // 
            this.wstawEmojiToolStripMenuItem.Name = "wstawEmojiToolStripMenuItem";
            this.wstawEmojiToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.wstawEmojiToolStripMenuItem.Text = "Wstaw emoji";
            this.wstawEmojiToolStripMenuItem.Click += new System.EventHandler(this.wstawEmojiToolStripMenuItem_Click);
            // 
            // wyglądToolStripMenuItem
            // 
            this.wyglądToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trybJasnyToolStripMenuItem,
            this.trybCiemnyToolStripMenuItem});
            this.wyglądToolStripMenuItem.Name = "wyglądToolStripMenuItem";
            this.wyglądToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.wyglądToolStripMenuItem.Text = "Wygląd";
            // 
            // trybJasnyToolStripMenuItem
            // 
            this.trybJasnyToolStripMenuItem.Name = "trybJasnyToolStripMenuItem";
            this.trybJasnyToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.trybJasnyToolStripMenuItem.Text = "Tryb jasny";
            this.trybJasnyToolStripMenuItem.Click += new System.EventHandler(this.trybJasnyToolStripMenuItem_Click);
            // 
            // trybCiemnyToolStripMenuItem
            // 
            this.trybCiemnyToolStripMenuItem.Name = "trybCiemnyToolStripMenuItem";
            this.trybCiemnyToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.trybCiemnyToolStripMenuItem.Text = "Tryb ciemny";
            this.trybCiemnyToolStripMenuItem.Click += new System.EventHandler(this.trybCiemnyToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 16);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(800, 400);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Notatnik";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otwórzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zmieńCzcionkęToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zmieńKolorToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem edycjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cofnijToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ponówToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyglądToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trybJasnyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trybCiemnyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drukujToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ToolStripMenuItem wstawEmojiToolStripMenuItem;
        private System.Windows.Forms.RichTextBox textBox1;
    }
}

