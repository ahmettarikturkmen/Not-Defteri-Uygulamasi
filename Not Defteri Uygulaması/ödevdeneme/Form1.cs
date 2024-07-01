/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2023-2024 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........:1.Ödev
**				ÖĞRENCİ ADI............:Ahmet Tarık Türkmen
**				ÖĞRENCİ NUMARASI.......:G221210087
**              DERSİN ALINDIĞI GRUP...:2.Öğretim C Grubu
****************************************************************************/


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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ödevdeneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kaydetToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "RTF Dosyası|*.rtf|Metin Dosyası|*.txt|C Dosyası|*.c|C++ Dosyası|*.cpp|C# Dosyası|*.cs";
            save.OverwritePrompt = true;
            save.CreatePrompt = true;

            //Kaydetme işlemini gerçekleştirir.
            if (save.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(save.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void açToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Değişiklikleri kaydetmek istiyor musunuz?", "Not Defteri", MessageBoxButtons.YesNoCancel);
            //dosya açmadan önce şuanki dosyayı kaydetmek istiyor musun diye sorar.
            if (result1 == DialogResult.Yes)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "RTF Dosyası|*.rtf|Metin Dosyası|*.txt|C Dosyası|*.c|C++ Dosyası|*.cpp|C# Dosyası|*.cs";
                save.OverwritePrompt = true;
                save.CreatePrompt = true;
                //Kaydetme işlemini gerçekleştirir.
                if (save.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SaveFile(save.FileName, RichTextBoxStreamType.RichText);
                }
            }
            //hayır derse dosya açma diyaloğu açılır.
            else if (result1 == DialogResult.No)
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "RTF Dosyası|*.rtf|Metin Dosyası|*.txt|C Dosyası|*.c|C++ Dosyası|*.cpp|C# Dosyası|*.cs";
                //Dosya açma işlemini gerçekleştirir.
                if (open.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.LoadFile(open.FileName, RichTextBoxStreamType.RichText);
                }
            }
            //iptal derse bir şey olmaz.
            else if (result1 == DialogResult.Cancel)
            {

            }
        }

        private void çıkışToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Değişiklikleri kaydetmek istiyor musunuz?", "Not Defteri", MessageBoxButtons.YesNoCancel);

            if (result1 == DialogResult.Yes)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);

                }
            }
            else if (result1 == DialogResult.No)
            {
                Close();
            }
            else if (result1 == DialogResult.Cancel)
            {

            }
        }

        private void kesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void kopyalaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void yapıştırToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void yazıToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void yazıRengiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.ForeColor = colorDialog1.Color;
        }

        private void arkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.BackColor = colorDialog1.Color;
        }


        private void kesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void kopyalaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void yapıştırToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void renkDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                // Eğer bir metin seçiliyse
                if (richTextBox1.SelectionLength > 0)
                {
                    // Seçili metnin rengini değiştir
                    richTextBox1.SelectionColor = colorDialog1.Color;
                }
                else // Eğer hiçbir metin seçili değilse
                {
                    // Tüm metnin rengini değiştir
                    richTextBox1.ForeColor = colorDialog1.Color;
                }
            }
        }

        private void yazıTipiDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                // Eğer bir metin seçiliyse
                if (richTextBox1.SelectionLength > 0)
                {
                    // Seçili metnin fontunu değiştir
                    richTextBox1.SelectionFont = fontDialog1.Font;
                }
                else // Eğer hiçbir metin seçili değilse
                {
                    // Tüm metnin fontunu değiştir
                    richTextBox1.Font = fontDialog1.Font;
                }
            }
        }

        private void yeniSayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Değişiklikleri kaydetmek istiyor musunuz?", "Not Defteri", MessageBoxButtons.YesNoCancel);
            if (result1 == DialogResult.Yes)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Metin Dosyası|*.txt|C Dosyası|*.c|C++ Dosyası|*.cpp|C# Dosyası|*.cs";
                save.OverwritePrompt = true;
                save.CreatePrompt = true;
                //Kaydetme işlemini gerçekleştirir.
                if (save.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SaveFile(save.FileName, RichTextBoxStreamType.RichText);
                }
            }
            else if (result1 == DialogResult.No)
            {
                richTextBox1.Text = " ";
            }
            else if (result1 == DialogResult.Cancel)
            {

            }
        }

        private void cYeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Değişiklikleri kaydetmek istiyor musunuz?", "Not Defteri", MessageBoxButtons.YesNoCancel);
            if (result1 == DialogResult.Yes)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Metin Dosyası|*.txt|C Dosyası|*.c|C++ Dosyası|*.cpp|C# Dosyası|*.cs";
                save.OverwritePrompt = true;
                save.CreatePrompt = true;
                //Kaydetme işlemini gerçekleştirir.
                if (save.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SaveFile(save.FileName, RichTextBoxStreamType.RichText);
                }
            }
            else if (result1 == DialogResult.No)
            {
                richTextBox1.Text = "#include <stdio.h>\r\n\r\nint main()\r\n{\r\n    printf(\"Hello World\");\r\n\r\n    return 0;\r\n}\r\n ";
            }
            else if (result1 == DialogResult.Cancel)
            {

            }
        }

        private void cPlusPlusYeniToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Değişiklikleri kaydetmek istiyor musunuz?", "Not Defteri", MessageBoxButtons.YesNoCancel);
            if (result1 == DialogResult.Yes)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Metin Dosyası|*.txt|C Dosyası|*.c|C++ Dosyası|*.cpp|C# Dosyası|*.cs";
                save.OverwritePrompt = true;
                save.CreatePrompt = true;
                //Kaydetme işlemini gerçekleştirir.
                if (save.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SaveFile(save.FileName, RichTextBoxStreamType.RichText);
                }
            }
            else if (result1 == DialogResult.No)
            {
                richTextBox1.Text = "#include <iostream>\r\n\r\nint main()\r\n{\r\n    std::cout<<\"Hello World\";\r\n\r\n    return 0;\r\n} ";
            }
            else if (result1 == DialogResult.Cancel)
            {

            }
        }

        private void cSharpYeniToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Değişiklikleri kaydetmek istiyor musunuz?", "Not Defteri", MessageBoxButtons.YesNoCancel);
            if (result1 == DialogResult.Yes)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Metin Dosyası|*.txt|C Dosyası|*.c|C++ Dosyası|*.cpp|C# Dosyası|*.cs";
                save.OverwritePrompt = true;
                save.CreatePrompt = true;
                //Kaydetme işlemini gerçekleştirir.
                if (save.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SaveFile(save.FileName, RichTextBoxStreamType.RichText);
                }

                richTextBox1.Text = "using System;\r\n\r\nnamespace ornek\r\n{\r\n    class Program  // sınıf tanımlaması\r\n    {\r\n        static void Main(string[] args)\r\n        {\r\n\r\n             Console.WriteLine(\" Merhaba Millet”);\r\n            Console.ReadKey();\r\n        }\r\n    }\r\n}\r\n ";

            }
            else if (result1 == DialogResult.No)
            {
                richTextBox1.Text = "using System;\r\n\r\nnamespace ornek\r\n{\r\n    class Program  // sınıf tanımlaması\r\n    {\r\n        static void Main(string[] args)\r\n        {\r\n\r\n             Console.WriteLine(\" Merhaba Millet”);\r\n            Console.ReadKey();\r\n        }\r\n    }\r\n}\r\n ";
            }
            else if (result1 == DialogResult.Cancel)
            {

            }
        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Değişiklikleri kaydetmek istiyor musunuz?", "Not Defteri", MessageBoxButtons.YesNoCancel);
            if (result1 == DialogResult.Yes)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Metin Dosyası|*.txt|C Dosyası|*.c|C++ Dosyası|*.cpp|C# Dosyası|*.cs";
                save.OverwritePrompt = true;
                save.CreatePrompt = true;
                //Kaydetme işlemini gerçekleştirir.
                if (save.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SaveFile(save.FileName, RichTextBoxStreamType.RichText);
                }
            }
            else if (result1 == DialogResult.No)
            {

            }
            else if (result1 == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void yeniToolStripButton_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Değişiklikleri kaydetmek istiyor musunuz?", "Not Defteri", MessageBoxButtons.YesNoCancel);
            if (result1 == DialogResult.Yes)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Metin Dosyası|*.txt|C Dosyası|*.c|C++ Dosyası|*.cpp|C# Dosyası|*.cs";
                save.OverwritePrompt = true;
                save.CreatePrompt = true;
                //Kaydetme işlemini gerçekleştirir.
                if (save.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SaveFile(save.FileName, RichTextBoxStreamType.RichText);
                }
            }
            else if (result1 == DialogResult.No)
            {
                richTextBox1.Text = " ";
            }
            else if (result1 == DialogResult.Cancel)
            {

            }
        }

        private void açToolStripButton_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Değişiklikleri kaydetmek istiyor musunuz?", "Not Defteri", MessageBoxButtons.YesNoCancel);
            if (result1 == DialogResult.Yes)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "RTF Dosyası|*.rtf|Metin Dosyası|*.txt|C Dosyası|*.c|C++ Dosyası|*.cpp|C# Dosyası|*.cs";
                save.OverwritePrompt = true;
                save.CreatePrompt = true;
                //Kaydetme işlemini gerçekleştirir.
                if (save.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SaveFile(save.FileName, RichTextBoxStreamType.RichText);
                }
            }
            else if (result1 == DialogResult.No)
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "RTF Dosyası|*.rtf|Metin Dosyası|*.txt|C Dosyası|*.c|C++ Dosyası|*.cpp|C# Dosyası|*.cs";
                //Kaydetme işlemini gerçekleştirir.
                if (open.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.LoadFile(open.FileName, RichTextBoxStreamType.RichText);
                }
            }
            else if (result1 == DialogResult.Cancel)
            {

            }
        }

        private void kaydetToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "RTF Dosyası|*.rtf|Metin Dosyası|*.txt|C Dosyası|*.c|C++ Dosyası|*.cpp|C# Dosyası|*.cs";
            save.OverwritePrompt = true;
            save.CreatePrompt = true;
            //Kaydetme işlemini gerçekleştirir.
            if (save.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(save.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void kesToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void kopyalaToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void yapıştırToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            //Bu if koşulu, richTextBox1'de metin varsa, label1'e metindeki karakter sayısını gösteren bir mesaj yazdırır.
            if (richTextBox1.Text.Length > 0)
            {
                label1.Text = "Toplam Karakter Sayısı = " + richTextBox1.Text.Length.ToString();
            }
            //metin yoksa, label1'e "Toplam Karakter Sayısı = 0" mesajını yazdırır.
            else if (richTextBox1.Text.Length == 0)
            {
                label1.Text = "Toplam Karakter Sayısı = 0 ";
            }
        }
    }
}
