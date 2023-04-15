
namespace AgeOfTicaret
{
    partial class tb_fax
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewMusteri = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStripMusteri = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_CopmanyName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_contactName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_ContactTitle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_adress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_city = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_region = new System.Windows.Forms.TextBox();
            this.tb_postalCode = new System.Windows.Forms.TextBox();
            this.tb_country = new System.Windows.Forms.TextBox();
            this.tb_faxx = new System.Windows.Forms.TextBox();
            this.btn_addCustomer = new System.Windows.Forms.Button();
            this.mtb_Phone = new System.Windows.Forms.MaskedTextBox();
            this.btn_updateCustomer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusteri)).BeginInit();
            this.contextMenuStripMusteri.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewMusteri
            // 
            this.dataGridViewMusteri.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMusteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMusteri.Location = new System.Drawing.Point(3, 238);
            this.dataGridViewMusteri.Name = "dataGridViewMusteri";
            this.dataGridViewMusteri.Size = new System.Drawing.Size(794, 211);
            this.dataGridViewMusteri.TabIndex = 0;
            this.dataGridViewMusteri.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridViewMusteri_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID : ";
            // 
            // contextMenuStripMusteri
            // 
            this.contextMenuStripMusteri.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gToolStripMenuItem,
            this.TSMI_delete});
            this.contextMenuStripMusteri.Name = "contextMenuStripMusteri";
            this.contextMenuStripMusteri.Size = new System.Drawing.Size(121, 48);
            // 
            // gToolStripMenuItem
            // 
            this.gToolStripMenuItem.Name = "gToolStripMenuItem";
            this.gToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.gToolStripMenuItem.Text = "Güncelle";
            this.gToolStripMenuItem.Click += new System.EventHandler(this.gToolStripMenuItem_Click);
            // 
            // TSMI_delete
            // 
            this.TSMI_delete.Name = "TSMI_delete";
            this.TSMI_delete.Size = new System.Drawing.Size(120, 22);
            this.TSMI_delete.Text = "Sil";
            this.TSMI_delete.Click += new System.EventHandler(this.TSMI_delete_Click);
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(105, 12);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(243, 20);
            this.tb_ID.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contact Title : ";
            // 
            // tb_CopmanyName
            // 
            this.tb_CopmanyName.Location = new System.Drawing.Point(105, 35);
            this.tb_CopmanyName.Name = "tb_CopmanyName";
            this.tb_CopmanyName.Size = new System.Drawing.Size(243, 20);
            this.tb_CopmanyName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Company Name : ";
            // 
            // tb_contactName
            // 
            this.tb_contactName.Location = new System.Drawing.Point(105, 59);
            this.tb_contactName.Name = "tb_contactName";
            this.tb_contactName.Size = new System.Drawing.Size(243, 20);
            this.tb_contactName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Contant Name : ";
            // 
            // tb_ContactTitle
            // 
            this.tb_ContactTitle.Location = new System.Drawing.Point(105, 82);
            this.tb_ContactTitle.Name = "tb_ContactTitle";
            this.tb_ContactTitle.Size = new System.Drawing.Size(243, 20);
            this.tb_ContactTitle.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Address : ";
            // 
            // tb_adress
            // 
            this.tb_adress.Location = new System.Drawing.Point(105, 106);
            this.tb_adress.Name = "tb_adress";
            this.tb_adress.Size = new System.Drawing.Size(243, 20);
            this.tb_adress.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "City : ";
            // 
            // tb_city
            // 
            this.tb_city.Location = new System.Drawing.Point(105, 132);
            this.tb_city.Name = "tb_city";
            this.tb_city.Size = new System.Drawing.Size(243, 20);
            this.tb_city.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(376, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Region : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(353, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Postal Code : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(368, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Country : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(376, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Phone : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(387, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "fax : ";
            // 
            // tb_region
            // 
            this.tb_region.Location = new System.Drawing.Point(423, 15);
            this.tb_region.Name = "tb_region";
            this.tb_region.Size = new System.Drawing.Size(308, 20);
            this.tb_region.TabIndex = 2;
            // 
            // tb_postalCode
            // 
            this.tb_postalCode.Location = new System.Drawing.Point(423, 38);
            this.tb_postalCode.Name = "tb_postalCode";
            this.tb_postalCode.Size = new System.Drawing.Size(308, 20);
            this.tb_postalCode.TabIndex = 2;
            // 
            // tb_country
            // 
            this.tb_country.Location = new System.Drawing.Point(423, 62);
            this.tb_country.Name = "tb_country";
            this.tb_country.Size = new System.Drawing.Size(308, 20);
            this.tb_country.TabIndex = 2;
            // 
            // tb_faxx
            // 
            this.tb_faxx.Location = new System.Drawing.Point(423, 114);
            this.tb_faxx.Name = "tb_faxx";
            this.tb_faxx.Size = new System.Drawing.Size(308, 20);
            this.tb_faxx.TabIndex = 2;
            // 
            // btn_addCustomer
            // 
            this.btn_addCustomer.Location = new System.Drawing.Point(423, 140);
            this.btn_addCustomer.Name = "btn_addCustomer";
            this.btn_addCustomer.Size = new System.Drawing.Size(308, 23);
            this.btn_addCustomer.TabIndex = 3;
            this.btn_addCustomer.Text = "Ekle";
            this.btn_addCustomer.UseVisualStyleBackColor = true;
            this.btn_addCustomer.Click += new System.EventHandler(this.btn_addCustomer_Click);
            // 
            // mtb_Phone
            // 
            this.mtb_Phone.Location = new System.Drawing.Point(423, 88);
            this.mtb_Phone.Mask = "(999) 000-0000";
            this.mtb_Phone.Name = "mtb_Phone";
            this.mtb_Phone.Size = new System.Drawing.Size(308, 20);
            this.mtb_Phone.TabIndex = 4;
            // 
            // btn_updateCustomer
            // 
            this.btn_updateCustomer.Location = new System.Drawing.Point(423, 140);
            this.btn_updateCustomer.Name = "btn_updateCustomer";
            this.btn_updateCustomer.Size = new System.Drawing.Size(308, 23);
            this.btn_updateCustomer.TabIndex = 5;
            this.btn_updateCustomer.Text = "Güncelle";
            this.btn_updateCustomer.UseVisualStyleBackColor = true;
            this.btn_updateCustomer.Visible = false;
            this.btn_updateCustomer.Click += new System.EventHandler(this.btn_updateCustomer_Click);
            // 
            // tb_fax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_updateCustomer);
            this.Controls.Add(this.mtb_Phone);
            this.Controls.Add(this.btn_addCustomer);
            this.Controls.Add(this.tb_city);
            this.Controls.Add(this.tb_faxx);
            this.Controls.Add(this.tb_adress);
            this.Controls.Add(this.tb_ContactTitle);
            this.Controls.Add(this.tb_country);
            this.Controls.Add(this.tb_contactName);
            this.Controls.Add(this.tb_postalCode);
            this.Controls.Add(this.tb_CopmanyName);
            this.Controls.Add(this.tb_region);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewMusteri);
            this.Name = "tb_fax";
            this.Text = "Muşteri İşlemleri";
            this.Load += new System.EventHandler(this.MusteriIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusteri)).EndInit();
            this.contextMenuStripMusteri.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMusteri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMusteri;
        private System.Windows.Forms.ToolStripMenuItem gToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_delete;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_CopmanyName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_contactName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_ContactTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_adress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_city;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_region;
        private System.Windows.Forms.TextBox tb_postalCode;
        private System.Windows.Forms.TextBox tb_country;
        private System.Windows.Forms.TextBox tb_faxx;
        private System.Windows.Forms.Button btn_addCustomer;
        private System.Windows.Forms.MaskedTextBox mtb_Phone;
        private System.Windows.Forms.Button btn_updateCustomer;
    }
}