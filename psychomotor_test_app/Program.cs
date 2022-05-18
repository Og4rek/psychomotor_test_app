using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*    
    TO DO:
    WSZEDZIE LADNE NAPISY ZROBIC I OPISAC WSZYSTKO Wyswietlac wyniki i resetowac
    test 4 - 
                5) sprawdzanie poprawnosci wcisniecia
 */
namespace psychomotor_test_app
{
    internal static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
