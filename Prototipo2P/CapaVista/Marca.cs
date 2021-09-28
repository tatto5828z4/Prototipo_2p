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
    public partial class Marca : Form
    {
        ClsControlador clsa = new ClsControlador();
        public Marca()
        {
            
            InitializeComponent();
            llenaTabla();
            btnBaja.Visible = false;
            btnActivar.Visible = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Marca formm = new Marca();
            formm.Hide();

        }

        private void label5_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
        }

        private void Marca_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsa.funInsertarMarca(txtCodMarca.Text, txtNombreMarca.Text, txtEstatusMarca.Text);
            llenaTabla();

        }

        public void llenaTabla()
        {
            DataTable dt = clsa.llenarTbl("marcas");
            dgvMarca.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMarca.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clsa.modificarMarca(txtCodMarca.Text, txtNombreMarca.Text, txtEstatusMarca.Text);
            llenaTabla();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clsa.fundarbaja(txtCodMarca.Text, "I");
            llenaTabla();
            btnBaja.Visible = false;
            btnActivar.Visible = false;
            txtCodMarca.Text="";
            txtNombreMarca.Text = "";
            txtEstatusMarca.Text = "";
        }

        private void dgvMarca_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnLlenar_Click(object sender, EventArgs e)
        {
            txtCodMarca.Text = dgvMarca.CurrentRow.Cells[0].Value.ToString();
            txtNombreMarca.Text = dgvMarca.CurrentRow.Cells[1].Value.ToString();
            txtEstatusMarca.Text = dgvMarca.CurrentRow.Cells[2].Value.ToString();
            if (txtEstatusMarca.Text == "I")
            {
                btnBaja.Visible = false;
                btnActivar.Visible = true;

            }
            else
            {
                btnBaja.Visible = true;
                btnActivar.Visible = false;
            }
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            clsa.fundarbaja(txtCodMarca.Text, "A");
            llenaTabla();

            btnBaja.Visible = false;
            btnActivar.Visible = false;
            txtCodMarca.Text = "";
            txtNombreMarca.Text = "";
            txtEstatusMarca.Text = "";
        }
    }
}
