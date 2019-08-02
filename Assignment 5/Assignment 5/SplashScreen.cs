using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_5
{
    public partial class SplashScreenForm : Form
    {
        public SplashScreenForm()
        {
            InitializeComponent();
        }/// <summary>
        /// this is the vent handler for the form load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void SplashScreenForm_Load(object sender, EventArgs e)
        {
            splashtimer.Enabled = true;
        }
        /// <summary>
        /// this is the event handler for the splash timer tick event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Splashtimer_Tick(object sender, EventArgs e)
        {
            splashtimer.Enabled = false;
            Program.startForm.Show();
            this.Hide();
        }
    }
}
