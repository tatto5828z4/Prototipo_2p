using System;
using System.Collections;
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
    public partial class Producto : Form
    {
        ClsControlador prod = new ClsControlador();
        ArrayList referencia0 = new ArrayList();
        ArrayList referencia1 = new ArrayList();
        ArrayList referencia2 = new ArrayList();
        ArrayList referencia3 = new ArrayList();
        ArrayList referencia4 = new ArrayList();

        public Producto()
        {
            InitializeComponent();
            llenaTabla();
            //prod.funLlenarComboL(cbxLinea, "codigo_linea", "nombre_linea");
            //prod.funLlenarComboM(cbxMarca);
            //prod.funLlenarComboLista(cbxLinea, "lineas", "codigo_linea", "nombre_linea", "estatus_linea");

            btnActivar.Visible = false;
            btnBaja.Visible = false;

            txtlinea.Text = cbxLinea.ValueMember;
            txtmarca.Text = cbxMarca.ValueMember;

            prod.funLlenarComboControl(cbxLinea,"lineas","codigo_linea","nombre_linea", "estatus_linea");
            prod.funLlenarComboControl(cbxMarca, "marcas", "codigo_marca", "nombre_marca", "estatus_marca");

            
        }

        public void funLlenarComboControl(ComboBox cbx, string tabla, string value, string display, string estatus)
        {
            referencia1.Add(tabla);
            referencia2.Add(value);
            referencia3.Add(display);
            referencia4.Add(estatus);
            referencia0.Add(cbx);
            prod.funLlenarComboControl(cbx, tabla, value, display, estatus);
        }



        private void Producto_Load(object sender, EventArgs e)
        {

        }


        public void llenaTabla()
        {
            DataTable dt = prod.llenarTblP("productos");
            dgvProd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProd.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            prod.funInsertarP(txtCodP.Text, txtNombreP.Text,txtlinea.Text, txtmarca.Text, txtExis.Text,txtEstatus.Text);
            llenaTabla();

        }

        private void cbxLinea_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cbxMarca_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void cbxMarca_SelectionChangeCommitted(object sender, EventArgs e)
        {
        }

        private void cbxMarca_ValueMemberChanged(object sender, EventArgs e)
        {

        }

        private void cbxLinea_ValueMemberChanged(object sender, EventArgs e)
        {
        }

        private void cbxLinea_SelectedIndexChanged(object sender, EventArgs e)
        {
            prod.funComboTextboxControl(cbxLinea, txtlinea);

        }

        private void cbxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            prod.funComboTextboxControl(cbxMarca, txtmarca);
        }

        private void btnLlenar_Click(object sender, EventArgs e)
        {
            txtCodP.Text = dgvProd.CurrentRow.Cells[0].Value.ToString();
            txtNombreP.Text = dgvProd.CurrentRow.Cells[1].Value.ToString();
            cbxLinea.SelectedValue = dgvProd.CurrentRow.Cells[2].Value.ToString();
            cbxMarca.SelectedValue = dgvProd.CurrentRow.Cells[3].Value.ToString();
            txtExis.Text = dgvProd.CurrentRow.Cells[4].Value.ToString();
            txtEstatus.Text = dgvProd.CurrentRow.Cells[5].Value.ToString();
            if (txtEstatus.Text == "I")
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

        private void button2_Click(object sender, EventArgs e)
        {
            prod.funModificar(txtCodP.Text, txtNombreP.Text, txtlinea.Text, txtmarca.Text, txtExis.Text,txtEstatus.Text);
            llenaTabla();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            prod.fundarbajaP(txtCodP.Text, "I");
            llenaTabla();
            btnActivar.Visible = false;
            btnBaja.Visible = false;

        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            prod.fundarbajaP(txtCodP.Text, "A");
            llenaTabla();
            btnActivar.Visible = false;
            btnBaja.Visible = false;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
