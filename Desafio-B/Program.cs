// Programa que le um número inteiro e informe se ele é positivo, negativo ou zero.

Console.Clear();

Console.WriteLine("Digite um numero:");
int numero = Convert.ToInt32(Console.ReadLine());

if (numero > 0) {
  Console.WriteLine("O numero e positivo!");
} else if (numero < 0) {
  Console.WriteLine("O numero e negativo!");
} else {
  Console.WriteLine("O numero e igual a 0!");
}