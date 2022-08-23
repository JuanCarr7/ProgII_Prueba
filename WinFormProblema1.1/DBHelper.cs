using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WinFormProblema1._1
{
    internal class DBHelper
    {
        SqlConnection conexion = new SqlConnection();
        SqlCommand comando = new SqlCommand();
        string cadenaConexion = @"Data Source=DESKTOP-CG0956K\SQLEXPRESS;Initial Catalog=Carreras;Integrated Security=True";
        

        public void Conectar(string cadenaDeConexion) 
        {
            conexion.ConnectionString = cadenaDeConexion;
            comando.Connection = conexion;
            conexion.Open();
        }

        public DataTable consultarDB(string NombreSP)
        {
            Conectar(cadenaConexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = NombreSP;
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            conexion.Close();
            return tabla;
             
        }

        public void insertarDB(string NombreSp, string parametro1, object objeto1)
        {
            Conectar(cadenaConexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = NombreSp;
            
        }

        public void Desconectar()
        {
            conexion.Close();
        }
    }
}
