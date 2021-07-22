using System;

namespace appRotas
{
    class Program
    {
        static void Main(string[] args)
        {
            Rota rota1 = new Rota(01,"FORTALEZA","BEBERIBE","CEARA",1500);
            Veiculo veiculo1 = new Veiculo("SCANIA 100B-003", false);
            rota1.AdcionarVeiculo(veiculo1);

            
        }
    }
}
