using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.Intrinsics.Arm;

namespace Course {
   class Program {
    static void Main(string[] args) {

       int cod1, qtd1, cod2, qtd2;
       double valor1, valor2, preco;

       string[] valores = Console.ReadLine().Split(' ');

       cod1 = int.Parse(valores[0]);
       qtd1 = int.Parse(valores[1]);
       valor1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

       valores = Console.ReadLine().Split(' ');

       cod2 = int.Parse(valores[0]);
       qtd2 = int.Parse(valores[1]);
       valor2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

       preco = valor1 * qtd1 + valor2 * qtd2;

       System.Console.WriteLine("Valor a pagar:  R$" + preco.ToString("F2", CultureInfo.InvariantCulture));
       System.Console.WriteLine("oi");



    }
   }
}
