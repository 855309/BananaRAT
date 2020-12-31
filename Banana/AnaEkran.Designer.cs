
namespace Banana
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.clientdatagrid = new System.Windows.Forms.DataGridView();
            this.adsutun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ipport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isletimsistemisutun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sagtikmenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mesajGönderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bağlantıyıKesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messageBoxGönderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masaüstüGörüntülemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dosyaÇalıştırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kameraİzlemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.başlatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notepadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.clientdatagrid)).BeginInit();
            this.sagtikmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Dinlemeye Başla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(12, 394);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(776, 111);
            this.textBox1.TabIndex = 1;
            // 
            // clientdatagrid
            // 
            this.clientdatagrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientdatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientdatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adsutun,
            this.ipport,
            this.isletimsistemisutun});
            this.clientdatagrid.Location = new System.Drawing.Point(12, 53);
            this.clientdatagrid.Name = "clientdatagrid";
            this.clientdatagrid.ReadOnly = true;
            this.clientdatagrid.Size = new System.Drawing.Size(776, 335);
            this.clientdatagrid.TabIndex = 2;
            // 
            // adsutun
            // 
            this.adsutun.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.adsutun.HeaderText = "Ad";
            this.adsutun.Name = "adsutun";
            this.adsutun.ReadOnly = true;
            // 
            // ipport
            // 
            this.ipport.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ipport.HeaderText = "IP:Port";
            this.ipport.Name = "ipport";
            this.ipport.ReadOnly = true;
            // 
            // isletimsistemisutun
            // 
            this.isletimsistemisutun.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.isletimsistemisutun.HeaderText = "İşletim Sistemi";
            this.isletimsistemisutun.Name = "isletimsistemisutun";
            this.isletimsistemisutun.ReadOnly = true;
            // 
            // sagtikmenu
            // 
            this.sagtikmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mesajGönderToolStripMenuItem,
            this.kapatToolStripMenuItem,
            this.bağlantıyıKesToolStripMenuItem,
            this.messageBoxGönderToolStripMenuItem,
            this.masaüstüGörüntülemeToolStripMenuItem,
            this.dosyaÇalıştırToolStripMenuItem,
            this.kameraİzlemeToolStripMenuItem,
            this.başlatToolStripMenuItem});
            this.sagtikmenu.Name = "sagtikmenu";
            this.sagtikmenu.Size = new System.Drawing.Size(199, 180);
            // 
            // mesajGönderToolStripMenuItem
            // 
            this.mesajGönderToolStripMenuItem.Name = "mesajGönderToolStripMenuItem";
            this.mesajGönderToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.mesajGönderToolStripMenuItem.Text = "Mesaj Gönder";
            this.mesajGönderToolStripMenuItem.Click += new System.EventHandler(this.mesajGönderToolStripMenuItem_Click);
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.kapatToolStripMenuItem.Text = "Qapat";
            this.kapatToolStripMenuItem.Click += new System.EventHandler(this.kapatToolStripMenuItem_Click);
            // 
            // bağlantıyıKesToolStripMenuItem
            // 
            this.bağlantıyıKesToolStripMenuItem.Name = "bağlantıyıKesToolStripMenuItem";
            this.bağlantıyıKesToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.bağlantıyıKesToolStripMenuItem.Text = "Bağlantıyı Kes";
            this.bağlantıyıKesToolStripMenuItem.Click += new System.EventHandler(this.bağlantıyıKesToolStripMenuItem_Click);
            // 
            // messageBoxGönderToolStripMenuItem
            // 
            this.messageBoxGönderToolStripMenuItem.Name = "messageBoxGönderToolStripMenuItem";
            this.messageBoxGönderToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.messageBoxGönderToolStripMenuItem.Text = "MessageBox Gönder";
            this.messageBoxGönderToolStripMenuItem.Click += new System.EventHandler(this.messageBoxGönderToolStripMenuItem_Click);
            // 
            // masaüstüGörüntülemeToolStripMenuItem
            // 
            this.masaüstüGörüntülemeToolStripMenuItem.Name = "masaüstüGörüntülemeToolStripMenuItem";
            this.masaüstüGörüntülemeToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.masaüstüGörüntülemeToolStripMenuItem.Text = "Masaüstü Görüntüleme";
            this.masaüstüGörüntülemeToolStripMenuItem.Click += new System.EventHandler(this.masaüstüGörüntülemeToolStripMenuItem_Click);
            // 
            // dosyaÇalıştırToolStripMenuItem
            // 
            this.dosyaÇalıştırToolStripMenuItem.Name = "dosyaÇalıştırToolStripMenuItem";
            this.dosyaÇalıştırToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.dosyaÇalıştırToolStripMenuItem.Text = "Dosya Çalıştır";
            this.dosyaÇalıştırToolStripMenuItem.Click += new System.EventHandler(this.dosyaÇalıştırToolStripMenuItem_Click);
            // 
            // kameraİzlemeToolStripMenuItem
            // 
            this.kameraİzlemeToolStripMenuItem.Name = "kameraİzlemeToolStripMenuItem";
            this.kameraİzlemeToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.kameraİzlemeToolStripMenuItem.Text = "Kamera İzleme";
            this.kameraİzlemeToolStripMenuItem.Visible = false;
            this.kameraİzlemeToolStripMenuItem.Click += new System.EventHandler(this.kameraİzlemeToolStripMenuItem_Click);
            // 
            // başlatToolStripMenuItem
            // 
            this.başlatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notepadToolStripMenuItem});
            this.başlatToolStripMenuItem.Name = "başlatToolStripMenuItem";
            this.başlatToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.başlatToolStripMenuItem.Text = "Başlat";
            // 
            // notepadToolStripMenuItem
            // 
            this.notepadToolStripMenuItem.Name = "notepadToolStripMenuItem";
            this.notepadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.notepadToolStripMenuItem.Text = "notepad";
            this.notepadToolStripMenuItem.Click += new System.EventHandler(this.notepadToolStripMenuItem_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(137, 20);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(112, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "127.0.0.1";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 517);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.clientdatagrid);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Banana Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientdatagrid)).EndInit();
            this.sagtikmenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView clientdatagrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn adsutun;
        private System.Windows.Forms.DataGridViewTextBoxColumn ipport;
        private System.Windows.Forms.DataGridViewTextBoxColumn isletimsistemisutun;
        private System.Windows.Forms.ContextMenuStrip sagtikmenu;
        private System.Windows.Forms.ToolStripMenuItem mesajGönderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bağlantıyıKesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem messageBoxGönderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masaüstüGörüntülemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kameraİzlemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dosyaÇalıştırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem başlatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notepadToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox2;
    }
}

