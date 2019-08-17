using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_5
{
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm()
        {
            InitializeComponent();
        }

        private void Nextbutton_Click(object sender, EventArgs e)
        {
            Program.orderForm.Show();
            this.Hide();
        }

        private void SelectAnotherProductbutton_Click(object sender, EventArgs e)
        {
            Program.selectForm.Show();
            this.Hide();
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // confgure the dile dialog
            openFileDialog.FileName = "Product.txt";
            openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";
            //open the file diolog
            var result = openFileDialog.ShowDialog();
            //open file stream to read
            using (StreamReader inputStream = new StreamReader(File.Open(openFileDialog.FileName, FileMode.Open)))
            {
                // read stuff from the file
                Program.products.productID = short.Parse(inputStream.ReadLine());
                Program.products.cost = decimal.Parse(inputStream.ReadLine());
                Program.products.manufacturer = inputStream.ReadLine();
                Program.products.model = inputStream.ReadLine();
                Program.products.RAM_size = inputStream.ReadLine();
                Program.products.screensize = inputStream.ReadLine();
                Program.products.CPU_brand = inputStream.ReadLine();
                Program.products.CPU_type = inputStream.ReadLine();
                Program.products.CPU_speed = inputStream.ReadLine();
                Program.products.CPU_number = inputStream.ReadLine();
                Program.products.condition = inputStream.ReadLine();
                Program.products.OS = inputStream.ReadLine();
                Program.products.platform = inputStream.ReadLine();
                Program.products.HDD_size = inputStream.ReadLine();
                Program.products.GPU_Type = inputStream.ReadLine();
                Program.products.webcam = inputStream.ReadLine();
                //cleanup
                inputStream.Close();
                inputStream.Dispose();
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //open the stream to write
            using (StreamWriter outputString = new StreamWriter(
                File.Open("Product.txt", FileMode.Create)))
            {
                //write stuff to the file
                outputString.WriteLine(ProductIDtextBox);
                outputString.WriteLine(costTextBox);
                outputString.WriteLine(ManufacturertextBox);
                outputString.WriteLine(modeltextBox);
                outputString.WriteLine(MemorytextBox);
                outputString.WriteLine(LCDtextBox);
                outputString.WriteLine(CPUBrandtextBox);
                outputString.WriteLine(CPUTypetextBox);
                outputString.WriteLine(CPUspeedtextBox);
                outputString.WriteLine(CPUNumbertextBox);
                outputString.WriteLine(ConditiontextBox);
                outputString.WriteLine(OStextBox);
                outputString.WriteLine(platformtextBox);
                outputString.WriteLine(HDDtextBox);
                outputString.WriteLine(GPUTypetextBox);
                outputString.WriteLine(WebCamtextBox);
                //cleanup
                outputString.Close();
                outputString.Dispose();
            }
        }

        private void ProductInfoForm_Activated(object sender, EventArgs e)
        {
            //open File To Stream to read
            using (StreamReader inputStream = new StreamReader(
                File.Open("Product.txt", FileMode.Open)))
            {
                //Read stuff to the file into the Student Object
                Program.products.productID = short.Parse(inputStream.ReadLine());
                Program.products.cost = decimal.Parse(inputStream.ReadLine());
                Program.products.manufacturer = inputStream.ReadLine();
                Program.products.model = inputStream.ReadLine();
                Program.products.RAM_size = inputStream.ReadLine();
                Program.products.screensize = inputStream.ReadLine();
                Program.products.CPU_brand = inputStream.ReadLine();
                Program.products.CPU_type = inputStream.ReadLine();
                Program.products.CPU_speed = inputStream.ReadLine();
                Program.products.CPU_number = inputStream.ReadLine();
                Program.products.condition = inputStream.ReadLine();
                Program.products.OS = inputStream.ReadLine();
                Program.products.platform = inputStream.ReadLine();
                Program.products.HDD_size = inputStream.ReadLine();
                Program.products.GPU_Type = inputStream.ReadLine();
                Program.products.webcam = inputStream.ReadLine();

                //cleanup
                inputStream.Close();
                inputStream.Dispose();

                ProductIDtextBox.Text = Program.products.productID.ToString();
                costTextBox.Text = String.Format("{0:C}", Program.products.cost);
                ManufacturertextBox.Text = Program.products.manufacturer;
                modeltextBox.Text = Program.products.model;
                MemorytextBox.Text = Program.products.RAM_size;
                LCDtextBox.Text = Program.products.screensize;
                CPUBrandtextBox.Text = Program.products.CPU_brand;
                CPUTypetextBox.Text = Program.products.CPU_type;
                CPUspeedtextBox.Text = Program.products.CPU_speed;
                CPUNumbertextBox.Text = Program.products.CPU_number;
                ConditiontextBox.Text = Program.products.condition;
                OStextBox.Text = Program.products.OS;
                platformtextBox.Text = Program.products.platform;
                HDDtextBox.Text = Program.products.HDD_size;
                GPUTypetextBox.Text = Program.products.GPU_Type;
                WebCamtextBox.Text = Program.products.webcam;                
            }
            }
        }
}
