using GestaoEquipamentos.ConsoleApp.Compartilhado;

namespace GestaoEquipamentos.ConsoleApp.Chamados
{
    public class Chamado
    {
        public int Id;
        public int IdEquipamento;
        public string Titulo;
        public string Descricao;
        public DateTime DataChamado;

        public Chamado(int idEquipamento, string titulo, string descricao)
        {
            Id = GeradorIdChamados.GerarIdChamado();
            IdEquipamento = idEquipamento;
            Titulo = titulo;
            Descricao = descricao;
            DataChamado = DateTime.Now;
        }
    }
}