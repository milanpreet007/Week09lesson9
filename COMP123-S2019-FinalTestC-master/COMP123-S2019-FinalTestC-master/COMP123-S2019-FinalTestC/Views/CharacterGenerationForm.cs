using COMP123_S2019_FinalTestC.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            int.Parse(StrengthDataLabel.Text) = RandomNuber(1,15);
            int.Parse(DexterityDataLabel.Text) = RandomNuber(1, 15);
            int.Parse(IntellectDataLabel.Text) = RandomNuber(1, 15);
            int.Parse(EnduranceDataLabel.Text) = RandomNuber(1, 15);
            int.Parse(EducationDataLabel.Text) = RandomNuber(1, 15);
        }

        private void FileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // configure the file dialog
            StudentOpenFileDialog.FileName = "Student.txt";
            StudentOpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            StudentOpenFileDialog.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";

            // open the file dialog
            var result = StudentOpenFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                try
                {
                    // Open the  streawm for reading
                    using (StreamReader inputStream = new StreamReader(
                        File.Open(StudentOpenFileDialog.FileName, FileMode.Open)))
                    {
                        // read from the file
                        Program.student.id = int.Parse(inputStream.ReadLine());
                        Program.student.StudentID = inputStream.ReadLine();
                        Program.student.FirstName = inputStream.ReadLine();
                        Program.student.LastName = inputStream.ReadLine();

                        // cleanup
                        inputStream.Close();
                        inputStream.Dispose();
                    }

                    NextButton_Click(sender, e);
                }
                catch (IOException exception)
                {

                    Debug.WriteLine("ERROR: " + exception.Message);

                    MessageBox.Show("ERROR: " + exception.Message, "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (FormatException exception)
                {
                    Debug.WriteLine("ERROR: " + exception.Message);

                    MessageBox.Show("ERROR: " + exception.Message + "\n\nPlease select the appropriate file type", "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
    }
}

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // configure the file dialog
            Charac.FileName = "Character.txt";
            StudentSaveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            StudentSaveFileDialog.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";

            // open the file dialog
            var result = StudentSaveFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                // open the stream for writing
                using (StreamWriter outputStream = new StreamWriter(
                    File.Open(StudentSaveFileDialog.FileName, FileMode.Create)))
                {
                    // write content - string type - to the file
                    outputStream.WriteLine(Program.student.id.ToString());
                    outputStream.WriteLine(Program.student.StudentID);
                    outputStream.WriteLine(Program.student.FirstName);
                    outputStream.WriteLine(Program.student.LastName);

                    // cleanup
                    outputStream.Close();
                    outputStream.Dispose();

                    // give feedback to the user that the file has been saved
                    // this is a "modal" form
                    MessageBox.Show("File Saved...", "Saving File...",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.characteraboutBox.Show();
            this.Hide();
        }