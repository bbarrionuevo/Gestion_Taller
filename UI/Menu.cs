using Gestion_Taller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace UI
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void altaDeServicioToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form1 gestion = new Form1();
            gestion.MdiParent = this; // Establece el formulario MDI como padre
            gestion.Show(); // Muestra el formulario hijo



        }

        private void vERINFORMESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInformes informes = new FrmInformes();
            informes.MdiParent = this; // Establece el formulario MDI como padre
            informes.Show(); // Muestra el formulario hijo



        }

        private void iNFORMESToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
