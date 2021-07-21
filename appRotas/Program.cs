using System;

namespace appRotas
{
    class Program
    {
        static void Main(string[] args)
        {
            Rota rota1 = new Rota(01,"FORTALEZA","BEBERIBE","CEARA",1500);
            Console.WriteLine(rota1.Investimento);
        }
    }
}
