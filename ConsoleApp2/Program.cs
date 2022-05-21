using System;
using System.Collections.Generic;

namespace lab2_mw63028
{
    class Program
    {
        static void Main(string[] args)
        {
            //zad1


            Osoba o = new Osoba("Adam", "Miś", "20.03.1980");
            Osoba o2 = new Student("Michał", "Kot", "13.04.1990", 3, 2, 43543);
            Osoba o3 = new Pilkarz("Mateusz", "Żbik", "10.08.1986", "bramkarz", "FC Ekonomik");

            o.wypiszInfo();
            o2.wypiszInfo();
            o3.wypiszInfo();

            Student s = new Student("Krzysztof", "Jeż", "22.12.1990", 2, 5, 54321);
            Pilkarz p = new Pilkarz("Piotr", "Kos", "14.09.1984", "napastnik", "FC Ekonomik");

            s.wypiszInfo();
            p.wypiszInfo();

            ((Pilkarz)o3).strzelGola();
            p.strzelGola();
            p.strzelGola();

            o3.wypiszInfo();
            p.wypiszInfo();

            Console.WriteLine("================== WCISNIJ ENTER DLA ZAD2 ========================");

            Console.ReadKey();

            //zad2


            ((Student)o2).DodajOcene("PO", "20.02.2011", 5.0);
            ((Student)o2).DodajOcene("Bazy Danych", "13.02.2011", 4.0);

            o2.wypiszInfo();

            s.DodajOcene("Bazy danych", "01.05.2011", 5.0);
            s.DodajOcene("AWWW","11.05.2011",5.0);
            s.DodajOcene("AWWW","02.04.2011",4.5);

            s.wypiszInfo();

            s.UsunOcene("AWWW", "02.04.2011", 4.5);

            s.WypiszOceny();

            s.DodajOcene("AWWW","02.04.2011",4.5);
            s.UsunOceny("AWWW");

            s.wypiszInfo();

            s.DodajOcene("AWWW","02.04.2011",4.5);
            s.UsunOceny();

            s.wypiszInfo();


            Console.WriteLine("================== WCISNIJ ENTER DLA ZAD3 ========================");
            Console.ReadKey();

            //zad3
            

            PilkarzNozny p1 = new PilkarzNozny("Adrian", "Kowalski", "04.03.1998", "Napastnik", "Legia Warszawa");
            p1.strzelGola();
            p1.wypiszInfo();

            PilkarzReczny p2 = new PilkarzReczny("Wojtek","Polak", "08.01.1914","Bramkarz", "Stal Mielec");
            p2.strzelGola();
            p2.wypiszInfo();


            Console.ReadKey();
        }
    }
}
