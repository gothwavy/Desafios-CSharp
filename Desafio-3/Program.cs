// Programa que le dois números inteiros e informe qual deles é o maior.

Console.WriteLine("Digite um numero:");
int primeiroNumero = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite outro numero:");
int segundoNumero = Convert.ToInt32(Console.ReadLine());

if (primeiroNumero > segundoNumero) {
  Console.WriteLine("O primeiro numero ({0}) e maior do que o segundo ({1})!", primeiroNumero, segundoNumero);
} else {
  Console.WriteLine("O segundo numero ({0}) e maior do que o primeiro ({1})!", segundoNumero, primeiroNumero);
}