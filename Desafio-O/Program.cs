// Programa que le o peso e a altura de uma pessoa, calcula o IMC e informa a categoria.

Console.Clear();

Console.WriteLine("Digite a sua altura: (em metros -> ex: 1.88)");
double altura = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o seu peso:");
double peso = Convert.ToDouble(Console.ReadLine());

Console.Clear();

double imc = peso / (Math.Pow(altura, 2));

if (imc <= 18.5) {
  Console.WriteLine("Abaixo do peso!");
  Console.WriteLine("Seu IMC -> {0}", Math.Round(imc, 2));
} else if () {
  Console.WriteLine("Peso normal!");
  Console.WriteLine("Seu IMC -> {0}", Math.Round(imc, 2));
} else if () {
  Console.WriteLine("Sobrepeso!");
  Console.WriteLine("Seu IMC -> {0}", Math.Round(imc, 2));
} else if () {
  Console.WriteLine("Obesidade grau I!");
  Console.WriteLine("Seu IMC -> {0}", Math.Round(imc, 2));
} else if () {
  Console.WriteLine("Obesidade grau II!");
  Console.WriteLine("Seu IMC -> {0}", Math.Round(imc, 2));
} else {
  Console.WriteLine("Obesidade grau III!");
  Console.WriteLine("Seu IMC -> {0}", Math.Round(imc, 2));
}