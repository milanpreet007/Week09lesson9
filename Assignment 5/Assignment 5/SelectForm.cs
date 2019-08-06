using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_5
{
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        private void Nextbutton_Click(object sender, EventArgs e)
        {
            Program.productInfoForm.Show();
            this.Hide();
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            using (var db = new DollarComputersContext())
            {
                db.products.Load();
                productsBindingSource.DataSource = db.products.Local.ToBindingList(); 
            }
        }

        private void HardwareListdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
