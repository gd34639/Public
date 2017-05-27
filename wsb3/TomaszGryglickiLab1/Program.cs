using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TomaszGryglickiLab1.Figury;

/* Labolatorium 3 Tomasz Gryglicki GD34639 / ILN4_AS lastModified: 2017-05-27
1. Dodaj do Figury obsługę zdarzeń informujących o przesunięciu figury. 
2. Zaimplementuj funkcję - delegatę która wyświetli informację, że wystąpiło zdarzenie.
3. Napisz metodę rozszerzającą która zwraca liczbę figur na szachownicy
*/
namespace TomaszGryglickiLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            // <-Ustawienia domyslne
            Figury.Pionek WybieramPionek = new Pionek();
            string Nazwa = WybieramPionek.nazwa;            // domyslnie wybieram figure

            Figury.Kolor WybieramKolor = new Kolor();      
            string Kolor = WybieramKolor.KolorCzarny;       // domyslnie ustawiam kolor

            int liczFigury = WybieramPionek.liczbaFigur(); // liczba figur

            //string licz = WybieramPionek.listaFigur.ToString;
            //
            // Pozycja figury
            //

            //old1
            //string aktualnaPozycja = "A4"; // aktualna pozycja figury na polu
            //string nowaPozycja     = "E4"; // nowa pozycja figury
            Szachownica szach = new Szachownica();
            szach[0] = "A4";
            szach[1] = "E4";
            
            Console.WriteLine("Wybrano domyślnie figurę: {0}", Nazwa);
            Console.WriteLine("Wybrano domyślnie kolor: {0}", Kolor);

            //old1
            //Pozycja p1 = new Pozycja(aktualnaPozycja);
            //Pozycja p2 = new Pozycja(nowaPozycja);
            Pozycja p1 = new Pozycja(szach[0]);
            Pozycja p2 = new Pozycja(szach[1]);

            //old1
            //Console.WriteLine("Aktualna pozycja figury: {0}", aktualnaPozycja);
            //Console.Write("Nowa pozycja figury: {0} ", nowaPozycja);
            Console.WriteLine("Aktualna pozycja figury: {0}", szach[0]);
            Console.WriteLine("Nowa pozycja figury: {0} ", szach[1]);
    
            //new3
            WybieramPionek.messageInfo += Szachownica.messageInfo;
            WybieramPionek.CzyRuchJestMozliwy(Nazwa, p1.X, p1.Y, p2.X, p2.Y);
            Console.WriteLine(".: Liczba figur na szachownicy: {0} ", liczFigury);
 
            Console.ReadKey();
        }

    }
}
