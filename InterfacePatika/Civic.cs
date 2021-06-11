using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePatika
{
    public class Civic : ICar
    {
        public Constants.Brand HerBrand()
        {
            return Constants.Brand.Monda;
        }

        public Constants.Color HerColor()
        {
            return Constants.Color.Gri;
        }

        public int HerWheelNumber()
        {
            return 4;
        }
    }
}
