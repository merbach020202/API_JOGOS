using System.ComponentModel.DataAnnotations;

namespace senai.inlock.webApi.Domains
{
    public class JogosDomain
    {
        public int Idjogo { get; set; }

        public int IdEstudio { get; set; }

        [Required(ErrorMessage = "O nome do jogo é obrigatório")]
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string DataLancamento { get; set; }
        public string Valor { get; set; }
        public EstudioDomain? Estudio { get; set; }
    }
}
