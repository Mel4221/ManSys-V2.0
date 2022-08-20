using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Common.Cache;


namespace DataAccess
{
    public class UserDa:ConexionaSql
    {
        public void Login(string user, string pass)
        {
            /*
             
            using (var connection = GetConnection())
            {



                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select *from Gestión_de_Usuarios where Nombre_de_Usuario=@user and Contraseña=@pass";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UserLoginCache.IdUser = reader.GetInt32(0);
                            UserLoginCache.Nombre = reader.GetString(1);
                            UserLoginCache.Apellido = reader.GetString(2);
                            UserLoginCache.Puesto_Ocupado = reader.GetString(3);
                            UserLoginCache.Departamento = reader.GetString(4);
                            UserLoginCache.Turno = reader.GetString(5);
                        }
                        return true;
                    }
                    else
                        return false;
                }
            }

            */
        }
    }
}
