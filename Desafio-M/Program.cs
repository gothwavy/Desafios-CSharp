// Programa que le o valor de uma compra e a categoria do cliente (1 para comum, 2 para associado e 3 para VIP).

Console.Clear();

Console.WriteLine("Digite o valor total da compra:");
double valorCompra = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("\nDigite a categoria do cliente:");
double categoriaCliente = Convert.ToDouble(Console.ReadLine());

double valorFinal;
if (categoriaCliente == 2) {
  valorFinal = valorCompra - (valorCompra * 0.1);
} else if (categoriaCliente == 3) {
  valorFinal = valorCompra - (valorCompra * 0.2);
} else {
  valorFinal = valorCompra;
}

Console.Clear();

Console.WriteLine("O valor final é: R${0}", valorFinal);