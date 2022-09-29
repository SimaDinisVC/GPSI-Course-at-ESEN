namespace MOD9_ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empresa Dino = new Empresa();

            Dino.NovoEmpregado("E1", 2000);
            Dino.NovoEmpregado("E2", 1000);
            Dino.NovoEmpregado("E3", 1500);
            Dino.NovoEmpregado("E4", 1700);
            Dino.NovoEmpregado("E5", 1200);

            Dino.Medio();
            Dino.maiorSalario();
        }
    }
}
