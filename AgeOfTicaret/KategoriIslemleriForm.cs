using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DataAccessLayer;

namespace AgeOfTicaret
{
    public partial class KategoriIslemleriForm : Form
    {
        DataModel dm = new DataModel();
        int id = -1;
        public KategoriIslemleriForm()
        {
            InitializeComponent();
        }

        private void KategoriIslemleriForm_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = dm.CategoriesList();

        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_isim.Text.Trim()))
            {
                Category c = new Category();
                c.CategoryName = tb_isim.Text;
                c.Descripton = tb_aciklama.Text;
                c = dm.KategoriEkle(c);
                if (c.ID != 0)
                {
                    MessageBox.Show("Kategori" + c.ID + "id ile başarıyla eklenmiştir", "Başarılı");
                    dataGridView1.DataSource = dm.CategoriesList();
                }
                else
                {
                    MessageBox.Show("KAtegori eklenirken bir hata oluştu", "Başarısız");
                }
            }
            else
            {
                MessageBox.Show("isim boş bırakılamaz", "dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                var yer = dataGridView1.HitTest(e.X, e.Y);

                if (yer.RowIndex != -1)
                {
                    // MessageBox.Show("Seçilen Satır = " + yer.RowIndex.ToString());
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[yer.RowIndex].Selected = true;
                    id = Convert.ToInt32(dataGridView1.Rows[yer.RowIndex].Cells[0].Value);
                    contextMenuStrip1.Show(dataGridView1, e.X, e.Y);
                }
            }
        }

        private void TSMI_Guncelle_Click(object sender, EventArgs e)
        {
            if (id != -1)
            {
                Category c = dm.getCategory(id);
                tb_ID.Text = c.ID.ToString();
                tb_isim.Text = c.CategoryName;
                tb_aciklama.Text = c.Descripton;


            }
            btn_guncelle.Visible = true;


        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            Category c = new Category();
            c.ID = Convert.ToInt32(tb_ID.Text);
            c.CategoryName = tb_isim.Text;
            c.Descripton = tb_aciklama.Text;
            if (dm.KategoriGuncelle(c))
            {
                MessageBox.Show("başarılı");
                dataGridView1.DataSource = dm.CategoriesList();
            }
            else
            {
                MessageBox.Show("başarısız");
            }
        }

        private void TSMI_sil_Click(object sender, EventArgs e)
        {
            if (dm.kategoriSil(id))
            {
                MessageBox.Show("Başarılı");
                btn_guncelle.Visible = false;
            }
            else
            {
                MessageBox.Show("Başarısız");
            }
            dataGridView1.DataSource = dm.CategoriesList();
        }
    }
}
