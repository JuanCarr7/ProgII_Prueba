using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormProblema1._1
{
    public partial class FrmCarrera : Form
    {
        Carrera carrera = new Carrera();
        DBHelper datos = new DBHelper();

        public FrmCarrera()
        {
            InitializeComponent();
        }

        private void FrmCarrera_Load(object sender, EventArgs e)
        {
            CargarCombo();
            CargarLista();

        }

        public void CargarCombo()
        {
            DataTable tabla = new DataTable();
            tabla = datos.consultarDB("pa_consultar_asignaturas");
            cboDetalles.DataSource = tabla;
            cboDetalles.ValueMember = tabla.Columns[0].ColumnName;
            cboDetalles.DisplayMember = tabla.Columns[1].ColumnName;
        }
        public void CargarLista()
        {

        }
    }
}
