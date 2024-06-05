// Programa que le três notas de um aluno e calcula a média. Informe se o aluno está aprovado (média >= 7), em recuperação (5 <= média < 7) ou reprovado (média < 5).

Console.Clear();

Console.WriteLine("Digite a primeira nota");
double primeiraNota = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite a segunda nota");
double segundaNota = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite a terceira nota");
double terceiraNota = Convert.ToDouble(Console.ReadLine());

double media = (primeiraNota + segundaNota + terceiraNota) / 3;

if (media >= 7) {
  Console.WriteLine("O aluno está aprovado!");
} else if (media >= 5) {
  Console.WriteLine("O aluno está em recuperação!");
} else {
  Console.WriteLine("O aluno está reprovado!");
}