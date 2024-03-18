using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Gestion_Taller
{
    public partial class Form1 : Form
    {
        BEClsSemiSintetico BESemiSintetico;
        BEClsSintetico BESintetico;
        BLLClsCliente BLLcliente;
        BEClsCliente BECliente;
        BEClsVehiculo Vehiculo;
        BLLClsVehiculo BLLVehiculo;
        BEClsServicio_Basico BEServicio_Basico;
        BEClsServicio_Premium BEServicio_Premium;
        BLLClsServicio BLLServicio;
        public Form1()
        {
            InitializeComponent();
            BLLcliente = new BLLClsCliente();
            Vehiculo = new BEClsVehiculo();
            BLLVehiculo = new BLLClsVehiculo();
            BECliente = new BEClsCliente();
            BESemiSintetico = new BEClsSemiSintetico();
            BESintetico = new BEClsSintetico();
            BEServicio_Basico = new BEClsServicio_Basico();
            BEServicio_Premium = new BEClsServicio_Premium();
            BLLServicio = new BLLClsServicio();

        }
        public void Mostrar(DataGridView pDGV, object p0)
        {
            pDGV.DataSource = null; pDGV.DataSource = p0;


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Mostrar(dataGridView1, BLLcliente.ListarTodo());
            Mostrar(dataGridVehiculo, BLLVehiculo.ListarTodo());

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            ABM_Cliente frmCliente = new ABM_Cliente();
            frmCliente.Show(); // Muestra el formulario
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count == 0) throw new Exception("Seleccione Cliente !!!");
                DataGridViewRow f = dataGridView1.SelectedRows[0];
                BEClsCliente BEcliente = new BEClsCliente(Convert.ToInt32(f.Cells[0].Value));
                if (comboBox4.Text == "Basico")
                {
                    BEServicio_Basico = new BEClsServicio_Basico();
                    BEServicio_Basico.Cliente = BEcliente;
                    BEServicio_Basico.Fecha = Fecha.Value.ToString();
                    if (comboBox1.Text == "Sintetico")
                    {
                        BEServicio_Basico.Aceite = BESintetico = new BEClsSintetico();
                    }

                    else
                    {
                        BEServicio_Basico.Aceite = BESemiSintetico = new BEClsSemiSintetico();
                    }

                    BEServicio_Basico.LitrosAceite = int.Parse(textBox6.Text);

                    MessageBox.Show("Se realizo un descuento del %" + BLLServicio.CalculaPrecio(BEServicio_Basico));
                    BLLServicio.GuardarServicio(BEServicio_Basico);

                }
                else
                {
                    BEServicio_Premium = new BEClsServicio_Premium();
                    BEServicio_Premium.Cliente = BEcliente;
                    BEServicio_Premium.Fecha = Fecha.Value.ToString();
                    if (comboBox1.Text == "Sintetico")
                    {
                        BEServicio_Premium.Aceite = BESintetico = new BEClsSintetico();
                    }

                    else
                    {
                        BEServicio_Premium.Aceite = BESemiSintetico = new BEClsSemiSintetico();
                    }

                    BEServicio_Premium.LitrosAceite = int.Parse(textBox6.Text);

                    MessageBox.Show("Se realizo un descuento del %" + BLLServicio.CalculaPrecio(BEServicio_Premium));
                    BLLServicio.GuardarServicio(BEServicio_Premium);
                }


                Mostrar(dataGridView3, BLLServicio.ObtenerServiciosDeCliente(BEcliente));
                MessageBox.Show("Alta de servicio realizada con éxito.");
            }

            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void dataGridView1__RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count == 0) throw new Exception("Seleccione Cliente !!!");
                DataGridViewRow f = dataGridView1.SelectedRows[0];
                BEClsCliente BEcliente = new BEClsCliente(Convert.ToInt32(f.Cells[0].Value));

                Mostrar(dataGridView3, BLLServicio.ObtenerServiciosDeCliente(BEcliente));

            }

            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        //modificar servicio
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count == 0) throw new Exception("Seleccione Cliente !!!");
                DataGridViewRow f = dataGridView1.SelectedRows[0];
                BEClsCliente BEcliente = new BEClsCliente(Convert.ToInt32(f.Cells[0].Value));
                if (dataGridView3.Rows.Count == 0) throw new Exception("No hay Servicio seleccionado !!!");
                DataGridViewRow s = dataGridView3.SelectedRows[0];
                if (comboBox4.Text == "Basico")
                {
                    BEServicio_Basico = new BEClsServicio_Basico(Convert.ToInt32(s.Cells[0].Value));
                    BEServicio_Basico.Cliente = BEcliente;
                    BEServicio_Basico.Fecha = Fecha.Value.ToString();
                    if (comboBox1.Text == "Sintetico")
                    {
                        BEServicio_Basico.Aceite = BESintetico = new BEClsSintetico();
                    }

                    else
                    {
                        BEServicio_Basico.Aceite = BESemiSintetico = new BEClsSemiSintetico();
                    }

                    BEServicio_Basico.LitrosAceite = int.Parse(textBox6.Text);

                    MessageBox.Show("Se realizo un descuento del %" + BLLServicio.CalculaPrecio(BEServicio_Basico));
                    BLLServicio.GuardarServicio(BEServicio_Basico);
                }
                else
                {
                    BEServicio_Premium = new BEClsServicio_Premium(Convert.ToInt32(s.Cells[0].Value));
                    BEServicio_Premium.Cliente = BEcliente;
                    BEServicio_Premium.Fecha = Fecha.Value.ToString();
                    if (comboBox1.Text == "Sintetico")
                    {
                        BEServicio_Premium.Aceite = BESintetico = new BEClsSintetico();
                    }

                    else
                    {
                        BEServicio_Premium.Aceite = BESemiSintetico = new BEClsSemiSintetico();
                    }

                    BEServicio_Premium.LitrosAceite = int.Parse(textBox6.Text);
                    MessageBox.Show("Se realizo un descuento del %" + BLLServicio.CalculaPrecio(BEServicio_Premium));

                    BLLServicio.GuardarServicio(BEServicio_Premium);
                }


                Mostrar(dataGridView3, BLLServicio.ObtenerServiciosDeCliente(BEcliente));
                MessageBox.Show("Alta de servicio realizada con éxito.");
            }

            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView3.Rows.Count == 0) throw new Exception("No hay nada para borrar !!!");
                DataGridViewRow s = dataGridView3.SelectedRows[0];
                BEClsServicio BEservicio = new BEClsServicio(Convert.ToInt32(s.Cells[0].Value));
                BLLServicio.DarDeBajaServicio(BEservicio);

                if (dataGridView1.Rows.Count == 0) throw new Exception("Seleccione Cliente !!!");
                DataGridViewRow f = dataGridView1.SelectedRows[0];
                BEClsCliente BEcliente = new BEClsCliente(Convert.ToInt32(f.Cells[0].Value));

                Mostrar(dataGridView3, BLLServicio.ObtenerServiciosDeCliente(BEcliente));
                MessageBox.Show("Baja Reserva realizada con éxito.");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }


        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dtpCheckIn_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
