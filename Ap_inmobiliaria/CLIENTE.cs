using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ap_inmobiliaria
{
    public partial class CLIENTE : Form
    {
        public CLIENTE()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void vENTAToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            
               Form1 venta = new Form1();
           // venta.MdiParent = this;
            venta.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Registro_Usuarios re = new Registro_Usuarios();
            re.Show();
        }

        private void aLQToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form4 venta = new Form4();
            // venta.MdiParent = this;
            venta.Show();

        }

        private void fECHASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contrato fechas = new contrato();
            fechas.Show();
        }

        private void cONTRATOSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form5 Form5 = new Form5();
            Form5.Show();
        }

        private void cLIENTESToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form6 Form6 = new Form6();
            Form6.Show();
        }
    
       
    }
}
