namespace LABCOMPRAS22.Models
{
    public static class Repositorio
    {
        private static List<ContaBancaria> contas = new List<ContaBancaria>();
        
        public static List <ContaBancaria> Contas
        {
            get { return contas; }
        }

        public static void AdicionarContaBancaria(ContaBancaria NovaConta)
        {
            contas.Add(NovaConta);
        }

    }
}
