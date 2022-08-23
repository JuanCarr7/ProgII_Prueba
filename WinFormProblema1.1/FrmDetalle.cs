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
    public partial class frmDetalleCarrera : Form
    {
        DBHelper datos = new DBHelper();
        DetalleCarrera detalle = new DetalleCarrera();
        
        public frmDetalleCarrera()
        {
            InitializeComponent();
        }

        private void frmDetalleCarrera_Load(object sender, EventArgs e)
        {
            CargarDataGrid();
            CargarCombo();
        }

        private void CargarDataGrid()
        {
            DataTable tabla = new DataTable();
            tabla = datos.consultarDB("pa_consultar_Detalle");
            dgvDetalles.DataSource = tabla;

        }

        public void CargarCombo()
        {
            DataTable tabla = new DataTable();
            tabla = datos.consultarDB("pa_consultar_asignaturas");
            cboMateria.DataSource = tabla;
            cboMateria.ValueMember = tabla.Columns[0].ColumnName;
            cboMateria.DisplayMember = tabla.Columns[1].ColumnName;
        }

    }
}
