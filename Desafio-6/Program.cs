// Programa que le um ano e verifique se ele é bissexto. Um ano é bissexto se for divisível por 4, mas não por 100, exceto se for divisível por 400.

Console.Clear();

Console.WriteLine("Digite um ano:");
int ano = Convert.ToInt32(Console.ReadLine());

if (ano % 4 == 0) {
  if (ano % 100 == 0) {
    if (ano % 400 == 0) {
      Console.WriteLine("{0} e um ano bissexto!", ano);
    } else {
      Console.WriteLine("{0} nao e um ano bissexto!", ano);
    }
  } else{
    Console.WriteLine("{0} e um ano bissexto!", ano);
  }
} else {
  Console.WriteLine("{0} nao e um ano bissexto!", ano);
}