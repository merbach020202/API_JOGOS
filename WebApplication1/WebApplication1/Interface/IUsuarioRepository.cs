using senai.inlock.webApi.Domains;

namespace senai.inlock.webApi.Interface
{
    public interface IUsuarioRepository
    {
            UsuarioDomain Login(string Email, string Senha);
    }
}
