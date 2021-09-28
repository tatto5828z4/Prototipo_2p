using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Collections;
using System.Windows.Forms;
using System.Data;

namespace CapaModelo
{
    public class ClsSentencia
    {
        ClsConexion conexion = new ClsConexion();


        //llenar combobox
        public void funLlenarCombo(ComboBox cbx, string tabla, string value, string display, string estatus)
        {
            cbx.DataSource = null;
            cbx.Items.Clear();

            String psql = "SELECT * FROM " + " " + tabla + " " + "WHERE " + " " + estatus + "= 'A' ";

            //MySqlConnection conexionBD = Conexion.conexion();
            OdbcConnection conect = conexion.conexion();


            try
            {
                OdbcCommand comando = new OdbcCommand(psql, conect);
                //MySqlCommand llenarCombo = new MySqlCommand(psql, conexionBD);
                OdbcDataAdapter data = new OdbcDataAdapter(comando);

                DataTable dt = new DataTable();
                data.Fill(dt);

                cbx.ValueMember = value;
                cbx.DisplayMember = display;
                cbx.DataSource = dt;
            }
            catch (OdbcException ex)
            {
                MessageBox.Show("Error al leer los datos " + ex.Message);
            }
            finally
            {
                //conexionBD.Close();
                conexion.desconexion(conect);
            }
        }

        //---------------------------------------------------------------------
        // llenar tabla
        public OdbcDataAdapter llenarTbl(string tabla)
        {

            string sql = "select * from " + " " + tabla;
            OdbcConnection conexionBD = conexion.conexion();
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, conexionBD);
            conexion.desconexion(conexionBD);

            return dataTable;
        }


        //------------------------------------------------------------------------
        // modificar marca
        public void funModificar(String codigo, String nombre, String estatus)
        {
            String pSqlModificar = "UPDATE marcas SET nombre_marca='" + nombre + "', estatus_marca= '" + estatus + "' WHERE codigo_marca='" + codigo + "'";

            //Console.WriteLine(psql);
            OdbcConnection conexionBD = conexion.conexion();
            try
            {
                OdbcCommand modificarDepartamento = new OdbcCommand(pSqlModificar, conexionBD);
                modificarDepartamento.ExecuteNonQuery();
                MessageBox.Show("Datos Modificados Correctamente");
            }
            catch (OdbcException ex)
            {
                MessageBox.Show("Error al modificar los datos " + ex.Message);
            }
            finally
            {
                conexion.desconexion(conexionBD);
            }
        }

        //----------------------------------------------------------------------------
        //modificar linea
        public void modificarLinea(String codigo, String nombre, String estatus)
        {
            ClsConexion cn = new ClsConexion();
            OdbcConnection conn = cn.conexion();
            string sql = "UPDATE lineas SET nombre_linea ='" + nombre + "', estatus_linea = '" + estatus + "' WHERE codigo_linea = '" + codigo + "'";
            try
            {
                OdbcCommand ingreso = new OdbcCommand(sql, conn);
                ingreso.ExecuteNonQuery();
                MessageBox.Show("Datos Modificados Correctamente");

            }
            catch (OdbcException Error)
            {
                Console.WriteLine("Error al actualizar " + Error);
            }
            cn.desconexion(conn);
        }

        //-------------------------------------------------------------------------------
        //insertar marca
        public void funInsertarMarca(String codigo, String nombre, String estatus)
        {
            String psql = "INSERT INTO marcas(codigo_marca,nombre_marca,estatus_marca)" +
             " VALUES('" + codigo + "' , '" + nombre + "' , '" + estatus + "')";

            //Console.WriteLine(psql);
            ClsConexion cn = new ClsConexion();

            OdbcConnection conexionBD = cn.conexion();
            try
            {
                OdbcCommand insertarCliente = new OdbcCommand(psql, conexionBD);
                insertarCliente.ExecuteNonQuery();
                MessageBox.Show("Datos Ingresados Correctamente");
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(codigo);
                MessageBox.Show("Error al guardar los datos " + ex.Message);
            }
            finally
            {
                cn.desconexion(conexionBD);

            }
        }

        //---------------------------------------
        //darbaja marcas
        public void fundarbaja(String codigo, String estatus)
        {
            String pSqlModificar = "UPDATE marcas SET estatus_marca='" + estatus + "' WHERE codigo_marca='" + codigo + "'";

            //Console.WriteLine(psql);
            OdbcConnection conexionBD = conexion.conexion();
            try
            {
                OdbcCommand modificarDepartamento = new OdbcCommand(pSqlModificar, conexionBD);
                modificarDepartamento.ExecuteNonQuery();
                MessageBox.Show("Datos Modificados Correctamente");
            }
            catch (OdbcException ex)
            {
                MessageBox.Show("Error al modificar los datos " + ex.Message);
            }
            finally
            {
                conexion.desconexion(conexionBD);
            }
        }
        //--------------------------------------------------------
        // dar baja lineas

        public void fundarbajaL(String codigo, String estatus)
        {
            String pSqlModificar = "UPDATE lineas SET estatus_linea='" + estatus + "' WHERE codigo_linea='" + codigo + "'";

            //Console.WriteLine(psql);
            OdbcConnection conexionBD = conexion.conexion();
            try
            {
                OdbcCommand modificarDepartamento = new OdbcCommand(pSqlModificar, conexionBD);
                modificarDepartamento.ExecuteNonQuery();
                MessageBox.Show("Datos Modificados Correctamente");
            }
            catch (OdbcException ex)
            {
                MessageBox.Show("Error al modificar los datos " + ex.Message);
            }
            finally
            {
                conexion.desconexion(conexionBD);
            }
        }



