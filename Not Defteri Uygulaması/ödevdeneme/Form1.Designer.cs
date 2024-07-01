namespace ödevdeneme
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniSayfaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cYeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cPlusPlusYeniToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cSharpYeniToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.açToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sagTıkCıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biçimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopyalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yapıştırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazıRengiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kopyalaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.yapıştırToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.renkDeğiştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazıTipiDeğiştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.yeniToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.açToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.kaydetToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.kesToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.kopyalaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.yapıştırToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.biçimToolStripMenuItem,
            this.ayarlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip2";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniToolStripMenuItem,
            this.toolStripSeparator1,
            this.açToolStripMenuItem,
            this.kaydetToolStripMenuItem,
            this.sagTıkCıkışToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(64, 26);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // yeniToolStripMenuItem
            // 
            this.yeniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniSayfaToolStripMenuItem,
            this.cYeniToolStripMenuItem,
            this.cPlusPlusYeniToolStripMenuItem1,
            this.cSharpYeniToolStripMenuItem2});
            this.yeniToolStripMenuItem.Image = global::ödevdeneme.Properties.Resources.Plus;
            this.yeniToolStripMenuItem.Name = "yeniToolStripMenuItem";
            this.yeniToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.yeniToolStripMenuItem.Text = "Yeni";
            // 
            // yeniSayfaToolStripMenuItem
            // 
            this.yeniSayfaToolStripMenuItem.Image = global::ödevdeneme.Properties.Resources.New_Documentoffices;
            this.yeniSayfaToolStripMenuItem.Name = "yeniSayfaToolStripMenuItem";
            this.yeniSayfaToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.yeniSayfaToolStripMenuItem.Text = "Yeni Sayfa";
            this.yeniSayfaToolStripMenuItem.Click += new System.EventHandler(this.yeniSayfaToolStripMenuItem_Click);
            // 
            // cYeniToolStripMenuItem
            // 
            this.cYeniToolStripMenuItem.Image = global::ödevdeneme.Properties.Resources.C_offices;
            this.cYeniToolStripMenuItem.Name = "cYeniToolStripMenuItem";
            this.cYeniToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.cYeniToolStripMenuItem.Text = "C";
            this.cYeniToolStripMenuItem.Click += new System.EventHandler(this.cYeniToolStripMenuItem_Click);
            // 
            // cPlusPlusYeniToolStripMenuItem1
            // 
            this.cPlusPlusYeniToolStripMenuItem1.Image = global::ödevdeneme.Properties.Resources.C_Plus_Plusoffices;
            this.cPlusPlusYeniToolStripMenuItem1.Name = "cPlusPlusYeniToolStripMenuItem1";
            this.cPlusPlusYeniToolStripMenuItem1.Size = new System.Drawing.Size(159, 26);
            this.cPlusPlusYeniToolStripMenuItem1.Text = "C++";
            this.cPlusPlusYeniToolStripMenuItem1.Click += new System.EventHandler(this.cPlusPlusYeniToolStripMenuItem1_Click);
            // 
            // cSharpYeniToolStripMenuItem2
            // 
            this.cSharpYeniToolStripMenuItem2.Image = global::ödevdeneme.Properties.Resources.CSoffices;
            this.cSharpYeniToolStripMenuItem2.Name = "cSharpYeniToolStripMenuItem2";
            this.cSharpYeniToolStripMenuItem2.Size = new System.Drawing.Size(159, 26);
            this.cSharpYeniToolStripMenuItem2.Text = "C#";
            this.cSharpYeniToolStripMenuItem2.Click += new System.EventHandler(this.cSharpYeniToolStripMenuItem2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(180, 6);
            // 
            // açToolStripMenuItem
            // 
            this.açToolStripMenuItem.Image = global::ödevdeneme.Properties.Resources.office_sAdd_File1;
            this.açToolStripMenuItem.Name = "açToolStripMenuItem";
            this.açToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.açToolStripMenuItem.Text = "Dosya Aç";
            this.açToolStripMenuItem.Click += new System.EventHandler(this.açToolStripMenuItem_Click_1);
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Image = global::ödevdeneme.Properties.Resources.offfice_sSave2;
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.kaydetToolStripMenuItem.Text = "Dosya Kaydet";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.kaydetToolStripMenuItem_Click_1);
            // 
            // sagTıkCıkışToolStripMenuItem
            // 
            this.sagTıkCıkışToolStripMenuItem.Image = global::ödevdeneme.Properties.Resources.Cancel;
            this.sagTıkCıkışToolStripMenuItem.Name = "sagTıkCıkışToolStripMenuItem";
            this.sagTıkCıkışToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.sagTıkCıkışToolStripMenuItem.Text = "Çıkış";
            this.sagTıkCıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click_1);
            // 
            // biçimToolStripMenuItem
            // 
            this.biçimToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kesToolStripMenuItem,
            this.kopyalaToolStripMenuItem,
            this.yapıştırToolStripMenuItem});
            this.biçimToolStripMenuItem.Name = "biçimToolStripMenuItem";
            this.biçimToolStripMenuItem.Size = new System.Drawing.Size(60, 26);
            this.biçimToolStripMenuItem.Text = "Biçim";
            // 
            // kesToolStripMenuItem
            // 
            this.kesToolStripMenuItem.Image = global::ödevdeneme.Properties.Resources.office_sCut;
            this.kesToolStripMenuItem.Name = "kesToolStripMenuItem";
            this.kesToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.kesToolStripMenuItem.Text = "Kes";
            this.kesToolStripMenuItem.Click += new System.EventHandler(this.kesToolStripMenuItem_Click_1);
            // 
            // kopyalaToolStripMenuItem
            // 
            this.kopyalaToolStripMenuItem.Image = global::ödevdeneme.Properties.Resources.officesDocuments;
            this.kopyalaToolStripMenuItem.Name = "kopyalaToolStripMenuItem";
            this.kopyalaToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.kopyalaToolStripMenuItem.Text = "Kopyala";
            this.kopyalaToolStripMenuItem.Click += new System.EventHandler(this.kopyalaToolStripMenuItem_Click_1);
            // 
            // yapıştırToolStripMenuItem
            // 
            this.yapıştırToolStripMenuItem.Image = global::ödevdeneme.Properties.Resources.officesPaste_As_Text;
            this.yapıştırToolStripMenuItem.Name = "yapıştırToolStripMenuItem";
            this.yapıştırToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.yapıştırToolStripMenuItem.Text = "Yapıştır";
            this.yapıştırToolStripMenuItem.Click += new System.EventHandler(this.yapıştırToolStripMenuItem_Click_1);
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renkToolStripMenuItem,
            this.yazıToolStripMenuItem});
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(70, 26);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            // 
            // renkToolStripMenuItem
            // 
            this.renkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yazıRengiToolStripMenuItem,
            this.arkaToolStripMenuItem});
            this.renkToolStripMenuItem.Image = global::ödevdeneme.Properties.Resources.Color_Wheel1;
            this.renkToolStripMenuItem.Name = "renkToolStripMenuItem";
            this.renkToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.renkToolStripMenuItem.Text = "Renk";
            // 
            // yazıRengiToolStripMenuItem
            // 
            this.yazıRengiToolStripMenuItem.Image = global::ödevdeneme.Properties.Resources.officesText_Color;
            this.yazıRengiToolStripMenuItem.Name = "yazıRengiToolStripMenuItem";
            this.yazıRengiToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.yazıRengiToolStripMenuItem.Text = "Yazı Rengi";
            this.yazıRengiToolStripMenuItem.Click += new System.EventHandler(this.yazıRengiToolStripMenuItem_Click);
            // 
            // arkaToolStripMenuItem
            // 
            this.arkaToolStripMenuItem.Image = global::ödevdeneme.Properties.Resources.officesFill_Color;
            this.arkaToolStripMenuItem.Name = "arkaToolStripMenuItem";
            this.arkaToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.arkaToolStripMenuItem.Text = "Arka Plan Rengi";
            this.arkaToolStripMenuItem.Click += new System.EventHandler(this.arkaToolStripMenuItem_Click);
            // 
            // yazıToolStripMenuItem
            // 
            this.yazıToolStripMenuItem.Image = global::ödevdeneme.Properties.Resources.officesType;
            this.yazıToolStripMenuItem.Name = "yazıToolStripMenuItem";
            this.yazıToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.yazıToolStripMenuItem.Text = "Yazı Tipi";
            this.yazıToolStripMenuItem.Click += new System.EventHandler(this.yazıToolStripMenuItem_Click_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.richTextBox1.Location = new System.Drawing.Point(12, 68);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(776, 354);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kesToolStripMenuItem1,
            this.kopyalaToolStripMenuItem1,
            this.yapıştırToolStripMenuItem1,
            this.toolStripSeparator2,
            this.renkDeğiştirToolStripMenuItem,
            this.yazıTipiDeğiştirToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(219, 140);
            // 
            // kesToolStripMenuItem1
            // 
            this.kesToolStripMenuItem1.Image = global::ödevdeneme.Properties.Resources.Cut;
            this.kesToolStripMenuItem1.Name = "kesToolStripMenuItem1";
            this.kesToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.kesToolStripMenuItem1.Size = new System.Drawing.Size(218, 26);
            this.kesToolStripMenuItem1.Text = "Kes";
            this.kesToolStripMenuItem1.Click += new System.EventHandler(this.kesToolStripMenuItem1_Click);
            // 
            // kopyalaToolStripMenuItem1
            // 
            this.kopyalaToolStripMenuItem1.Image = global::ödevdeneme.Properties.Resources.winCopy;
            this.kopyalaToolStripMenuItem1.Name = "kopyalaToolStripMenuItem1";
            this.kopyalaToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.kopyalaToolStripMenuItem1.Size = new System.Drawing.Size(218, 26);
            this.kopyalaToolStripMenuItem1.Text = "Kopyala";
            this.kopyalaToolStripMenuItem1.Click += new System.EventHandler(this.kopyalaToolStripMenuItem1_Click);
            // 
            // yapıştırToolStripMenuItem1
            // 
            this.yapıştırToolStripMenuItem1.Image = global::ödevdeneme.Properties.Resources.Paste_As_Text;
            this.yapıştırToolStripMenuItem1.Name = "yapıştırToolStripMenuItem1";
            this.yapıştırToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.yapıştırToolStripMenuItem1.Size = new System.Drawing.Size(218, 26);
            this.yapıştırToolStripMenuItem1.Text = "Yapıştır";
            this.yapıştırToolStripMenuItem1.Click += new System.EventHandler(this.yapıştırToolStripMenuItem1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(215, 6);
            // 
            // renkDeğiştirToolStripMenuItem
            // 
            this.renkDeğiştirToolStripMenuItem.Image = global::ödevdeneme.Properties.Resources.officesPaint_Palette1;
            this.renkDeğiştirToolStripMenuItem.Name = "renkDeğiştirToolStripMenuItem";
            this.renkDeğiştirToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.renkDeğiştirToolStripMenuItem.Text = "Yazı Rengini Değiştir";
            this.renkDeğiştirToolStripMenuItem.Click += new System.EventHandler(this.renkDeğiştirToolStripMenuItem_Click);
            // 
            // yazıTipiDeğiştirToolStripMenuItem
            // 
            this.yazıTipiDeğiştirToolStripMenuItem.Image = global::ödevdeneme.Properties.Resources.Italic;
            this.yazıTipiDeğiştirToolStripMenuItem.Name = "yazıTipiDeğiştirToolStripMenuItem";
            this.yazıTipiDeğiştirToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.yazıTipiDeğiştirToolStripMenuItem.Text = "Yazı Tipini Değiştir";
            this.yazıTipiDeğiştirToolStripMenuItem.Click += new System.EventHandler(this.yazıTipiDeğiştirToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniToolStripButton,
            this.açToolStripButton,
            this.kaydetToolStripButton,
            this.toolStripSeparator,
            this.kesToolStripButton,
            this.kopyalaToolStripButton,
            this.yapıştırToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 30);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 31);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // yeniToolStripButton
            // 
            this.yeniToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.yeniToolStripButton.Image = global::ödevdeneme.Properties.Resources.Add_Filecolor;
            this.yeniToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.yeniToolStripButton.Name = "yeniToolStripButton";
            this.yeniToolStripButton.Size = new System.Drawing.Size(29, 28);
            this.yeniToolStripButton.Text = "Y&eni";
            this.yeniToolStripButton.Click += new System.EventHandler(this.yeniToolStripButton_Click);
            // 
            // açToolStripButton
            // 
            this.açToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.açToolStripButton.Image = global::ödevdeneme.Properties.Resources.Opened_Foldercolor;
            this.açToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.açToolStripButton.Name = "açToolStripButton";
            this.açToolStripButton.Size = new System.Drawing.Size(29, 28);
            this.açToolStripButton.Text = "&Aç";
            this.açToolStripButton.Click += new System.EventHandler(this.açToolStripButton_Click);
            // 
            // kaydetToolStripButton
            // 
            this.kaydetToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.kaydetToolStripButton.Image = global::ödevdeneme.Properties.Resources.Savecolor;
            this.kaydetToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.kaydetToolStripButton.Name = "kaydetToolStripButton";
            this.kaydetToolStripButton.Size = new System.Drawing.Size(29, 28);
            this.kaydetToolStripButton.Text = "&Kaydet";
            this.kaydetToolStripButton.Click += new System.EventHandler(this.kaydetToolStripButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // kesToolStripButton
            // 
            this.kesToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.kesToolStripButton.Image = global::ödevdeneme.Properties.Resources.Cutcolor;
            this.kesToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.kesToolStripButton.Name = "kesToolStripButton";
            this.kesToolStripButton.Size = new System.Drawing.Size(29, 28);
            this.kesToolStripButton.Text = "K&es";
            this.kesToolStripButton.Click += new System.EventHandler(this.kesToolStripButton_Click);
            // 
            // kopyalaToolStripButton
            // 
            this.kopyalaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.kopyalaToolStripButton.Image = global::ödevdeneme.Properties.Resources.Copycolor;
            this.kopyalaToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.kopyalaToolStripButton.Name = "kopyalaToolStripButton";
            this.kopyalaToolStripButton.Size = new System.Drawing.Size(29, 28);
            this.kopyalaToolStripButton.Text = "K&opyala";
            this.kopyalaToolStripButton.Click += new System.EventHandler(this.kopyalaToolStripButton_Click);
            // 
            // yapıştırToolStripButton
            // 
            this.yapıştırToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.yapıştırToolStripButton.Image = global::ödevdeneme.Properties.Resources.Pastecolor;
            this.yapıştırToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.yapıştırToolStripButton.Name = "yapıştırToolStripButton";
            this.yapıştırToolStripButton.Size = new System.Drawing.Size(29, 28);
            this.yapıştırToolStripButton.Text = "&Yapıştır";
            this.yapıştırToolStripButton.Click += new System.EventHandler(this.yapıştırToolStripButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Toplam Karakter Sayısı = 0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Not Defteri";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem açToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sagTıkCıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem biçimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopyalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yapıştırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazıToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem yazıRengiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arkaToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kopyalaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem yapıştırToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem renkDeğiştirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazıTipiDeğiştirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniSayfaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cYeniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cPlusPlusYeniToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cSharpYeniToolStripMenuItem2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton yeniToolStripButton;
        private System.Windows.Forms.ToolStripButton açToolStripButton;
        private System.Windows.Forms.ToolStripButton kaydetToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton kesToolStripButton;
        private System.Windows.Forms.ToolStripButton kopyalaToolStripButton;
        private System.Windows.Forms.ToolStripButton yapıştırToolStripButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}

