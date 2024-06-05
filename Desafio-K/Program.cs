// Programa que le um número e verifica se ele está no intervalo de 10 a 20.

Console.Clear();

Console.WriteLine("Digite um numero:");
int numero = Convert.ToInt32(Console.ReadLine());

if (numero >= 10 && numero <= 20) {
  Console.WriteLine("O numero esta no intervalo permitido!");
} else {
  Console.WriteLine("O numero nao esta no intervalo permitido!");
}
