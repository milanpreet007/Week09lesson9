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
    {
        //Class properties
        public string OutputString { get; set; }
        public float OutputValue { get; set; }
        public bool decimalExists  { get; set; }
        /// <summary>
        /// this is the  constructor for the calculator form
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
           Button TheButton = sender as Button;
            var tag = TheButton.Tag.ToString();
            int numericValue = 0;

            bool numericResult = int.TryParse(tag, out numericValue);
            if(numericResult)
            {
                if (OutputString == "0")
                {
                    OutputString = tag;     
                }
                else
                {
                    OutputString += tag;
                }

                resultlabel.Text = OutputString;
            }
            else
            {
                switch(tag)
                {
                    case "back":
                        var lastChar = OutputString.Substring(OutputString.Length - 1);
                            if(lastChar == ".")
                        {
                            decimalExists = false;
                        }
                       OutputString= OutputString.Remove(OutputString.Length - 1);

                        if(OutputString.Length == 0)
                        {
                            OutputString = "0";
                        }

                        resultlabel.Text = OutputString;
                        break;
                    case "done":
                        OutputValue = float.Parse(OutputString);
                        clearNumerickeyboard();
                        Heightlabel.Text = OutputValue.ToString();
                        CalculatorButtonTableLayoutPanel.Visible = false;
                        break;
                    case "clear":
                        clearNumerickeyboard();
                        break;
                    case "decimal":
                        if(!decimalExists)
                        {
                            OutputString += ".";

                        }
                        break;
                }
            }
        }
/// <summary>
/// this method resets the numeric keyboard and related variables
/// </summary>
        private void clearNumerickeyboard()
        {
            resultlabel.Text = "0";
            OutputString = "0";
            OutputValue = 0.0f;
            decimalExists = false;
        }

        private void Resultlabel_Click(object sender, EventArgs e)
        {

        }

        private void Backbutton_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// this is the event handler for the form load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculatorForm_Load(object sender, EventArgs e)
        {
            clearNumerickeyboard();
            CalculatorButtonTableLayoutPanel.Visible = false;
        }
        /// <summary>
        /// this is the event handler for the height label click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Heightlabel_Click(object sender, EventArgs e)
        {
            CalculatorButtonTableLayoutPanel.Visible = true;
        }
    }
}
