using BE;
using MPP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLClsServicio
    {
        MPPClsServicio mPPClsServicio;

        public BLLClsServicio()
        {
            mPPClsServicio = new MPPClsServicio();
        }

        public bool GuardarServicio(BEClsServicio bEServicio)
        {
            return mPPClsServicio.GuardarServicio(bEServicio);
        }

        public bool DarDeBajaServicio(BEClsServicio bEServicio)
        {
            return mPPClsServicio.DarDeBajaServicio(bEServicio);
        }

        public List<BEClsServicio> ObtenerServicios()
        {
            return mPPClsServicio.ObtenerServicios();

        }
        public object ObtenerServiciosDeCliente(BEClsCliente BECliente)
        {
           
            return (from s in mPPClsServicio.ObtenerServiciosDeCliente(BECliente) select new { ID_Servicio = s.ID, Cliente = s.Cliente.ID, Aceite_ID=s.Aceite.ID, Litros_De_Aceite=s.LitrosAceite, Filtro= s.Filtro.ToString(), Fecha=s.Fecha, Precio = s.Precio }).ToArray();
        }
        public double CalculaPrecio(BEClsServicio BEServicio)
        {
            BEServicio.Precio = BEServicio.Aceite.Precio_Litro * BEServicio.LitrosAceite;
            BEServicio.Precio = BEServicio.Precio-((BEServicio.Descuento * BEServicio.Precio )/ 100);
            return BEServicio.Descuento;
        }
        
        //public List<Object> ObtenerMontoTotalPorTipoServicio()
        //{
        //    // Lógica para obtener el monto total recaudado por tipo de servicio
        //    // Supongamos que tienes una lista de servicios con información sobre el monto recaudado por cada tipo de servicio
        //    List<BEClsServicio> servicios = ObtenerServicios(); // Suponiendo que tienes un método para obtener la lista de servicios

        //    var montoTotalPorTipoServicio = servicios
        //        .GroupBy(s => s.TipoServicio)
        //        .Select(g => new BEClsMontoPorTipo
        //        {
        //            TipoServicio = g.Key,
        //            MontoRecaudado = g.Sum(s => s.MontoRecaudado)
        //        })
        //        .ToList();

        //    return montoTotalPorTipoServicio;
        //}

    }
}