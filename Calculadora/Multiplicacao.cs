using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Multiplicacao : Conta
    {
        public override void ImprimeResutlado()
        {
            Console.WriteLine("O resultado é: " + (Num1 * Num2));
        }
    }
}