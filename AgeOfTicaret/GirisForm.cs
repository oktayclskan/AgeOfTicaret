using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;

namespace AgeOfTicaret
{
    public partial class GirisForm : Form
    {
        bool girisVar = false;
        DataModel dm = new DataModel();
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
                Employes model = dm.EmployeeLogin(tb_kullaniciAdi.Text, tb_sifre.Text);
                if (model.UserName !=null)
                {
                    Helpers.GirisYapanKullanici = model;
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
