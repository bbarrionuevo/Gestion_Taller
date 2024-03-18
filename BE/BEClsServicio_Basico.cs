using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEClsServicio_Basico: BEClsServicio
    {
        
        public BEClsServicio_Basico() :base() 
        {
            
            Filtro = false;
            Descuento = 10;
        }
        public BEClsServicio_Basico(int id)
        {
            Filtro = false;
            ID = id;
            Descuento = 10;
        }
    }
}