        //---------------------------------------------------
        //insertar linea
        public void funInsertarLinea(String codigo, String nombre, String estatus)
        {
            String psql = "INSERT INTO lineas(codigo_linea,nombre_linea,estatus_linea)" +
             " VALUES('" + codigo + "' , '" + nombre + "' , '" + estatus + "')";

            //Console.WriteLine(psql);
            ClsConexion cn = new ClsConexion();

            OdbcConnection conexionBD = cn.conexion();
            try
            {
                OdbcCommand insertarCliente = new OdbcCommand(psql, conexionBD);
                insertarCliente.ExecuteNonQuery();
                MessageBox.Show("Datos Ingresados Correctamente");
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(codigo);
                MessageBox.Show("Error al guardar los datos " + ex.Message);
            }
            finally
            {
                cn.desconexion(conexionBD);

            }
        }


        //-------------------------------
        //llenar combobox linea
       

        public void funLlenarComboM(ComboBox combobox)
        {
            combobox.DataSource = null;
            combobox.Items.Clear();
            String psql = "Select * FROM marcas";
            Console.WriteLine(psql);
            OdbcConnection conexionBD = conexion.conexion();
            try
            {
                OdbcCommand llenarCombo = new OdbcCommand(psql, conexionBD);
                OdbcDataAdapter data = new OdbcDataAdapter(llenarCombo);
                DataTable dt = new DataTable();
                data.Fill(dt);
                combobox.ValueMember = "codigo_marca";
                combobox.DisplayMember = "nombre_marca";
                combobox.DataSource = dt;

            }
            catch (OdbcException ex)
            {
                MessageBox.Show("Error al guardar los datos " + ex.Message);
            }
        }



        //-----------------------------------------------
        public void funInsertarP(String codigo, String nombre, String linea, String marca, String existencia, String estatus)
        {
            
            String psql = "INSERT INTO productos" + " VALUES('" + codigo + "' , '" + nombre + "' , '" + linea + "', '" + marca + "', '" + existencia + "', '" + estatus + "')";
            ClsConexion cn = new ClsConexion();
            OdbcConnection conexionBD = cn.conexion();
            try
            {
                OdbcCommand insertarCliente = new OdbcCommand(psql, conexionBD);
                insertarCliente.ExecuteNonQuery();
                MessageBox.Show("Datos Ingresados Correctamente");
            }
            catch (OdbcException ex)
            {
                MessageBox.Show("Error al guardar los datos " + ex);
            }
            finally
            {
                cn.desconexion(conexionBD);
            }
        }

        public void funComboTextbox(ComboBox combo, TextBox combotexto)
        {
            if (combo.SelectedValue == null)
            {
                return;
            }
            String cbx = combo.SelectedValue.ToString();
            combotexto.Text = cbx;

        }

        public void funLlenarComboLinea(ComboBox cbx, string tabla, string value, string display, string estatus)
        {
            cbx.DataSource = null;
            cbx.Items.Clear();

            String psql = "SELECT * FROM " + " " + tabla;
            //cbx.Items.Add(psql);

            //MySqlConnection conexionBD = Conexion.conexion();
            OdbcConnection conect = conexion.conexion();

            try
            {
                OdbcCommand comando = new OdbcCommand(psql, conect);
                //MySqlCommand llenarCombo = new MySqlCommand(psql, conexionBD);
                OdbcDataAdapter data = new OdbcDataAdapter(comando);

                DataTable dt = new DataTable();
                data.Fill(dt);

                cbx.ValueMember = value;
                cbx.DisplayMember = display;
                cbx.DataSource = dt;
            }
            catch (OdbcException ex)
            {
                MessageBox.Show("Error al leer los datos " + ex.Message);
            }
            finally
            {
                //conexionBD.Close();
                conexion.desconexion(conect);
            }
        }


        public void funModificar(String idModificar, String nombre, String linea, String marca, String existencia, String estatus)
        {
            String pSqlModificar = "UPDATE productos SET nombre_producto='" + nombre + "'," +
            " codigo_linea='" + linea + "', codigo_marca='" + marca + "', existencia_producto='" + existencia + "', estatus_producto='" + estatus + "' WHERE codigo_producto='" + idModificar + "'";

            //Console.WriteLine(psql);
            OdbcConnection conect = conexion.conexion();
            try
            {
                OdbcCommand modificarCliente = new OdbcCommand(pSqlModificar, conect);
                modificarCliente.ExecuteNonQuery();
                MessageBox.Show("Datos Modificados Correctamente");
            }
            catch (OdbcException ex)
            {
                MessageBox.Show("Error al modificar los datos " + ex.Message);
            }
            finally
            {
                conexion.desconexion(conect);
            }
        }


        public void fundarbajaP(String codigo, String estatus)
        {
            String pSqlModificar = "UPDATE productos SET estatus_producto='" + estatus + "' WHERE codigo_producto='" + codigo + "'";

            //Console.WriteLine(psql);
            OdbcConnection conexionBD = conexion.conexion();
            try
            {
                OdbcCommand modificarDepartamento = new OdbcCommand(pSqlModificar, conexionBD);
                modificarDepartamento.ExecuteNonQuery();
                MessageBox.Show("Datos Modificados Correctamente");
            }
            catch (OdbcException ex)
            {
                MessageBox.Show("Error al modificar los datos " + ex.Message);
            }
            finally
            {
                conexion.desconexion(conexionBD);
            }
        }


    }
}
