using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WinFormProblema1._1
{
    internal class DetalleCarrera
    {
        private int anioCursado;
        private string cuatrimestre;
        //private Asignatura materia; Preguntar por el uso de una variable de tipo clase creada
        private int materia;
        public int AnioCursado { set { anioCursado = value; } get { return anioCursado; } }
        public string Cuatrimestre { set { cuatrimestre = value; } get { return cuatrimestre; } }
        public int Materia { set { materia = value; } get { return materia; } }

        public DetalleCarrera() { }
        public DetalleCarrera(int anioCursado, string cuatrimestre, int materia)
        {
            this.anioCursado = anioCursado;
            this.cuatrimestre = cuatrimestre;
            this.materia = materia;
        }

        public override string ToString()
        {
            return "Año de cursado: "+AnioCursado.ToString()+" | Cuatrimestre: "+Cuatrimestre +" |"+Materia;
        }

       
    }
}
