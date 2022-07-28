using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Divisao : Conta
    {
        public override void ImprimeResutlado()
        {
            if (Num2 == 0) throw new DivideByZeroException();
            else Console.WriteLine("O resultado é: " + (Num1 / Num2));
        }
    }
}