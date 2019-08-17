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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// this is the event handler for the startform form closing event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// this is the event handler for starting a new order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Startneworderbutton_Click(object sender, EventArgs e)
        {
            Program.selectForm.Show();
            this.Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// this is the event handler for opening a sved file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenASavedOrderbutton_Click(object sender, EventArgs e)
        {
           // confgure the dile dialog
            OpenFileDialog.FileName = "Product.txt";
            OpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            OpenFileDialog.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";
            //open the file diolog
            var result = OpenFileDialog.ShowDialog();
            //open file stream to read
            using (StreamReader inputStream = new StreamReader(File.Open(OpenFileDialog.FileName, FileMode.Open)))
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
            Program.productInfoForm.Show();
            this.Hide();
        }
    }
}
