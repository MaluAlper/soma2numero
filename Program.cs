using System;

namespace soma2numero
{
    class Program
    {
        static void Main(string[] args)
        {
            string   PrimeiroNumero, SegundoNumero;
           
            int num1, num2, soma;
           
            Console.Write("Digite o primeiro numero");
            PrimeiroNumero = Console.ReadLine();
           
            Console.Write("Digite o segundo numero ");
            SegundoNumero = Console.ReadLine();
           
            num1 = Int32.Parse (PrimeiroNumero);
            num2 = Int32.Parse (SegundoNumero);
            soma = num1 + num2;
            Console.WriteLine ("\nO resultado é {0}", soma);
}
    }
}