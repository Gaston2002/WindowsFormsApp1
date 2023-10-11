using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1.DAL
{
    class Conexion
    {

		private string CadenaConexion = "Data Source=DESKTOP-59J7KJ4\\SQLEXPRESS; Initial Catalog=Sistemas; Integrated Security = True";
		SqlConnection Conexions;

		public SqlConnection EstablecerConexion()
		{
			this.Conexions = new SqlConnection(this.CadenaConexion);
			return this.Conexions;
		}


        public bool PruebaConectar()
        {
			try
			{
				SqlCommand Comando = new SqlCommand();


				Comando.CommandText = "SELECT * FROM Empleados";
				Comando.Connection = this.EstablecerConexion();
				Conexions.Open();
				Comando.ExecuteNonQuery();
				Conexions.Close();


				return true;
			}
			catch (Exception)
			{

				return false;
			}
        }


    }
}
