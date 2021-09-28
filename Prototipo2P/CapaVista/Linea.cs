using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;


namespace CapaVista
{
    public partial class Linea : Form
    {
        ClsControlador control = new ClsControlador();
        public Linea()
        {
            InitializeComponent();
            llenaTabla();
            btnActivar.Visible = false;
            btnbaja.Visible = false;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtCodLinea_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNombreLinea_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtEstatusLinea_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvLinea_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void llenaTabla()
        {
            DataTable dt = control.llenarTbl("lineas");
            dgvLinea.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLinea.DataSource = dt;

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Linea_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            control.fundarbajaL(txtCodLinea.Text, "I");
            llenaTabla();
            btnbaja.Visible = false;
            btnActivar.Visible = false;
            txtCodLinea.Text = "";
            txtNombreLinea.Text = "";
            txtEstatusLinea.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            control.funInsertarLinea(txtCodLinea.Text, txtNombreLinea.Text, txtEstatusLinea.Text);
            llenaTabla();
        }

        private void btnLlenar_Click(object sender, EventArgs e)
        {
            txtCodLinea.Text = dgvLinea.CurrentRow.Cells[0].Value.ToString();
            txtNombreLinea.Text = dgvLinea.CurrentRow.Cells[1].Value.ToString();
            txtEstatusLinea.Text = dgvLinea.CurrentRow.Cells[2].Value.ToString();
            if (txtEstatusLinea.Text == "I")
            {
                btnbaja.Visible = false;
                btnActivar.Visible = true;

            }
            else
            {
                btnbaja.Visible = true;
                btnActivar.Visible = false;
            }
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            control.fundarbajaL(txtCodLinea.Text, "A");
            llenaTabla();

            btnbaja.Visible = false;
            btnActivar.Visible = false;
            txtCodLinea.Text = "";
            txtNombreLinea.Text = "";
            txtEstatusLinea.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            control.modificarLinea(txtCodLinea.Text,txtNombreLinea.Text,txtEstatusLinea.Text);
        }

        private void txtCodLinea_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            control.modificarLinea(txtCodLinea.Text, txtNombreLinea.Text, txtEstatusLinea.Text);
            llenaTabla();
        }
    }
}
