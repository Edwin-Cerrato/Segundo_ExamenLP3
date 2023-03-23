using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Text;

namespace Datos
{
    public class UsuarioDB
    {
        //Cadena Conexión
        string cadena = "server=localhost; user=root; database=bdtickets; password=ranger2718;";

        public Usuario Auntenticar(Login login)
        {
            Usuario user = null;

            try
            {
                StringBuilder sql = new StringBuilder();

                sql.Append("SELECT * FROM usuario WHERE CodigoUsuario = @CodigoUsuario AND Contrasena = @Contrasena;");

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();

                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        //pasamos parametros 
                        comando.Parameters.Add("@CodigoUsuario", MySqlDbType.VarChar, 20).Value = login.CodigoUsuario;
                        comando.Parameters.Add("@Contrasena", MySqlDbType.VarChar, 45).Value = login.Contrasena;

                        MySqlDataReader dr = comando.ExecuteReader();

                        if (dr.Read())
                        {
                            user = new Usuario();

                            user.CodigoUsuario = dr["CodigoUsuario"].ToString();
                            user.Nombre = dr["Nombre"].ToString();
                            user.Contrasena = dr["Contrasena"].ToString();
                            user.Correo = dr["Correo"].ToString();
                            user.FechaCreacion = Convert.ToDateTime(dr["FechaCreacion"]);
                            user.EstaActivo = Convert.ToBoolean(dr["EstaActivo"]);
                        }

                    }
                }
            }
            catch (System.Exception ex)
            {

            }


            return user;
        }
    }
}
