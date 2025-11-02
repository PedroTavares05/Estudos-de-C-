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
            Console.WriteLine($"A soma dos dois savlores {x} e {y} = {x + y}");
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
        public void Potenciacao(int x, int y)
        {
            Double Pot = Math.Pow(x, y);
            Console.WriteLine($"{x} elevaado a {y} = {Pot}");
        }
        public void Seno(double Angulo)
        {
            Double radiante = Angulo * Math.PI / 180;
            double Sen = Math.Sin(radiante);
            Console.WriteLine($"O seno de {Angulo} é = {Math.Round(Sen, 4)}");
        }
        public void ConoSeno(double Angulo)
        {
            Double radiante = Angulo * Math.PI / 180;
            Double CosSe = Math.Cos(radiante);
            Console.WriteLine($"O angulo do  Coseno é = {Math.Round(CosSe, 4)}");
        }
        public void Tange(Double Angulo)
        {
            Double radiante = Angulo * Math.PI / 180;
            Double Tandente = Math.Tan(radiante);
            Console.WriteLine($"O angulo ce {Angulo} da Tangente é = {Math.Round(Tandente, 4)}");
        }
        public void RaizQuadrada(Double x)
        {
            Double Raiz = Math.Sqrt(x);
            Console.WriteLine($"A raiz de {x} = {Raiz}");
        }
    }
}