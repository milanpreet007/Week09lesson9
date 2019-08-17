using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
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

            var rowIndex = HardwareListdataGridView.CurrentCell.RowIndex;
            var currentRow = HardwareListdataGridView.Rows[rowIndex];

            //open the stream to write
            using (StreamWriter outputString = new StreamWriter(
                File.Open("Product.txt", FileMode.Create)))
            {
                //write stuff to the file
                outputString.WriteLine(currentRow.Cells[0].Value.ToString());
                outputString.WriteLine(currentRow.Cells[1].Value.ToString());
                outputString.WriteLine(currentRow.Cells[2].Value.ToString());
                outputString.WriteLine(currentRow.Cells[3].Value.ToString());
                outputString.WriteLine(currentRow.Cells[5].Value.ToString());
                outputString.WriteLine(currentRow.Cells[7].Value.ToString());
                outputString.WriteLine(currentRow.Cells[10].Value.ToString());
                outputString.WriteLine(currentRow.Cells[11].Value.ToString());
                outputString.WriteLine(currentRow.Cells[12].Value.ToString());
                outputString.WriteLine(currentRow.Cells[13].Value.ToString());
                outputString.WriteLine(currentRow.Cells[14].Value.ToString());
                outputString.WriteLine(currentRow.Cells[15].Value.ToString());
                outputString.WriteLine(currentRow.Cells[16].Value.ToString());
                outputString.WriteLine(currentRow.Cells[17].Value.ToString());
                outputString.WriteLine(currentRow.Cells[19].Value.ToString());
                outputString.WriteLine(currentRow.Cells[21].Value.ToString());
                outputString.WriteLine(currentRow.Cells[30].Value.ToString());
                outputString.WriteLine(currentRow.Cells[24].Value.ToString());
                outputString.WriteLine(currentRow.Cells[25].Value.ToString());
                outputString.WriteLine(currentRow.Cells[28].Value.ToString());
                outputString.WriteLine(currentRow.Cells[29].Value.ToString());


                //cleanup
                outputString.Close();
                outputString.Dispose();
            }

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
                // this lines is the code that loads data into the DollarcomputersdataSet.hardware list table
                db.products.Load();
                productsBindingSource.DataSource = db.products.Local.ToBindingList(); 
            }
        }

       /* private void HardwareListdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
            //local scope aliases
            var rowIndex = HardwareListdataGridView.CurrentCell.RowIndex;
            var rows = HardwareListdataGridView.Rows;
            var columncount = HardwareListdataGridView.ColumnCount;
            var cells = rows[rowIndex].Cells;

            rows[rowIndex].Selected = true;
            string outputString = string.Empty;
            for(int index=0; index < columncount;index++)
            {
                cells[index].Value.ToString();
            }
            selectedItemViewtextBox.Text = outputString;

            Program.product.manufacturer= cells[]
        }*/

        private void HardwareListdataGridView_SelectionChanged(object sender, EventArgs e)
        {
            selectedItemViewtextBox.Text = ComputerListDataGridViewSelectedItem();
        }
        /// <summary>
        /// this is the method to show  the cost manufacturer and model of the hardware chosen
        /// </summary>
        /// <returns></returns>
        private string ComputerListDataGridViewSelectedItem()
        {
            var rowIndex = HardwareListdataGridView.CurrentCell.RowIndex;
            var currentRow = HardwareListdataGridView.Rows[rowIndex];
            var cost = currentRow.Cells[1].Value.ToString();
            var manufacturer = currentRow.Cells[2].Value.ToString();
            var model = currentRow.Cells[3].Value.ToString();

            string outputstring = manufacturer + " " + model + "  $" + cost;

            return outputstring;
        }

    }
}
