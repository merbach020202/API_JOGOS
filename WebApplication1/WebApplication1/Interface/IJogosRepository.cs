using senai.inlock.webApi.Domains;

namespace senai.inlock.webApi.Interface
{
    public interface IJogosRepository
    {
        void Cadastrar(JogosDomain novoJogo);

        List<JogosDomain> ListarTodos();

        void Deletar(int id);

    }
}
