using COMP123_S2019_FinalTestC.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace COMP123_S2019_FinalTestC.Objects
{
    public static class Program
    {
       
        public static CharacterGenerationForm characterForm;
        public static CharacterPortfolio characterportfolio;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            characterForm = new CharacterGenerationForm();
            characterportfolio = new CharacterPortfolio();
            Application.Run(characterForm);
        }
    }
}
