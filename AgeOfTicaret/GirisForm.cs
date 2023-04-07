﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeOfTicaret
{
    public partial class GirisForm : Form
    {
        bool girisVar = false;
        public GirisForm()
        {
            InitializeComponent();
        }
        

        private void GirisForm_Load(object sender, EventArgs e)
        {
            
           
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_kullaniciAdi.Text) && !string.IsNullOrEmpty(tb_sifre.Text))
            {
                if (tb_kullaniciAdi.Text == "admin" && tb_sifre.Text == "12345")
                {
                    girisVar = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Bilgileri hatalı","Giriş Başarısız",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya Sifre Boş bırakılamaz");
            }
            
        }
        private void btn_kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GirisForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!girisVar)
            {
                Application.Exit();
            }
        }

       
    }
}
