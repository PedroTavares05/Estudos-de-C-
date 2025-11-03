// int Contagem = 0;
// while (Contagem <= 10)
// {

//     Console.WriteLine("Escolha um numero para fazer a tabuada dele de 0 a 10");
//     string Escolha = Console.ReadLine() ?? "";
//     int Tabuada;
//     int.TryParse(Escolha, out Tabuada);

//     for (int contagem = 0; contagem <= 10; contagem++)
//     {

//         Console.WriteLine($"{Escolha} x {contagem} = {Tabuada * contagem}");
//     }
//     Contagem++;
//     if (Contagem == 6)
//     {
//         break;
//     }
// }
int numero = 0, soma = 0;
do
{
    Console.WriteLine("Digite um numero(0 para sair)");
    numero = Convert.ToInt32(Console.ReadLine() ?? "");
    soma += numero;
} while (numero != 0);
Console.WriteLine($"A soma dos valoires totais é de {soma} ");


// fazendo estruturas de repetição for, while e do while

// int tabuada = 10;

// for(int contagem = 0; contagem<=  10; contagem++ )
// {
//     Console.WriteLine($"{tabuada} x {contagem} = {tabuada * contagem}");
// }
// tabuada = 9;
// for (int regressivo = 10; regressivo >= 0; regressivo--)
// {
//     Console.WriteLine($" a tabuada  regresiva de 9 é = {tabuada * regressivo}");   
// }



// using Estudos_de_C_.models;
// Calculadora calc = new Calculadora();

// calc.Somar(20, 30);
// calc.Division(20, 2);
// calc.Multiplication(2, 5);
// calc.Subtracao(9, 5);
// calc.Potenciacao(3, 3);
// calc.Seno(9);
// calc.ConoSeno(9);
// calc.Tange(9);
// int Numero = 10;

// Console.WriteLine(Numero);
// Numero++;
// Console.WriteLine(Numero);
// calc.RaizQuadrada(9);
// calc.RaizQuadrada(200);
