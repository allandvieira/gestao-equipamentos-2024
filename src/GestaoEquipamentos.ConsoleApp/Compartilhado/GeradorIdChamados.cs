namespace GestaoEquipamentos.ConsoleApp.Compartilhado
{
    public static class GeradorIdChamados
    {
        private static int IdChamados = 0;

        public static int GerarIdChamado()
        {
            return ++IdChamados;
        }
    }
}