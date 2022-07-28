using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public abstract class Conta
    {
        public double Num1 { get; private set; }
        public double Num2 { get; private set; }
        public void EntradaDosValores()
        {
            Console.WriteLine("Digite o primeiro número:");
            Num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            Num2 = double.Parse(Console.ReadLine());
        }
        public abstract void ImprimeResutlado();
    }
}