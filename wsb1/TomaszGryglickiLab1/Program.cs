using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TomaszGryglickiLab1.Figury;

/* Labolatorium 1 Tomasz Gryglicki GD34639 / ILN4_AS lastModified: 2017-03-15
1. Przygotuj kod klas do zamodelowania figur szachowych. 
2. Klasy powinny być umieszczone w osobnym namespace (katalogu)
3. Klasa nadrzędna (rodzic), abstrakcyjna - Figura
4. parametry lub właściwości t.j. nazwa, pozycja, kolor
5. metoda sprawdzająca czy można przesunąć figurę na wybrane pole
6. wyświetlanie obiektu w postaci tekstowej (metoda ToString)
7. ew. metody pomocnicze
8. Klasy potomne - 4 wybrane figury szachowe (król, hetman, goniec, skoczek, wieża, pionek)
*/
namespace TomaszGryglickiLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            // <-Ustawienia domyslne
            Figury.Pionek WybieramPionek = new Pionek();
            string Nazwa = WybieramPionek.nazwa; // domyslnie wybieram figure
            Figury.Kolor WybieramKolor = new Kolor();
            string Kolor = WybieramKolor.KolorCzarny; // domyslnie ustawiam kolor
            // ->Ustawienia domyslne

            // Pozycja figury
            string aktualnaPozycja = "D4"; // aktualna pozycja figury na polu
            string nowaPozycja     = "E4"; // nowa pozycja figury
           
            Console.WriteLine("Wybrano domyślnie figurę: {0}", Nazwa);
            Console.WriteLine("Wybrano domyślnie kolor: {0}", Kolor);

            Pozycja p1 = new Pozycja(aktualnaPozycja);
            Pozycja p2 = new Pozycja(nowaPozycja);

            Console.WriteLine("Aktualna pozycja figury: {0}", aktualnaPozycja);
            Console.Write("Nowa pozycja figury: {0} ", nowaPozycja);
            WybieramPionek.CzyRuchJestMozliwy(Nazwa, p1.X, p1.Y, p2.X, p2.Y);

            Console.ReadKey();
        }
    }
}
