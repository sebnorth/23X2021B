using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Prostokat : IComparable
    {
        int szerokosc;
        int wysokosc;
        //private int v1;
        //private int v2;

        public Prostokat(int szerokosc, int wysokosc)
        {
            this.szerokosc = szerokosc;
            this.wysokosc = wysokosc;
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Prostokat otherProstokat = obj as Prostokat;
            if (otherProstokat != null)
            {

                // jeśli pole Prostokat < pole otherProstokat zwróć -1
                // pole Prostokat = this.szerokosc*this.wysokosc
                // jeśli pole Prostokat > pole otherProstokat zwróć 1
                // jeśli pole Prostokat ==  pole otherProstokat zwróć 0
                int poleProstokat = this.szerokosc*this.wysokosc;
                int poleOtherProstokat = otherProstokat.szerokosc*otherProstokat.wysokosc;

                if (poleProstokat < poleOtherProstokat)
                {
                    return -1;
                }

                if (poleOtherProstokat < poleProstokat)
                {
                    return 1;
                }

                else {

                    return 0;
                }

            }
          
            else
                throw new ArgumentException("Object is not a Prostokat");
        }

    }
}
