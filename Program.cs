using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Informe o código do item:");
        int codigo = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Informe a quantidade:");
        int quantidade = Convert.ToInt32(Console.ReadLine());

        decimal precoUnitario = 0;

        switch (codigo)
        {
            case 100:
                precoUnitario = 1.10m;
                break;
            case 101:
                precoUnitario = 1.30m;
                break;
            case 102:
                precoUnitario = 1.50m;
                break;
            case 103:
                precoUnitario = 1.10m;
                break;
            case 104:
                precoUnitario = 1.30m;
                break;
            case 105:
                precoUnitario = 1.00m;
                break;
            default:
                Console.WriteLine("Código inválido!");
                return;
        }

        decimal valorTotal = precoUnitario * quantidade;

        Console.WriteLine("Valor a ser pago: R$" + valorTotal);
        Console.WriteLine("Código do item: " + codigo);
    }
}
