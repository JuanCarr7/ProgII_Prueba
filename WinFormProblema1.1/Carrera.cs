using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormProblema1._1
{
    internal class Carrera
    {
        private string nombre;
        private string titulo;
        private DetalleCarrera detalle;
        private List<DetalleCarrera> detalles=new List<DetalleCarrera>();

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Titulo { get { return titulo; } set { titulo = value; } }
        public DetalleCarrera Detalle { get { return detalle; }set { detalle = value; } }

        public Carrera() 
        {
            nombre = "";
            titulo = "";
            detalle = null;

        }

        public Carrera(string nombre, string titulo, DetalleCarrera detalle) 
        {
            this.nombre = nombre;
            this.titulo = titulo;
            this.detalle = detalle;
        }
        public override string ToString()
        {
            return "Nombre de la carrera: "+Nombre+" | Título de la carrera: "+Titulo+" | "+Detalle.ToString() ;

        }



    }
}
