using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEClsServicio_Premium: BEClsServicio
    {
        
        public BEClsServicio_Premium() : base() 
        {
            Filtro = true;
            Descuento = 20;
        }
        public BEClsServicio_Premium(int id)
        {
            Filtro = true;
            ID = id;
            Descuento = 20;
        }
    }
}
