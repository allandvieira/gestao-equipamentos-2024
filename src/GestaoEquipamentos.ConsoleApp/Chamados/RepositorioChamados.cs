using GestaoEquipamentos.ConsoleApp.Compartilhado;

namespace GestaoEquipamentos.ConsoleApp.Chamados
{
    public class RepositorioChamados
    {
        private Chamado[] chamados = new Chamado[100];

        public void CadastrarChamado(Chamado novoChamado)
        {
            novoChamado.Id = GeradorIdChamados.GerarIdChamado();

            RegistrarChamado(novoChamado);
        }

        public bool EditarChamado(int id, Chamado novoChamado)
        {
            novoChamado.Id = id;

            for (int i = 0; i < chamados.Length; i++)
            {
                if (chamados[i] == null)
                    continue;

                else if (chamados[i].Id == id)
                {
                    chamados[i] = novoChamado;

                    return true;
                }
            }

            return false;
        }

        public bool ExcluirChamado(int id)
        {
            for (int i = 0; i < chamados.Length; i++)
            {
                if (chamados[i] == null)
                    continue;

                else if (chamados[i].Id == id)
                {
                    chamados[i] = null;
                    return true;
                }
            }

            return false;
        }

        public Chamado[] SelecionarChamados()
        {
            return chamados;
        }

        public Chamado SelecionarChamadoPorId(int id)
        {
            foreach (Chamado chamado in chamados)
            {
                if (chamado.Id == id)
                {
                    return chamado;
                }
            }

            return null; // Retorna null se nenhum chamado com o ID especificado for encontrado
        }

        public bool ExisteChamado(int id)
        {
            for (int i = 0; i < chamados.Length; i++)
            {
                Chamado c = chamados[i];

                if (c == null)
                    continue;

                else if (c.Id == id)
                    return true;
            }

            return false;
        }

        private void RegistrarChamado(Chamado chamado)
        {
            for (int i = 0; i < chamados.Length; i++)
            {
                if (chamados[i] != null)
                    continue;

                else
                {
                    chamados[i] = chamado;
                    break;
                }
            }
        }
    }
}
