// Programa que le um número inteiro e informe se ele é par ou ímpar. 

Console.WriteLine("Digite um numero:");
int numero = Convert.ToInt32(Console.ReadLine());

if (numero % 2 == 0) {
  Console.WriteLine("O numero e par!");
} else {
  Console.WriteLine("O numero e impar!");
}
