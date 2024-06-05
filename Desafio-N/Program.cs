// Programa que le um número e informa se ele é positivo ou negativo. Se for positivo, calcule a raiz quadrada; se for negativo, informe o número ao quadrado.

Console.Clear();

Console.WriteLine("Digite um numero");
int numero = Convert.ToInt32(Console.ReadLine());

if (numero >= 0) {
  Console.WriteLine(Math.qrt(numero));
} else {
  Console.WriteLine(numero * numero);
}