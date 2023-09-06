using senai.inlock.webApi.Domains;
using System.ComponentModel.DataAnnotations;

namespace senai.inlock.webApi.Interface
{
    public interface IEstudioRepository
    {
        void Cadastrar(EstudioDomain novoEstudio);

        List<EstudioDomain> ListarTodos();

        void AtualizarIdCorpo(int id, EstudioDomain estudio);

        void AtualizarIdUrl(string id, EstudioDomain estudio);

        void Deletar(int id);

        EstudioDomain BuscarPorId(int id);
    }
}
