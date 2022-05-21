using System;
using System.Collections.Generic;
using System.Text;

namespace lab2_mw63028
{
    class Osoba
    {
        protected string imie;
        protected string nazwisko;
        protected string dataUrodzenia;
        
        public Osoba(string imie_,string nazwisko_, string dataUrodzenia_)
        {
            imie = imie_;
            nazwisko = nazwisko_;
            dataUrodzenia = dataUrodzenia_;
        }
        public virtual void wypiszInfo()
        {
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("Imie: " + imie) ;
            Console.WriteLine("Nazwisko: " + nazwisko);
            Console.WriteLine("Data urodzenia: " + dataUrodzenia +"\n");
            Console.WriteLine("---------------------------------------------------------------------");

        }
    }
}
