using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormProblema1._1
{
    internal class Asignatura
    {
        private int id;
        private string nombre;
        public string Nombre { set { nombre = value; } get { return nombre; } }
        public int Id { set { id = value; }get { return id; } } 

        public Asignatura()
        {
            nombre = "";
            id = 0;

        }
        public Asignatura(string nombre)
        {
            Nombre = nombre;
        }
        public Asignatura(int id)
        {
            this.id = id;
        }

        public override string ToString()
        {
            return "Asignatura: "+Nombre;
        }

    }
}
