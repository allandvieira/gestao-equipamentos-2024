using GestaoEquipamentos.ConsoleApp.Compartilhado;

namespace GestaoEquipamentos.ConsoleApp.Chamados
{
    public class Chamado
    {
        public int Id, IdEquipamento;
        public string Titulo, Descricao;
        public DateTime DataChamado;

        public Chamado(int idEquipamento, string titulo, string descricao, DateTime dataChamado)
        {
            IdEquipamento = idEquipamento;
            Titulo = titulo;
            Descricao = descricao;
            DataChamado = dataChamado;
        }
    }
}