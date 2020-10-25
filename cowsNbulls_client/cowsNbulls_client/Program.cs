using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;
using System.Windows.Forms;

namespace cowsNbulls_client
{

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>


        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            GameLogic g = new GameLogic();
            Application.Run(new menu(g));
            //game gameForm = new game(g);
            //Application.Run(gameForm);
        }
        
    }
}
