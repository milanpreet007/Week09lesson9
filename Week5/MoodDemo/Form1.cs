using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoodDemo
{
    public partial class Form1 : Form
    {
        Mood mood = new Mood(0.9, 0.02, .5, 0.03, .7, 0.05);
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.BackColor = mood.Color;
            this.Invalidate();
        }
    }
}
