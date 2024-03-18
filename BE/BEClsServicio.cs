using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEClsServicio
    {
        public int ID { get; set; } 
        public string Fecha { get; set; }
        public BEClsCliente Cliente { get; set; }
        public BEClsAceite Aceite { get; set; }
        public int LitrosAceite { get; set; }
        public double Precio { get; set; }
        public int Descuento;

        public bool Filtro { get; set; }
        public BEClsServicio(int id)
        {
            ID = id;   
        }

        public BEClsServicio() 
        {
            
        }
        

    }
}
