using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePatika
{
    public class Corolla : ICar
    {
        public Constants.Brand HerBrand()
        {
            return Constants.Brand.Toyota;
        }

        public Constants.Color HerColor()
        {
            return Constants.Color.Beyaz;
        }

        public int HerWheelNumber()
        {
            return 4;
        }
    }
}
