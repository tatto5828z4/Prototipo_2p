using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaModelo;


namespace CapaControlador
{

    public class ClsControlador
    {
        ClsSentencia cls = new ClsSentencia();
        public void funInsertarMarca(String codigo, String nombre, String estatus)
        {
            cls.funInsertarMarca(codigo, nombre, estatus);
        }

        public void modificarMarca(String codigo, String nombre, String estatus)
        {
            cls.funModificar(codigo, nombre, estatus);
        }

        public void fundarbaja(String codigo, String estatus)
        {
            cls.fundarbaja(codigo, estatus);
        }
        public void fundarbajaL(String codigo, String estatus)
        {
            cls.fundarbajaL(codigo, estatus);
        }

        public void funInsertarLinea(String codigo, String nombre, String estatus)
        {
            cls.funInsertarLinea(codigo, nombre, estatus);
        }


        public DataTable llenarTbl(string tablaDB)
        {
            OdbcDataAdapter dt = cls.llenarTbl(tablaDB);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public DataTable llenarTblP(string tablaDB)
        {
            OdbcDataAdapter dt = cls.llenarTbl(tablaDB);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public void funInsertarP(String codigo, String nombre, String linea, String marca, String existencia, String estatus)
        {
            cls.funInsertarP(codigo, nombre, linea, marca, existencia, estatus);
        }


        public void funLlenarComboM(ComboBox combobox)
        {
            cls.funLlenarComboM(combobox);
        }

        public void funLlenarComboL(ComboBox combobox, String id, String nombre)
        {
            //cls.funLlenarComboL(combobox, id, nombre);
        }

        public void funComboTextboxControl(ComboBox combo, TextBox combotexto)
        {
            cls.funComboTextbox(combo, combotexto);
        }

        public void funLlenarComboControl(ComboBox cbx, string tabla, string value, string display, string estatus)
        {
            cls.funLlenarCombo(cbx, tabla, value, display, estatus);
        }

        public void modificarLinea(String codigo, String nombre, String estatus)
        {
            cls.modificarLinea(codigo, nombre, estatus);
        }
        public void funModificar(String idModificar, String nombre, String linea, String marca, String existencia, String estatus)
        {
            cls.funModificar(idModificar,nombre,linea,marca,existencia,estatus);
        }


        public void fundarbajaP(String codigo, String estatus)
        {
            cls.fundarbajaP(codigo, estatus);        
        }

    }
}