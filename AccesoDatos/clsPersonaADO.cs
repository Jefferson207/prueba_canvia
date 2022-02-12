using System;

using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace AccesoDatos
{
    class clsPersonaADO
    {
        public void registrar(clsPersona obj)
        {
            clsConexion cn = new clsConexion();
            SqlCommand cmd;
            try
            {
                cn.conectar();
                cmd = new SqlCommand("SP_Registrar_Persona", cn.getConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Nombres", SqlDbType.VarChar).Value = obj.nombres;
                cmd.Parameters.Add("@Apellidos", SqlDbType.VarChar).Value = obj.apellidos;
                cmd.Parameters.Add("@DNI", SqlDbType.Char).Value = obj.dni;
                cmd.Parameters.Add("@FechaNacimiento", SqlDbType.Date).Value = obj.fecha_nacimiento;
                cmd.Parameters.Add("@Telefono", SqlDbType.Char).Value = obj.telefono;
                cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = obj.email;
                cmd.Parameters.Add("@Sexo", SqlDbType.Char).Value = obj.sexo;
                cmd.ExecuteNonQuery();

                cn.desconectar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void modificar(clsPersona obj)
        {
            clsConexion cn = new clsConexion();
            SqlCommand cmd;
            try
            {
                cn.conectar();
                cmd = new SqlCommand("SP_Modificar_Persona", cn.getConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@IdPersona", SqlDbType.VarChar).Value = obj.idpersona;
                cmd.Parameters.Add("@Nombres", SqlDbType.VarChar).Value = obj.nombres;
                cmd.Parameters.Add("@Apellidos", SqlDbType.VarChar).Value = obj.apellidos;
                cmd.Parameters.Add("@DNI", SqlDbType.Char).Value = obj.dni;
                cmd.Parameters.Add("@FechaNacimiento", SqlDbType.Date).Value = obj.fecha_nacimiento;
                cmd.Parameters.Add("@Telefono", SqlDbType.Char).Value = obj.telefono;
                cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = obj.email;
                cmd.Parameters.Add("@Sexo", SqlDbType.Char).Value = obj.sexo;
                cmd.ExecuteNonQuery();

                cn.desconectar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable listado_persona()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da;
            clsConexion cn = new clsConexion();

            try
            {
                cn.conectar();
                da = new SqlDataAdapter("SP_Listar_Persona", cn.getConexion());
                da.Fill(dt);
                cn.desconectar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }
    }
}
