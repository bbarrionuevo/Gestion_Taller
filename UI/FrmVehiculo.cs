using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;

namespace UI
{
    public partial class FrmVehiculo : Form
    {
        BEClsVehiculo BEVehiculo;
        BLLClsVehiculo BLLVehiculo;

        public FrmVehiculo()
        {
            BEVehiculo = new BEClsVehiculo();
            BLLVehiculo = new BLLClsVehiculo();
            InitializeComponent();
        }
        public void Mostrar(DataGridView pDGV, object p0)
        {
            pDGV.DataSource = null; pDGV.DataSource = p0;


        }

        private void FrmVehiculo_Load(object sender, EventArgs e)
        {
            Mostrar(dataGridView1, BLLVehiculo.ListarTodo());

        }
        private void Button2_Click(object sender, EventArgs e)
        {
            try {
                BEVehiculo = new BEClsVehiculo();
                BEVehiculo.Marca = TextBox1.Text;
                BEVehiculo.Modelo = textBox5.Text;
                BEVehiculo.Patente = textBox6.Text;
                BEVehiculo.Categoria = comboBox1.Text;
                BEVehiculo.Kilometraje = int.Parse(textBox3.Text);
                BLLVehiculo.Guardar(BEVehiculo);
                Mostrar(dataGridView1, BLLVehiculo.ListarTodo());


            } catch { }
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        
    }
}
