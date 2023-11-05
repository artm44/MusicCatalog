using System;
using System.Windows.Forms;
using MusicCatalog.Models;
using MusicCatalog.Models.InterfaceImplementations;
using MusicCatalog.Models.Interfaces;

namespace MusicCatalog
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ICatalog catalog = new Catalog(new DataFromDB());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HomeForm(catalog));
        }
    }
}
