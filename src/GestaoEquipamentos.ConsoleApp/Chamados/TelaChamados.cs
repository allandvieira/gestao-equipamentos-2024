namespace GestaoEquipamentos.ConsoleApp.Chamados
{
    public class TelaChamados
    {
        RepositorioChamados repositorio = new RepositorioChamados();

        public char ApresentarMenu()
        {
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("|           Controle de Chamados        |");
            Console.WriteLine("----------------------------------------");

            Console.WriteLine();

            Console.WriteLine("1 - Abrir Chamado");
            Console.WriteLine("2 - Editar Chamado");
            Console.WriteLine("3 - Fechar Chamado");
            Console.WriteLine("4 - Excluir Chamado");
            Console.WriteLine("5 - Visualizar Chamados");

            Console.WriteLine("S - Voltar");

            Console.WriteLine();

            Console.Write("Escolha uma das opções: ");
            char operacaoEscolhida = Convert.ToChar(Console.ReadLine());

            return operacaoEscolhida;
        }

        public void AbrirChamado()
        {
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("|           Controle de Chamados        |");
            Console.WriteLine("----------------------------------------");

            Console.WriteLine();

            Console.WriteLine("Abrindo novo chamado...");

            Console.WriteLine();

            Console.Write("Digite o ID do equipamento: ");
            int idEquipamento = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o título do chamado: ");
            string titulo = Console.ReadLine();

            Console.Write("Digite a descrição do problema: ");
            string descricao = Console.ReadLine();

            Chamado chamado = new Chamado(idEquipamento, titulo, descricao);

            repositorio.CadastrarChamado(chamado);

            Program.ExibirMensagem("O chamado foi aberto com sucesso!", ConsoleColor.Green);
        }

        public void EditarChamado()
        {
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("|           Controle de Chamados        |");
            Console.WriteLine("----------------------------------------");

            Console.WriteLine();

            Console.WriteLine("Editando Chamado...");

            Console.WriteLine();

            VisualizarChamados(false);

            Console.Write("Digite o ID do chamado que deseja editar: ");
            int idChamadoEscolhido = Convert.ToInt32(Console.ReadLine());

            if (!repositorio.ExisteChamado(idChamadoEscolhido))
            {
                Program.ExibirMensagem("O chamado mencionado não existe!", ConsoleColor.DarkYellow);
                return;
            }

            Console.WriteLine();

            Console.Write("Digite o novo título do chamado: ");
            string titulo = Console.ReadLine();

            Console.Write("Digite a nova descrição do problema: ");
            string descricao = Console.ReadLine();

            Chamado novoChamado = new Chamado(idChamadoEscolhido, titulo, descricao);

            repositorio.EditarChamado(idChamadoEscolhido, novoChamado);

            Program.ExibirMensagem("O chamado foi editado com sucesso!", ConsoleColor.Green);
        }

        public void FecharChamado()
        {
            Console.Clear();

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("|            Gestão de Equipamentos            |");
            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine();

            Console.WriteLine("Fechando Chamado...");

            Console.WriteLine();

            VisualizarChamados(false);

            Console.Write("Digite o ID do chamado que deseja fechar: ");
            int idChamadoEscolhido = Convert.ToInt32(Console.ReadLine());

            if (!repositorio.ExisteChamado(idChamadoEscolhido))
            {
                Program.ExibirMensagem("O chamado mencionado não existe!", ConsoleColor.DarkYellow);
                return;
            }

            repositorio.ExcluirChamado(idChamadoEscolhido);

            Program.ExibirMensagem("O chamado foi fechado com sucesso!", ConsoleColor.Green);
        }

        public void VisualizarChamados(bool exibirTitulo)
        {
            if (exibirTitulo)
            {
                Console.Clear();

                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("|            Gestão de Equipamentos            |");
                Console.WriteLine("-----------------------------------------------");

                Console.WriteLine();

                Console.WriteLine("Visualizando Chamados...");

            }

            Chamado[] chamadosCadastrados = repositorio.SelecionarChamados();

            if (chamadosCadastrados.Length == 0)
            {
                Program.ExibirMensagem("Não existem chamados abertos no momento.", ConsoleColor.Yellow);
                return;
            }

            for (int i = 0; i < chamadosCadastrados.Length; i++)
            {
                Chamado c = chamadosCadastrados[i];

                if (c == null)
                    continue;

                Console.WriteLine(
                    "ID: {0}, Equipamento: {1}, Título: {2}, Descrição: {3}, Data: {4}",
                    c.Id, c.IdEquipamento, c.Titulo, c.Descricao, c.DataChamado.ToShortDateString()
                );
            }

            Console.ReadLine();
            Console.WriteLine();
        }
        public void ExcluirChamado()
        {
            Console.Clear();

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("|            Gestão de Equipamentos            |");
            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine();

            Console.WriteLine("Excluindo Chamado...");

            VisualizarChamados(false);

            Console.Write("Digite o ID do chamado que deseja excluir: ");
            int idChamadoEscolhido = Convert.ToInt32(Console.ReadLine());

            if (!repositorio.ExisteChamado(idChamadoEscolhido))
            {
                Program.ExibirMensagem("O chamado mencionado não existe!", ConsoleColor.DarkYellow);
                return;
            }

            repositorio.ExcluirChamado(idChamadoEscolhido);

            Program.ExibirMensagem("O chamado foi excluído com sucesso!", ConsoleColor.Green);
        }

    }
}