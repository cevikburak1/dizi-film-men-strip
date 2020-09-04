using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menu_strip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;

        }

        private void siyahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }

        private void kırmızıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkRed;
        }

        private void yeşilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkGreen;
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu Proje BURAK ÇEVİK tarafından hazırlandı ", "Bilgi", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sealTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=uJimSNynQqc");
            label1.Text = "HARİKA DİZİ HARİKA ";
            label1.BackColor = Color.Yellow;
            label1.Enabled = true;
            this.BackColor = Color.Black;
                
        }

        private void romantikKomedi2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=p58JgCWRjzg");
            label1.Text = "ÇÖP BU";
            label1.BackColor = Color.Yellow;
            label1.Enabled = true;
            this.BackColor = Color.Black;
        }

        private void korkuSeansıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=hunXjEN-09E");
            label1.Text = "İDARE EDER  ";
            label1.BackColor = Color.Yellow;
            label1.Enabled = true;
            this.BackColor = Color.Black;
        }

        private void treansformersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=g-NQ0FWUPEA");
            label1.Text = "5. ÇÖP İLK 4 Ü GÜZELDİ ";
            label1.BackColor = Color.Yellow;
            label1.Enabled = true;
            this.BackColor = Color.Black;
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
