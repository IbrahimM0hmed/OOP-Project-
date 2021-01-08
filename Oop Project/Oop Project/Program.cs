using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Oop_Project
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
            // read file
            FileStream file = new FileStream("data.txt", FileMode.OpenOrCreate);
            StreamReader reader = new StreamReader(file);
        //    reader.ReadLine();
            Application.Run(new Form1());
        }
    }
}
