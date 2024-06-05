// Programa que le o código de um produto e informa a sua categoria.

Console.Clear();

Console.WriteLine("Digite o codigo do produto:");
int codigo = Convert.ToInt32(Console.ReadLine());

Console.Clear();

Console.WriteLine("Categoria do produto:");
if (codigo <= 0 || codigo > 40) {
  Console.WriteLine("Codigo inválido");
} else {
  if (codigo <= 10) {
    Console.WriteLine("Alimento não-perecível");
  } else if (codigo <= 20) {
    Console.WriteLine("Alimento perecível");
  } else if (codigo <= 30) {
    Console.WriteLine("Vestuário");
  } else if (codigo <= 40) {
    Console.WriteLine("Eletrônicos");
  }
}