using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormProblema1._1
{
    internal class DetalleCarrera
    {
        private int anioCursado;
        private string cuatrimestre;
        private Asignatura materia;
        public int AnioCursado { set { anioCursado = value; } get { return anioCursado; } }
        public string Cuatrimestre { set { cuatrimestre = value; } get { return cuatrimestre; } }
        public Asignatura Materia { set { materia = value; } get { return materia; } }

        public DetalleCarrera() { }
        public DetalleCarrera(int anioCursado, string cuatrimestre, Asignatura materia)
        {
            this.anioCursado = anioCursado;
            this.cuatrimestre = cuatrimestre;
            this.materia = materia;
        }

        public override string ToString()
        {
            return "Año de cursado: "+AnioCursado.ToString()+" | Cuatrimestre: "+Cuatrimestre +" |"+Materia.ToString();
        }

    }
}
