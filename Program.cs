int A = Convert.ToInt32("5");
int B = 5 + A;

bool Condicao = Convert.ToBoolean(0);

decimal Valor = Convert.ToDecimal("100,85");

float Altura = float.Parse("1.80");

Console.WriteLine(A);
Console.WriteLine(B);
Console.WriteLine(Altura.ToString("F2"));


Console.WriteLine(Valor.ToString("C"));

Console.WriteLine(Condicao);
