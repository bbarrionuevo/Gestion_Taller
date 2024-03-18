using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEClsSemiSintetico : BEClsAceite
    {
        public BEClsSemiSintetico (double precio = 1000):base() 
        { Precio_Litro = precio; ID = 2; }
    }
}
