using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baca_Analizorleri_Kontrolu
{
    internal static class Program
    {
        static public string conString = "Data Source=DESKTOP-A4E0SUU\\ZYDB;Initial Catalog = DBElektrikDepartmani; Integrated Security = True";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AnaMenu());
        }
    }
}
