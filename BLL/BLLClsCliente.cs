using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using MPP;

namespace BLL
{
    public class BLLClsCliente
    {
        MPPClsCliente mPPClsCliente;
        public BLLClsCliente() 
        { mPPClsCliente = new MPPClsCliente(); }
        public bool Guardar(BEClsCliente bEClsCliente)
        {
            return mPPClsCliente.GuardarCliente(bEClsCliente);
        }
        public bool Baja(BEClsCliente bEClsCliente)
        {
            return mPPClsCliente.DarDeBajaCliente(bEClsCliente);
        }

        public object ListarTodo() 
        {
            return (from c in mPPClsCliente.ObtenerClientes() select new { Codigo_Cliente = c.ID, Nombre = c.Nombre, Apellido = c.Apellido, DNI = c.DNI, Vehiculo = c.Vehiculo.Patente, Mail = c.Mail, Fecha_Nacimiento = c.Fecha_Nacimiento }).ToArray();
            
        }
       

    }
}
