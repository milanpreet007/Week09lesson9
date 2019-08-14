using COMP123_S2019_FinalTestC.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

/*
 * STUDENT NAME:
 * STUDENT ID:
 * DESCRIPTION: This is the main form for the application
 */

namespace COMP123_S2019_FinalTestC.Views
{
    public partial class CharacterGenerationForm : COMP123_S2019_FinalTestC.Views.MasterForm
    {
        public CharacterGenerationForm()
        {
            InitializeComponent();
        }
       public static string[] AllLines;
        public static string[] AllLine;
        /// <summary>
        /// This is the event handler for the BackButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            if(MainTabControl.SelectedIndex != 0)
            {
                MainTabControl.SelectedIndex--;
            }
        }

        /// <summary>
        /// This is the event handler for the NextButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            if(MainTabControl.SelectedIndex < MainTabControl.TabPages.Count - 1)
            {
                MainTabControl.SelectedIndex++;
            }
        }

        private void GenerateNameButton_Click(object sender, EventArgs e)
        {  
            Program.characterportfolio.Identity.FirstName = FirstNameDataLabel.Text;
            Program.characterportfolio.Identity.LastName = LastNameDataLabel.Text;
        }

        private void CharacterGenerationForm_Load(object sender, EventArgs e)
        {
            GenerateNameButton_Click(sender,e);
        }

        private void GenerateSkillsbutton_Click(object sender, EventArgs e)
        {
            string[] SkillsList;
            SkillsList = File.ReadAllLines("skills.txt");
            Random rand = new Random();
            int index = rand.Next(SkillsList.Length);
            FirstSkilllabel.Text = SkillsList.[index];
        }
        public static void LoadNames()
        {
            //Entering the First Name
            
            AllLines = File.ReadAllLines("firstNames.txt");
            //Entering the Last Name
            
            AllLine = File.ReadAllLines("lastNames.txt");

        }
        public static void GenerateNames()
        {
            Random rand = new Random();
            int index = rand.Next(AllLines.Length);
            FirstNameDataLabel.Text = AllLines[index];
            Random rands = new Random();
            int indexs = rand.Next(AllLine.Length);
            LastNameDataLabel.Text = AllLine[indexs];
        }
        
            public int RandomNuber(int min,int max)
            {
            Random random = new Random();
            return random.Next(1, 15);
            }
        
        private void MainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FirstNameDataLabel_Click(object sender, EventArgs e)
        {

        }

        private void FirstNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void GenerateAbilitiesButton_Click(object sender, EventArgs e)
        {

        }
    }
}
