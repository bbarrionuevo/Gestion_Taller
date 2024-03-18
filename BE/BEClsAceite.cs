using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEClsAceite
    {

        public int ID { get; set; }
        public double Precio_Litro { get; set; }
        public BEClsAceite (int id) { ID = id; }
        public BEClsAceite() { }
    }
}
