using Ristorante.Mamma.Carielo.WinForms;
using System;
using System.Windows.Forms;

namespace Ristorante.Mamma.Carielo
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormInicial());
        }
    }
}
