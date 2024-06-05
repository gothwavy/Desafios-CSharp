// Programa que le a nota de um aluno e converte-a para conceito: A (nota >= 9), B (7 <= nota < 9), C (5 <= nota < 7), D (3 <= nota < 5) e F (nota < 3).

Console.Clear();

Console.WriteLine("Digite a nota do aluno:");
int nota = Convert.ToInt32(Console.ReadLine());

if (nota >= 9) {
  Console.WriteLine("Conceito da nota {0} -> A", nota);
} else if (nota >= 7) {
  Console.WriteLine("Conceito da nota {0} -> B", nota);
} else if (nota >= 5) {
  Console.WriteLine("Conceito da nota {0} -> C", nota);
} else if (nota >= 3) {
  Console.WriteLine("Conceito da nota {0} -> D", nota);
} else {
  Console.WriteLine("Conceito da nota {0} -> E", nota);
}
