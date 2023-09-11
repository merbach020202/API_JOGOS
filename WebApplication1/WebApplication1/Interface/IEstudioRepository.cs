using senai.inlock.webApi.Domains;
using System.ComponentModel.DataAnnotations;

namespace senai.inlock.webApi.Interface
{
    public interface IEstudioRepository
    {
        void Cadastrar(EstudioDomain novoEstudio);

        List<EstudioDomain> ListarTodos();

        void Deletar(int id);

    }
}
