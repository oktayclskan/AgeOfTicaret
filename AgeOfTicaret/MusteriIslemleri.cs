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
    public partial class tb_fax : Form
    {
        DataModel dm = new DataModel();
        int id = -1;

        public tb_fax()
        {
            InitializeComponent();
        }

        private void MusteriIslemleri_Load(object sender, EventArgs e)
        {
            dataGridViewMusteri.DataSource = dm.customersList();
        }

        private void dataGridViewMusteri_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var yer = dataGridViewMusteri.HitTest(e.X, e.Y);

                dataGridViewMusteri.ClearSelection();
                dataGridViewMusteri.Rows[yer.RowIndex].Selected = true;
                yer.RowIndex.ToString();
                contextMenuStripMusteri.Show(dataGridViewMusteri, e.X, e.Y);

            }
        }

        private void btn_addCustomer_Click(object sender, EventArgs e)
        {

        }

        private void btn_updateCustomer_Click(object sender, EventArgs e)
        {

        }

        private void gToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TSMI güncelle

            Customer c = dm.getCustomers(id).ToString();
            tb_ID.Text = c.CustomerID;
            tb_CopmanyName.Text = c.CompanyName;
            tb_contactName.Text = c.ContactName;
            tb_ContactTitle.Text = c.ContactTitle;
            tb_adress.Text = c.Address;
            tb_city.Text = c.City;
            tb_region.Text = c.Region;
            tb_postalCode.Text = c.PostalCode;
            tb_country.Text = c.Country;
            tb_postalCode.Text = c.Phone;
            tb_faxx.Text = c.Fax;
            btn_updateCustomer.Visible = true;

        }

        private void TSMI_delete_Click(object sender, EventArgs e)
        {

        }
    }
}
