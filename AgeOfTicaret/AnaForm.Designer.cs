﻿
namespace AgeOfTicaret
{
    partial class AnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Kategoriler = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_KategroiEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMI_Urunler = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_UrunEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TSSL_Kullanici = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.ürünİşlemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(775, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // ürünİşlemleriToolStripMenuItem
            // 
            this.ürünİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Kategoriler,
            this.TSMI_KategroiEkle,
            this.toolStripSeparator1,
            this.TSMI_Urunler,
            this.TSMI_UrunEkle});
            this.ürünİşlemleriToolStripMenuItem.Name = "ürünİşlemleriToolStripMenuItem";
            this.ürünİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.ürünİşlemleriToolStripMenuItem.Text = "Ürün İşlemleri";
            // 
            // TSMI_Kategoriler
            // 
            this.TSMI_Kategoriler.Name = "TSMI_Kategoriler";
            this.TSMI_Kategoriler.Size = new System.Drawing.Size(180, 22);
            this.TSMI_Kategoriler.Text = "Kategori İşlemleri";
            this.TSMI_Kategoriler.Click += new System.EventHandler(this.TSMI_Kategoriler_Click);
            // 
            // TSMI_KategroiEkle
            // 
            this.TSMI_KategroiEkle.Name = "TSMI_KategroiEkle";
            this.TSMI_KategroiEkle.Size = new System.Drawing.Size(180, 22);
            this.TSMI_KategroiEkle.Text = "Kategori Ekle";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // TSMI_Urunler
            // 
            this.TSMI_Urunler.Name = "TSMI_Urunler";
            this.TSMI_Urunler.Size = new System.Drawing.Size(180, 22);
            this.TSMI_Urunler.Text = "Ürünler";
            this.TSMI_Urunler.Click += new System.EventHandler(this.TSMI_Urunler_Click);
            // 
            // TSMI_UrunEkle
            // 
            this.TSMI_UrunEkle.Name = "TSMI_UrunEkle";
            this.TSMI_UrunEkle.Size = new System.Drawing.Size(180, 22);
            this.TSMI_UrunEkle.Text = "Ürün Ekle";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSSL_Kullanici});
            this.statusStrip1.Location = new System.Drawing.Point(0, 359);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(775, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TSSL_Kullanici
            // 
            this.TSSL_Kullanici.Name = "TSSL_Kullanici";
            this.TSSL_Kullanici.Size = new System.Drawing.Size(0, 17);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 381);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AnaForm";
            this.Text = "AnaForm";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Kategoriler;
        private System.Windows.Forms.ToolStripMenuItem TSMI_KategroiEkle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Urunler;
        private System.Windows.Forms.ToolStripMenuItem TSMI_UrunEkle;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel TSSL_Kullanici;
    }
}