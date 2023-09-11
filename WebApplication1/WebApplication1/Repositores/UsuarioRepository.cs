using Microsoft.IdentityModel.Tokens;
using senai.inlock.webApi.Domains;
using senai.inlock.webApi.Interface;
using System.Data.SqlClient;

namespace senai.inlock.webApi.Repositores
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private string StringConexao = "Data Source = NOTE05-S15; Initial Catalog=inlock_games_eduardo; User Id = sa; Pwd = Senai@134";
        public UsuarioDomain Login(string Email, string Senha)
        {
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string queryInsert = "SELECT IdUsuario, Email, IdTipoUsuario FROM Usuario WHERE Email = @Email AND Senha = @Senha";

                con.Open();

                using (SqlCommand cmd = new SqlCommand(queryInsert, con))
                {
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue(@"Senha", Senha);

                    SqlDataReader rdr = cmd.ExecuteReader();

                    {
                        if (rdr.Read())
                        {
                            UsuarioDomain usuarioBuscado = new UsuarioDomain()
                            {
                                IdUsuario = Convert.ToInt32(rdr["IdUsuario"]),
                                Email = Convert.ToString(rdr["Email"]),
                            };

                            return usuarioBuscado;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }

    }
}
