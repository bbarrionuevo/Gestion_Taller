using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Windows.Forms.DataVisualization.Charting;
using BLL;
using BE;

namespace UI
{
    public partial class FrmInformes : Form
    {
        private BLLClsServicio BLLservicio;

        public FrmInformes()
        {
            InitializeComponent();
            // Inicializar el objeto BLLClsServicio
            BLLservicio = new BLLClsServicio();
        }

        private void FrmInformes_Load(object sender, EventArgs e)
        {

            // Obtener el servicio más contratado
            List<BEClsServicio> servicios = BLLservicio.ObtenerServicios();



            // Contar la cantidad de servicios Premium (donde Filtro es True)
            int cantidadPremium = servicios.Count(s => s.Filtro);

            // Contar la cantidad de servicios Básicos (donde Filtro es False)
            int cantidadBasico = servicios.Count(s => !s.Filtro);

            string serviciosMasContratado;
            string serviciosMenosContratado;
            int contMasContratado;
            int contMenosContratado;
            // Determinar el tipo de servicio más contratado
            if (cantidadPremium > cantidadBasico)

            {
                serviciosMasContratado = "Premium";
                serviciosMenosContratado = "Basico";
                contMasContratado = cantidadPremium;
                contMenosContratado = cantidadBasico;

            }
            else
            {
                serviciosMasContratado = "Basico";
                serviciosMenosContratado = "Premium";
                contMasContratado = cantidadBasico;
                contMenosContratado = cantidadPremium;
            }



            // Limpiar el gráfico
            chart1.Series.Clear();
            chart1.Series.Add("ServicioMasContratado");
            chart1.Series["ServicioMasContratado"].ChartType = SeriesChartType.Pie;

            // Agregar los datos al gráfico
            chart1.Series["ServicioMasContratado"].Points.AddXY(serviciosMasContratado, contMasContratado);





            // Mostrar el servicio menos contratado en el gráfico chart2
            chart2.Series.Clear();
            chart2.Series.Add("ServicioMenosContratado");
            chart2.Series["ServicioMenosContratado"].ChartType = SeriesChartType.Column;

            // Agregar los datos al gráfico
            chart2.Series["ServicioMenosContratado"].Points.AddXY(serviciosMenosContratado, contMenosContratado);



            // Mostrar el monto total recaudado por tipo de servicio en el gráfico chart3
            // Mostrar el monto total recaudado por tipo de servicio en el gráfico chart3
            chart3.Series.Clear();
            chart3.Series.Add("MontoTotalPorTipoServicio");
            chart3.Series["MontoTotalPorTipoServicio"].ChartType = SeriesChartType.Pie;

            // Agregar los datos al gráfico
            foreach (var montoPorTipo in servicios)
            {
                string tipoServicio = montoPorTipo.Filtro ? "Premium" : "Básico";
                DataPoint point = new DataPoint();
                point.SetValueY(montoPorTipo.Precio);
                point.AxisLabel = tipoServicio;
                if (tipoServicio == "Premium")
                {
                    point.Color = Color.Blue; // Asignar color azul para Premium
                }
                else
                {
                    point.Color = Color.Green; // Asignar color verde para Básico
                }
                chart3.Series["MontoTotalPorTipoServicio"].Points.Add(point);
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
