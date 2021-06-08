using System;
using System.Collections.Generic;
using System.Text;

namespace FatorialAtividade2.FatorialValores
{
    class Fatorial
    {
        public string str_final = "Saída: ";
        private int valor_final;

        public Fatorial(int valor)
        {
            this.str_final += GerarFatorial(valor);
        }

        private int GerarFatorial(int valor)
        {
            if (valor < 1)
                valor_final = 1;

            if (valor > 0)
                valor_final = valor * GerarFatorial(valor - 1);

            return valor_final;
        }
    }
}
