using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalcluator
{
    public partial class BMIcalculator : Form
    {
        public BMIcalculator()
        {
            InitializeComponent();
        }

        double HEIGHT, weight,bmiresult;

        private void BMItableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ClearFormbutton_Click(object sender, EventArgs e)
        {
            HeightTextbox.Text = " ";
            WeighttextBox.Text = " ";
            BMIresulttextBox.Text = " ";
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        
        private void CalculateBMIbutton_Click(object sender, EventArgs e)
        {
            HEIGHT = Convert.ToDouble(HeightTextbox.Text);
            weight = Convert.ToDouble(WeighttextBox.Text);

            if (ImpericalradioButton.Checked)
            {
                bmiresult = weight * 703 / Math.Pow(HEIGHT, 2);
                BMIresulttextBox.Text = bmiresult.ToString();
            }
            else
            {
                bmiresult = weight / Math.Pow(HEIGHT, 2);
                BMIresulttextBox.Text = bmiresult.ToString();
            }

        }
    }
}
