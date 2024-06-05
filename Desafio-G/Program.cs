// Programa que le a idade de uma pessoa e informa se ela é uma criança (0-12 anos), adolescente (13-17 anos), adulto (18-59 anos) ou idoso (60 anos ou mais).

Console.Clear();

Console.WriteLine("Digite a sua idade:");
int idade = Convert.ToInt32(Console.ReadLine());

if (idade >= 60) {
  Console.WriteLine("Voce tem {0} anos, e é considerado(a) um idoso!", idade);
} else if (idade >= 18) {
  Console.WriteLine("Voce tem {0} anos, e é considerado(a) um adulto!", idade);
} else if (idade >= 13) {
  Console.WriteLine("Voce tem {0} anos, e é considerado(a) um adolescente!", idade);
} else {
  Console.WriteLine("Voce tem {0} anos, e é considerado(a) uma crianca!", idade);
}