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
        public KategoriIslemleriForm()
        {
            InitializeComponent();
        }

        private void KategoriIslemleriForm_Load(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = dm.CategoriesList();
            
        }
    }
}
