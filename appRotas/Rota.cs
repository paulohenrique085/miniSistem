using System;
using System.Collections.Generic;
using System.Text;

namespace appRotas
{
    class Rota
    {   
        //criando um sistema de controle de rotas, proximo passo criar class motorista

        public int NumeroDarota { get; set; }
        public string Estado { get; set; }
        private double _investimento;
        public string CidadeInicial { get; set; }
        public string CidadeFinal { get; set; }
        //propriedade get e set com regra de negócio
        public double Investimento{
            get
            {
                return _investimento;
            }
            set
            {
                if (value<0)
                {
                    return;
                }
                else
                {
                    _investimento = value;
                }
            }
        }
        
        public static int TotalDeRotas { get; private set; }
        //construtor
       public Rota(int numeroRota,string cidadeInicial, string cidadeFinal,string estado,double investimento)
        {
            NumeroDarota = numeroRota;
            CidadeInicial = cidadeInicial;
            CidadeFinal = cidadeFinal;
            Estado = estado;
            TotalDeRotas++;

        }
    }
}
