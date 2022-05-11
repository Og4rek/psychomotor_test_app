using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
    Po kliknieciu na kazdy z przyciskow wyswietlone zostanie okno z infomacjami na temat testu, 
    nastepnie psystapisz do szkolenia polegajacego na wykonaniu testu bez oceny, 
    po szkoleniu nastapi wlasciwy test po ktorym uzyskasz ocene i wyniki.
    Jesli chcesz wyswietlic wyniki i ocene kliknij przycisk wyniki. 
    jesli chcesz zapisac wyniki w pliku pdf kliknij zapisz wyniki. 
    jesli chcesz zresetowac test kliknij reset
    test 1 - swiatelka f1
    test 2 - rozne swiatelka zapalane i trzeba w nie klikac
    test 3 - dzwiek i reakcja 
    test 4 - rozny dzwiek i rozne przyciski trzeba klikac 
    test 5 - matryca swiatelek

    do test 1 dodac obsluge prawdziwego testu i zapysywac do pliku
    do testu 2 liczyc czas sredni i calkowity i zapystwac do pliku
    do testu 3 liczyc czas i zrobic ten dzwiek i wyswietlanie
    do testu 4 wgrac 3 rozne dzwieki i liczyc czas
    matryca swiatelek te swiatelka zrobic i ierzyc czas i poprawnosc wcisnieia


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
