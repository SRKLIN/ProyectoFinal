using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    class ConectorBD
    {
        public SqlConnection conexionBD = new SqlConnection("Data Source=KLIN\\SQLEXPRESS; Initial Catalog=universidad; Integrated Security=True");

        public void AbreConexion()
        {
            if (conexionBD.State == ConnectionState.Closed)
            {
                conexionBD.Open();
            }
        }

        // Method to close the connection
        public void CierraConexion()
        {
            if (conexionBD.State == ConnectionState.Open)
            {
                conexionBD.Close();
            }

        }


        // Método para obtener la conexión
        public SqlConnection ObtieneConexion()
        {
            // Asegurarse de que la conexión esté abierta antes de devolverla
            AbreConexion();
            return conexionBD;
        }
    }
}
