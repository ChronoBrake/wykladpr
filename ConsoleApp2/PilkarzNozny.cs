using System;
using System.Collections.Generic;
using System.Text;

namespace lab2_mw63028
{
    class PilkarzNozny: Pilkarz
    {
        public PilkarzNozny(string imie_, string nazwisko_, string dataUrodzenia_, string pozycja_, string klub_):base(imie_,nazwisko_,dataUrodzenia_,pozycja_,klub_)
        {

        }
        public override void strzelGola()
        {
            base.strzelGola();
            Console.WriteLine("Nożny szelił! \n");
        }
    }
}
