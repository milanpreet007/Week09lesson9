using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson9
{
    public partial class CalculatorForm : Form
    {/// <summary>
    /// this is the constructor for the calculator form
    /// </summary>
        public CalculatorForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// this is the shared event handler for all the calculator buttons - click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculatorButton_Click(object sender, EventArgs e)
        {
            var TheButton = sender as Button;

            int buttonValue;
            bool resultCondition = int.TryParse(TheButton.Text,out buttonValue);

            if (resultCondition)
            {
                resultlabel.Text += TheButton.Text;
            }
            else
            {
                resultlabel.Text = "NAN";
            }
        }

        private void Resultlabel_Click(object sender, EventArgs e)
        {

        }

        private void Backbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
