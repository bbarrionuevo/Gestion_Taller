
using System;
using System.Windows.Forms;
using BLL;

namespace Gestion_Taller
{
    public partial class ABM_Cliente : Form
    {
        
        public ABM_Cliente()
        {
            InitializeComponent();
            
        }

       

        public void Mostrar(DataGridView pDGV, object p0)
        {
            pDGV.DataSource = null; pDGV.DataSource = p0;


        }

        private void Button2_Click(object sender, EventArgs e)
        {


            try
            {

                re = new Regex(@"\d{8}");
                string dni = textBox6.Text;
                if (!(re.IsMatch(dni) && dni.Length == 8)) throw new Exception("El DNI no posee el formato correcto !!!");
                BEClsCliente BEcliente = new BEClsCliente();
                BEcliente.DNI = dni;
                BEcliente.Nombre = TextBox1.Text;
                BEcliente.Apellido = textBox5.Text;
                BEcliente.Nacionalidad = textBox4.Text;
                BEcliente.Mail = textBox3.Text;
                BEcliente.Telefono = int.Parse(textBox2.Text);
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridCliente.Rows.Count == 0) throw new Exception("No hay nada para modificar !!!");
                DataGridViewRow f = dataGridCliente.SelectedRows[0];
                BEClsCliente BEcliente = new BEClsCliente(Convert.ToInt32(f.Cells[6].Value));
                re = new Regex(@"\d{8}");
                string dni = textBox6.Text;
                if (!(re.IsMatch(dni) && dni.Length == 8)) throw new Exception("El DNI no posee el formato correcto !!!");

                BEcliente.DNI = dni;
                BEcliente.Nombre = TextBox1.Text;
                BEcliente.Apellido = textBox5.Text;
                BEcliente.Nacionalidad = textBox4.Text;
                BEcliente.Mail = textBox3.Text;
                BEcliente.Telefono = int.Parse(textBox2.Text);
                BLLcliente.Guardar(BEcliente);
                Mostrar(dataGridCliente, BLLcliente.ListarTodo());

                MessageBox.Show("Modificacion de Cliente Reserva realizada con éxito.");
            }

            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }





        private void dataGridCliente_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow f = dataGridCliente.SelectedRows[0];


                textBox6.Text = f.Cells[2].Value.ToString();
                TextBox1.Text = f.Cells[0].Value.ToString();
                textBox5.Text = f.Cells[1].Value.ToString();
                textBox4.Text = f.Cells[3].Value.ToString();
                textBox2.Text = f.Cells[5].Value.ToString();
                textBox3.Text = f.Cells[4].Value.ToString();




            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Frm_ABM_Clientes_Load(object sender, EventArgs e)
        {

            Mostrar(dataGridCliente, BLLcliente.ListarTodo());

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }
    }
}
