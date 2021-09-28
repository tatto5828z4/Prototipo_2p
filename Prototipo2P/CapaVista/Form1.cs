using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mantenimientoLineaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Linea form = new Linea();
            form.MdiParent = this;

            form.Show();
        }

        private void mantenimientoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Marca formm = new Marca();
            formm.MdiParent = this;
            
            formm.Show();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Producto formp = new Producto();
            formp.MdiParent = this;
            formp.Show();
        }
    }
}
