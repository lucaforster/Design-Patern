using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern
{
    public class SingeltonPattern
    {
        public string name;

        private static SingeltonPattern Waitor;

        private SingeltonPattern()
        {
        }
        
        public static SingeltonPattern getInstance()
        {
            if (Waitor == null)
            {
                Waitor = new SingeltonPattern();
            }
            return Waitor;
        }


        public void setName(string Name)
        {
            name = Name;
        }

        public string Bestellung()
        {
            return name + "Was möchten sie bestellen?";
        }

        public string Bezahlung()
        {
            return name + "Möchten sie schon bezahlen";
        }
    }
}
