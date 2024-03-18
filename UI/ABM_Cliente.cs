
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BLL;
using BE;
using System.Xml.Linq;
using System.Xml;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using UI;

namespace Gestion_Taller
{
    public partial class ABM_Cliente : Form
    {
        Regex re;
        BLLClsCliente BLLcliente;
        BEClsCliente BECliente;
        BEClsVehiculo Vehiculo;
        BLLClsVehiculo BLLVehiculo;
        public ABM_Cliente()
        {
            InitializeComponent();
            BLLcliente = new BLLClsCliente();
            Vehiculo = new BEClsVehiculo();
            BLLVehiculo = new BLLClsVehiculo();
            BECliente = new BEClsCliente();

        }



        public void Mostrar(DataGridView pDGV, object p0)
        {
            pDGV.DataSource = null; pDGV.DataSource = p0;


        }

        private void Button2_Click(object sender, EventArgs e)
        {


            try
            {
                if (dataGridView1.Rows.Count == 0) throw new Exception("No hay vehiculo seleccionado !!!");
                DataGridViewRow f = dataGridView1.SelectedRows[0];


                re = new Regex(@"\d{8}");
                string dni = textBox6.Text;
                if (!(re.IsMatch(dni) && dni.Length == 8)) throw new Exception("El DNI no posee el formato correcto !!!");
                BEClsCliente BEcliente = new BEClsCliente();
                BEcliente.DNI = int.Parse(dni);
                BEcliente.Vehiculo = (Vehiculo = new BEClsVehiculo(f.Cells[2].Value.ToString()));

                string regNombre = TextBox1.Text;
                Regex reNombre = new Regex(@"^[a-zA-Z\s]{1,50}$");
                if (!reNombre.IsMatch(regNombre))
                {
                    throw new Exception("El nombre no posee el formato correcto");
                }
                BEcliente.Nombre = regNombre;

                string reapellido = textBox5.Text;
                Regex reApellido = new Regex(@"^[a-zA-Z\s]{1,50}$");
                if (!reApellido.IsMatch(reapellido))
                {
                    throw new Exception("El apellido no posee el formato correcto");
                }
                BEcliente.Apellido = reapellido;

                DateTime ReFecha = Fecha.Value;

                // Convertir la fecha a una cadena de texto en el formato dd/MM/yyyy
                string fechaString = ReFecha.ToString("dd/MM/yyyy");

                // Validar la fecha
                Regex reFechaNacimiento = new Regex(@"^(0?[1-9]|[12][0-9]|3[01])/(0?[1-9]|1[0-2])/((19|20)\d\d)$");
                if (!reFechaNacimiento.IsMatch(fechaString))
                {
                    throw new Exception("La fecha de nacimiento no posee el formato correcto (dd/mm/yyyy)");
                }

                // Guardar la fecha en la base de datos
                BEcliente.Fecha_Nacimiento = fechaString;

                string reMail = textBox3.Text;
                Regex ReMail = new Regex(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");
                if (!ReMail.IsMatch(reMail))
                {
                    throw new Exception("El correo electrónico no posee el formato correcto");
                }
                BEcliente.Mail = reMail;

                BLLcliente.Guardar(BEcliente);
                Mostrar(dataGridCliente, BLLcliente.ListarTodo());

                MessageBox.Show("Alta de Cliente realizada con éxito.");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        //Boton Baja Cliente
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridCliente.Rows.Count == 0) throw new Exception("No hay nada para borrar !!!");
                DataGridViewRow f = dataGridCliente.SelectedRows[0];
                BEClsCliente BEcliente = new BEClsCliente(Convert.ToInt32(f.Cells[6].Value));
                BLLcliente.Baja(BEcliente);
                Mostrar(dataGridCliente, BLLcliente.ListarTodo());
                MessageBox.Show("Baja Reserva realizada con éxito.");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        





        private void dataGridCliente_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow f = dataGridCliente.SelectedRows[0];


                textBox6.Text = f.Cells[3].Value.ToString();
                TextBox1.Text = f.Cells[1].Value.ToString();
                textBox5.Text = f.Cells[2].Value.ToString();
                textBox3.Text = f.Cells[5].Value.ToString();


            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Frm_ABM_Clientes_Load(object sender, EventArgs e)
        {

            Mostrar(dataGridCliente, BLLcliente.ListarTodo());

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dataGridCliente.Rows.Count == 0) throw new Exception("No hay nada para modificar !!!");
                DataGridViewRow f = dataGridCliente.SelectedRows[0];
                if (dataGridView1.Rows.Count == 0) throw new Exception("No hay vehiculo seleccionado !!!");
                DataGridViewRow v = dataGridView1.SelectedRows[0];
                BEClsCliente BEcliente = new BEClsCliente(Convert.ToInt32(f.Cells[0].Value));
                BEcliente.Vehiculo = (Vehiculo = new BEClsVehiculo(v.Cells[2].Value.ToString()));

                re = new Regex(@"\d{8}");
                string dni = textBox6.Text;
                if (!(re.IsMatch(dni) && dni.Length == 8)) throw new Exception("El DNI no posee el formato correcto !!!");
                BEcliente.DNI = int.Parse(dni);

                string regNombre = TextBox1.Text;
                Regex reNombre = new Regex(@"^[a-zA-Z\s]{1,50}$");
                if (!reNombre.IsMatch(regNombre))
                {
                    throw new Exception("El nombre no posee el formato correcto");
                }
                BEcliente.Nombre = regNombre;

                string reapellido = textBox5.Text;
                Regex reApellido = new Regex(@"^[a-zA-Z\s]{1,50}$");
                if (!reApellido.IsMatch(reapellido))
                {
                    throw new Exception("El apellido no posee el formato correcto");
                }
                BEcliente.Apellido = reapellido;

                DateTime ReFecha = Fecha.Value;

                // Convertir la fecha a una cadena de texto en el formato dd/MM/yyyy
                string fechaString = ReFecha.ToString("dd/MM/yyyy");

                // Validar la fecha
                Regex reFechaNacimiento = new Regex(@"^(0?[1-9]|[12][0-9]|3[01])/(0?[1-9]|1[0-2])/((19|20)\d\d)$");
                if (!reFechaNacimiento.IsMatch(fechaString))
                {
                    throw new Exception("La fecha de nacimiento no posee el formato correcto (dd/mm/yyyy)");
                }

                // Guardar la fecha en la base de datos
                BEcliente.Fecha_Nacimiento = fechaString;

                string reMail = textBox3.Text;
                Regex ReMail = new Regex(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");
                if (!ReMail.IsMatch(reMail))
                {
                    throw new Exception("El correo electrónico no posee el formato correcto");
                }
                BEcliente.Mail = reMail;

                BLLcliente.Guardar(BEcliente);
                Mostrar(dataGridCliente, BLLcliente.ListarTodo());

                MessageBox.Show("Modificacion de Cliente Reserva realizada con éxito.");
            }

            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dataGridCliente.Rows.Count == 0) throw new Exception("No hay nada para borrar !!!");
                DataGridViewRow f = dataGridCliente.SelectedRows[0];
                BEClsCliente BEcliente = new BEClsCliente(Convert.ToInt32(f.Cells[0].Value));
                BLLcliente.Baja(BEcliente);
                Mostrar(dataGridCliente, BLLcliente.ListarTodo());
                MessageBox.Show("Baja Reserva realizada con éxito.");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void ABM_Cliente_Load(object sender, EventArgs e)
        {
            try
            {
                Mostrar(dataGridCliente, BLLcliente.ListarTodo());

                Mostrar(dataGridView1, BLLVehiculo.ListarTodo());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmVehiculo Frmvehiculo = new FrmVehiculo();
            Frmvehiculo.Show(); // Muestra el formulario
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Fecha_ValueChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }

        private void label10_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void Label6_Click(object sender, EventArgs e)
        {
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void dataGridCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
