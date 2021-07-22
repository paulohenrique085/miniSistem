using System;
using System.Collections.Generic;
using System.Text;

namespace appRotas
{
    class Veiculo
    {
        //true= boa condição false= más condições
        public bool CondicoesDoVeiculo { get; set; }
        public string Modelo { get; set; }

        //construtor
        public Veiculo(string modelo, bool condicaoDoVeiculo)
        {
            Modelo = modelo;
            CondicoesDoVeiculo = condicaoDoVeiculo;
        }

    }
}
