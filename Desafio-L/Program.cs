// Programa que le um número e verifica se ele é maior que 100. Se não for, informe o dobro desse número.

Console.Clear();

Console.WriteLine("Digite um numero:");
int numero = Convert.ToInt32(Console.ReadLine());

if (numero <= 100) {
  Console.WriteLine("{0}", numero * 2);
}