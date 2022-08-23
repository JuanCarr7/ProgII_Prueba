using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormProblema1._1
{
    internal class Asignatura
    {
        private string nombre;
        public string Nombre { set { nombre = value; } get { return nombre; } }

        public Asignatura()
        {
            nombre = "";

        }
        public Asignatura(string nombre)
        {
            Nombre = nombre;
        }

        public override string ToString()
        {
            return "Asignatura: "+Nombre;
        }

    }
}
