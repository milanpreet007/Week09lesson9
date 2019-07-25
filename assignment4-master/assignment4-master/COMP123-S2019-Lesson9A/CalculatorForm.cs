﻿/*
 * Name- Milanpreet Singh
 * Student Number-301044674
 * date last modified-25-7-2019
 * this is a BMI calculator it uses the height,weight of the individual to calculate the BMI both in imperical and
 * metric units.
 * 
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lesson9A
{
    public partial class CalculatorForm : Form
    {
        // PRIVATE DATA MEMBERS
        private Label m_activeLabel;

        // PUBLIC PROPERTIES
        public string outputString { get; set; }
        public float outputValue { get; set; }
        public bool decimalExists { get; set; }
        double HEIGHT, weight, bmiresult;

        public Label ActiveLabel
        {
            get
            {
                return m_activeLabel;
            }

            set
            {
                // check if m_activeLabel is already pointing at a label
                if(m_activeLabel != null)
                {
                    m_activeLabel.BackColor = Color.White;
                }

                m_activeLabel = value;

                // check if m_activeLabel has not been set to null
                if(m_activeLabel != null)
                {
                    m_activeLabel.BackColor = Color.LightBlue;
                }
                
            }
        }

        /// <summary>
        /// This is the Constructor Method
        /// </summary>
        public CalculatorForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the event handler for the form load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculatorForm_Load(object sender, EventArgs e)
        {
            this.Size = new Size(320, 480);

            clearNumericKeyboard();
            NumberButtonTableLayoutPanel.Visible = false;
        }

        /// <summary>
        /// This is the event handler for the form click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculatorForm_Click(object sender, EventArgs e)
        {
            NumberButtonTableLayoutPanel.Visible = false;

            ActiveLabel = null;
            clearNumericKeyboard();
        }

        /// <summary>
        /// This is the shared Event Handler for all of the Calculator Buttons' Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculatorButtons_Click(object sender, EventArgs e)
        {
            Button TheButton = sender as Button;
            var tag = TheButton.Tag.ToString();
            int numericValue = 0;

            bool numericResult = int.TryParse(tag, out numericValue);

            if(numericResult)
            {
                int maxSize = (decimalExists) ? 5 : 3;

                if(outputString == "0")
                {
                    outputString = tag;
                }
                else if (outputString.Length < maxSize)
                {
                        outputString += tag;
                }
                    
                ResultLabel.Text = outputString;
            }
            else
            {
                switch (tag)
                {
                    case "back":
                        removeLastCharacterFromResultLabel();
                        break;
                    case "done":
                        finalizeOuput();
                        break;
                    case "clear":
                        clearNumericKeyboard();
                        break;
                    case "decimal":
                        addDecimalToResultLabel();
                        break;
                }
            }
        }

        /// <summary>
        /// This method adds a decimal point to the resultLabel
        /// </summary>
        private void addDecimalToResultLabel()
        {
            if (!decimalExists)
            {
                outputString += ".";
                decimalExists = true;
            }
        }


        /// <summary>
        /// This method finalizes and converts the outputString to a floating point value
        /// </summary>
        private void finalizeOuput()
        {
          
            outputValue = float.Parse(outputString);

            outputValue = (float)(Math.Round(outputValue, 1));

            if (outputValue < 0.1f)
            {
                outputValue = 0.1f;
            }
            ActiveLabel.Text = outputValue.ToString();
            clearNumericKeyboard();
            NumberButtonTableLayoutPanel.Visible = false;
            ActiveLabel.BackColor = Color.White;
            ActiveLabel = null;
        }


        /// <summary>
        /// This method removes the last character from the Result Label
        /// </summary>
        private void removeLastCharacterFromResultLabel()
        {
            var lastChar = outputString.Substring(outputString.Length - 1);
            if (lastChar == ".")
            {
                decimalExists = false;
            }
            outputString = outputString.Remove(outputString.Length - 1);

            if (outputString.Length == 0)
            {
                outputString = "0";
            }

            ResultLabel.Text = outputString;
        }

        /// <summary>
        /// This method resets the numeric keyboard and related variables
        /// </summary>
        private void clearNumericKeyboard()
        {
            ResultLabel.Text = "0";
            outputString = "0";
            outputValue = 0.0f;
            decimalExists = false;
            BMIresulttextBox.Text = "0";
        }
        /// <summary>
        /// this is the event handler for calculating BMI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateBMIButton_Click(object sender, EventArgs e)
        {
            HEIGHT = Convert.ToDouble(HeightTextbox.Text);
            weight = Convert.ToDouble(WeighttextBox.Text);

            if (ImpericalradioButton.Checked)
            {
                bmiresult = weight * 703 / Math.Pow(HEIGHT, 2);
                BMIresulttextBox.Text = bmiresult.ToString();
                if (bmiresult < 18.5)
                {
                    BMIscaletextBox.Text = "Underweight";
                }
                else if (bmiresult > 18.5 && bmiresult < 24.9)
                {
                    BMIscaletextBox.Text = "Normal";
                }
                else if (bmiresult > 24.9 && bmiresult < 29)
                {
                    BMIscaletextBox.Text = "overweight";
                }
                else if (bmiresult > 30 )
                {
                    BMIscaletextBox.Text = "obese";
                }
            }
            else
            {
                bmiresult = weight / Math.Pow(HEIGHT, 2);
                BMIresulttextBox.Text = bmiresult.ToString();
                if (bmiresult < 18.5)
                {
                    BMIscaletextBox.Text = "Underweight";
                }
                else if (bmiresult > 18.5 && bmiresult < 24.9)
                {
                    BMIscaletextBox.Text = "Normal";
                }
                else if (bmiresult > 24.9 && bmiresult < 29)
                {
                    BMIscaletextBox.Text = "overweight";
                }
                else if (bmiresult > 30)
                {
                    BMIscaletextBox.Text = "obese";
                }
            }
        }



        /// <summary>
        /// This is the event handler for the HeightLabel click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ActiveLabel_Click(object sender, EventArgs e)
        {
            
            if(ActiveLabel != null)
            {
                clearNumericKeyboard();
            }

            ActiveLabel = sender as Label;
            ActiveLabel.BackColor = Color.LightBlue;

            AnimationTimer.Enabled = true;

            //NumberButtonTableLayoutPanel.Location = new Point(12, ActiveLabel.Location.Y + 55);
            NumberButtonTableLayoutPanel.BringToFront();

            if (ActiveLabel.Text != "0")
            {
                outputString = ActiveLabel.Text;
                ResultLabel.Text = ActiveLabel.Text;
            }


            NumberButtonTableLayoutPanel.Visible = true;
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            var currentLocation = NumberButtonTableLayoutPanel.Location;
            NumberButtonTableLayoutPanel.Location = new Point(currentLocation.X, currentLocation.Y - 20);

            if (NumberButtonTableLayoutPanel.Location.Y <= ActiveLabel.Location.Y + 55)
            {
                AnimationTimer.Enabled = false;
                if (NumberButtonTableLayoutPanel.Location.Y < ActiveLabel.Location.Y + 55)
                {
                    NumberButtonTableLayoutPanel.Location = new Point(currentLocation.X, ActiveLabel.Location.Y + 55);
                }
            }

        }
    }
}
