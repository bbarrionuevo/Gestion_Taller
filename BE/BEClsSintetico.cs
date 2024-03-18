using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEClsSintetico : BEClsAceite
    {
        public BEClsSintetico(double precio = 1500) : base()
        { Precio_Litro = precio; ID = 1; }
    }
}
