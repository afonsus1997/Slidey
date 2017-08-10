using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


//using https://thielj.github.io/MetroFramework/#GettingStarted interface



namespace Slidey
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
            


            Form Form1 = new Form1();
            

            Application.Run(Form1);
        }
    }
}
