using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePatika
{
    public class Focus : ICar
    {
        public Constants.Brand HerBrand()
        {
            return Constants.Brand.Ford;
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
