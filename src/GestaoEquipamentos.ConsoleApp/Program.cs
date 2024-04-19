using GestaoEquipamentos.ConsoleApp.Chamados;
using GestaoEquipamentos.ConsoleApp.ModuloEquipamento;

namespace GestaoEquipamentos.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            TelaEquipamento telaEquipamento = new TelaEquipamento();
            TelaChamados telaChamado = new TelaChamados(); 

            bool opcaoSairEscolhida = false;
            char operacaoEscolhida;

            while (!opcaoSairEscolhida)
            {
                char opcaoEscolhida = ApresentarMenuPrincipal();

                switch (opcaoEscolhida)
                {
                    case '1':
                        operacaoEscolhida = telaEquipamento.ApresentarMenu();

                        if (operacaoEscolhida == 'S' || operacaoEscolhida == 's')
                            break;

                        if (operacaoEscolhida == '1')
                            telaEquipamento.CadastrarEquipamento();

                        else if (operacaoEscolhida == '2')
                            telaEquipamento.EditarEquipamento();

                        else if (operacaoEscolhida == '3')
                            telaEquipamento.ExcluirEquipamento();

                        else if (operacaoEscolhida == '4')
                            telaEquipamento.VisualizarEquipamentos(true);

                        break;

                    case '2': // Nova opção para controle de chamados
                        operacaoEscolhida = telaChamado.ApresentarMenu();

                        if (operacaoEscolhida == 'S' || operacaoEscolhida == 's')
                            break;

                        if (operacaoEscolhida == '1')
                            telaChamado.AbrirChamado();

                        else if (operacaoEscolhida == '2')
                            telaChamado.EditarChamado();

                        else if (operacaoEscolhida == '3')
                            telaChamado.FecharChamado();

                        else if (operacaoEscolhida == '4')
                            telaChamado.ExcluirChamado();

                        else if (operacaoEscolhida == '5')
                            telaChamado.VisualizarChamados(true);

                        break;

                    default: opcaoSairEscolhida = true; break;
                }
            }

            Console.ReadLine();
        }

        private static char ApresentarMenuPrincipal()
        {
            Console.Clear();

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("|            Gestão de Equipamentos            |");
            Console.WriteLine("------------------------------------------------");

            Console.WriteLine();

            Console.WriteLine("1 - Gerência de Equipamentos");
            Console.WriteLine("2 - Controle de Chamados");
            Console.WriteLine("S - Sair");

            Console.WriteLine();

            Console.Write("Escolha uma das opções: ");

            char opcaoEscolhida = Console.ReadLine()[0];

            return opcaoEscolhida;
        }

        public static void ExibirMensagem(string mensagem, ConsoleColor cor)
        {
            Console.ForegroundColor = cor;

            Console.WriteLine();

            Console.WriteLine(mensagem);

            Console.ResetColor();

            Console.ReadLine();
        }
    }
}