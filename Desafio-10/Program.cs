// Programa que le dois números e uma operação (adição, subtração, multiplicação ou divisão) e realiza a operação correspondente.

Console.Clear();

Console.WriteLine("Digite o primeiro numero");
double primeiroNumero = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o segundo numero");
double segundoNumero = Convert.ToDouble(Console.ReadLine());

Console.Clear();

Console.WriteLine("Digite o simbolo correspondente à operação:");
Console.WriteLine("Adição -> +");
Console.WriteLine("Subtração -> -");
Console.WriteLine("Multiplicação -> *");
Console.WriteLine("Divisão -> /");
string operação = Console.ReadLine();

Console.Clear();

if (operação == "+") {
  double resultado = primeiroNumero + segundoNumero;
  Console.WriteLine("A soma dos valores -> " + resultado);
} else if (operação == "-") {
  double resultado = primeiroNumero - segundoNumero;
  Console.WriteLine("A subtração dos valores -> " + resultado);
} else if (operação == "*") {
  double resultado = primeiroNumero * segundoNumero;
  Console.WriteLine("A multiplicação dos valores -> " + resultado);
} else if (operação == "/") {
  double resultado = primeiroNumero / segundoNumero;
  Console.WriteLine("A divisão dos valores -> " + resultado);
} else {
  Console.WriteLine("Operação inválida!");
}