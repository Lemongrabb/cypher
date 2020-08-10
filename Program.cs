using System;
using System.Windows.Forms;

namespace Cypher
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        /// <summary>
        ///  Enumuerator of available cyphers
        /// </summary>
        public enum Cypher
        {
            Ceasar
        }
    }
}
