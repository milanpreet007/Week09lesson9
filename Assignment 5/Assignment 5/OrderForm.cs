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
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
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

                conditiontextBox.Text = Program.products.productID.ToString();
                platformtextBox.Text = String.Format("{0:C}", Program.products.cost);
                manufacturertextBox.Text = Program.products.manufacturer;
                modeltextBox.Text = Program.products.model;
                MemorytextBox.Text = Program.products.RAM_size;
                LCDSizetextbox.Text = Program.products.screensize;
                CPUBrandtextBox.Text = Program.products.CPU_brand;
                CPUTypetextBox.Text = Program.products.CPU_type;
                CPUspeedtextBox.Text = Program.products.CPU_speed;
                CPUNumbertextBox.Text = Program.products.CPU_number;
                OStextBox.Text = Program.products.OS;
                platformtextBox.Text = Program.products.platform;
                HDDtextBox.Text = Program.products.HDD_size;
                GPUTypetextBox.Text = Program.products.GPU_Type;
                WebCamtextBox.Text = Program.products.webcam;

            }
    }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            Program.productInfoForm.Show();
            this.Hide();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Memorylabel_Click(object sender, EventArgs e)
        {

        }

        private void CPUTypelabel_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
