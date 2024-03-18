using BE;
using MPP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLClsVehiculo
    {
        MPPClsVehiculo mPPClsVehiculo;
        public BLLClsVehiculo()

        { mPPClsVehiculo = new MPPClsVehiculo(); }
        public bool Guardar(BEClsVehiculo BEVehiculo)
        {
            return mPPClsVehiculo.Guardar(BEVehiculo);
        }
        
        public BEClsVehiculo Vehiculo_Por_Patente(string patente) 
        {

            return mPPClsVehiculo.Vehiculo_Por_Patente(patente);
        }
        public List<BEClsVehiculo> ListarTodo()
        { 
            return mPPClsVehiculo.ObtenerVehiculos(); 

        
        }




    }
}
