using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcula_Salario_2
{
    public class Funcionario
    {
        public string CPF { get; set; }
        public string Nome { get; set; } = string.Empty;
        public int DiasTraB { get; set; }
        public double ValorDiaria { get; set; }
        public double Sbase { get; private set; }
        public double Sliquido { get; private set; }
        public double Ir { get; private set; }

        public void SalarioBase ()
        {
            Sbase = DiasTraB * ValorDiaria;
        }

        public void ValorIr()
        {

            if (Sbase < 1903.00)
            {
                Ir = 0;
            }else if (Sbase > 1903.00 && Sbase <= 2826.65)
            {
                Ir = 7.50;
            }else if (Sbase > 2826.65 && Sbase <= 3751.05)
            {
                Ir = 15.0;
            }else if (Sbase > 3751.05 && Sbase <= 4664.68)
            {
                Ir = 22.50;
            }

            Ir = (Ir/100) * Sbase; 

        }

        public void SalarioLiquido()
        {
            Sliquido = Sbase - Ir;
        }
    }
}
