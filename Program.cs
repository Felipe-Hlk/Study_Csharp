using System;
using System.Globalization;

namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 10.35784;
            int y = 25;
            string z = "Bruna";
            char s = 'F';

            Console.WriteLine();
            Console.WriteLine(" Hello World! ");
            Console.WriteLine();
            Console.WriteLine(" Good Day to Us ");
            Console.WriteLine();
            
            

            Console.WriteLine(x);
            Console.WriteLine(x.ToString("F2"));
            Console.WriteLine(x.ToString("F4"));
            Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));


            Console.WriteLine();
            Console.WriteLine(" RESULTADO = " + x);
            Console.WriteLine(" O Valor do troco é: " + x + " reais ");
            Console.WriteLine(" O Valor do troco é: " + x.ToString("F2") + " reais ");

            Console.WriteLine();
            Console.WriteLine(" A paciente " + z + " tem " + y + " anos e seu sexo é: " + s);


            Console.ReadLine();
        }
    }
}