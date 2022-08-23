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
        bool nuevo = false;
        List<DetalleCarrera> lDetalles = new List<DetalleCarrera>();
        
        public frmDetalleCarrera()
        {
            InitializeComponent();
        }

        private void frmDetalleCarrera_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            CargarCombo();
            nuevo= true;

        }

        private void CargarGrilla() 
        {
            DataTable tabla = datos.consultarDB("pa_consultar_Detalle");
            dgvDetalleCarrera.DataSource = tabla;
        }

        //private void CargarGrilla()
        //{
        //    DataTable tabla = datos.consultarDB("pa_consultar_Detalle");
        //    lDetalles.Clear();
        //    foreach (DataRow fila in tabla.Rows) 
        //    {
        //        DetalleCarrera dc = new DetalleCarrera();
        //        dc.AnioCursado = Convert.ToInt32(fila[1]);
        //        dc.Materia.Nombre = fila[3].ToString();
        //        dc.Cuatrimestre = fila[2].ToString();

        //        lDetalles.Add(dc);


        //    }
        //    dgvDetalleCarrera.Columns.Contains()
        //    dgvDetalleCarrera.Rows.


        //}

        public void CargarCombo()
        {
            DataTable tabla = new DataTable();
            tabla = datos.consultarDB("pa_consultar_asignaturas");
            cboMateria.DataSource = tabla;
            cboMateria.ValueMember = tabla.Columns[0].ColumnName;
            cboMateria.DisplayMember = tabla.Columns[1].ColumnName;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (nuevo == true)
            {
                //DetalleCarrera dC = new DetalleCarrera();
                //if(txtAnioCursado.)
                

            }
        }

        
    }
}
