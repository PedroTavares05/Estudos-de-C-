using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estudos_de_C_.models
{
    public class Calculadora
    {
        public void Somar(float x, float y)
        {
            Console.WriteLine($"A soma dos dois savlores{x} e {y} = {x + y}");
        }


        public void Subtracao(float x, float y)
        {
            Console.WriteLine($" o valor dos numeros {x} - {y} = {x - y}");
        }

        public void Multiplication(float x, float y)
        {
            Console.WriteLine($"A multiplicação dos numeros {x} e {y} = {x * y}");
        }
        public void Division(float x, float y)
        {
            Console.WriteLine($"a divisão dos numeros {x} e {y} = {x / y}");
        }
    }
}