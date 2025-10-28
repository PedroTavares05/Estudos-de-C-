// int A = Convert.ToInt32("5");
// int B = 5 + A;

// bool Condicao = Convert.ToBoolean(0);

// decimal Valor = Convert.ToDecimal("100,85");

// float Altura = float.Parse("1.80");

// Console.WriteLine(A);
// Console.WriteLine(B);
// Console.WriteLine(Condicao);
// Console.WriteLine(Valor.ToString("C"));
// Console.WriteLine(Altura.ToString("F2"));



// //Diferenças entre Conver e Parse

// int C = Convert.ToInt32(null); // vai converter o valor null para zero, melhor usar convert nesses casos
// Console.WriteLine(C);

// //int D = int.Parse("null"); vai dar erro pois não entende o valor null.
// //Console.WriteLine(D);  vai dar erro

// string Numercao = "15";

// int.TryParse(Numercao, out int U);
// Console.WriteLine(U);



// int QuantidadeEmEstoque = 80;
// int QuantidadeCompra = 100;
// bool Verificacao = QuantidadeCompra > 0 && QuantidadeCompra <= QuantidadeEmEstoque;

// Console.WriteLine($"A quantidade de conteudo em estoque é de: {QuantidadeEmEstoque} \n e a quantidade de itens de compra é de:{QuantidadeCompra}");
// Console.WriteLine($"A quantidade de estoque é o suficiente para efetuar a compra? {Verificacao}");
// if (QuantidadeCompra == 0)
// {
//     Console.WriteLine("Venda indalida");
// }
// else if (QuantidadeEmEstoque >= QuantidadeCompra)
// {
//     Console.WriteLine("A compra foi efetuada");
// }
// else
// {
//     Console.WriteLine("não temos quantidade no estoque");
// }


Console.WriteLine("Escreva uma letra");
string letra = Console.ReadLine();
if (letra == "a" || letra == "e" || letra == "o" || letra == "u" || letra == "i")
{
    Console.WriteLine("É uma vogal!");
}

else
{
    Console.WriteLine("NÃO É UMA VOGAL");
}