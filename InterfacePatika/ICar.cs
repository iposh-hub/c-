using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static InterfacePatika.Constants;

namespace InterfacePatika
{
    public interface ICar
    {
        int HerWheelNumber();
        Brand HerBrand();
        Color HerColor();
    }
}
