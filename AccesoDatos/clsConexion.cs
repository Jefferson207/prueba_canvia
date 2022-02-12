using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class clsConexion
    {
        private SqlConnection _cn;
        private string user;
        private string clave;
        private string database;
        private string servidor;

        public clsConexion()
        {
            string ruta;
            ruta = "Data Source=(local); Initial Catalog=prueba_canvia; Integrated Security=True";
            _cn = new SqlConnection(ruta);
        }

        public void conectar()
        {
            try
            {
                if (_cn.State != ConnectionState.Open)
                    _cn.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void desconectar()
        {
            try
            {
                if (_cn.State != ConnectionState.Open)
                    _cn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public SqlConnection getConexion()
        {
            return _cn;
        }
    }
}
