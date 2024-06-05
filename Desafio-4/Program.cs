// Programa que le três lados de um triângulo e verifique se eles formam um triângulo válido. Para isso, a soma de dois lados deve ser sempre maior que o terceiro lado.

Console.Clear();

Console.WriteLine("Digite o valor do primeiro lado do triangulo:");
int primeiroLado = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o valor do segundo lado do triangulo:");
int segundoLado = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o valor do terceiro lado do triangulo:");
int terceiroLado = Convert.ToInt32(Console.ReadLine());

if (primeiroLado <= segundoLado + terceiroLado ||
    segundoLado <= primeiroLado + terceiroLado ||
    terceiroLado <= primeiroLado + segundoLado)
{
  Console.WriteLine("Os lados formam um triangulo valido!");
}
else
{
  Console.WriteLine("Os lados nao formam um triangulo valido!");
}