using System;

namespace Aula3107_Console
{
    class Program
    {
        public static int Num1 { get; set; }
        public static int Num2 { get; set; }
        public static int Op { get; set; }

        static void Main(string[] args)
        {

            //Console.WriteLine("Hello World!");
            //Console.ReadKey();

            Console.WriteLine("Digite o 1º número");
            Num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o 2º número");
            Num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual operação deseja realizar? " +
                "\n 1-somar " +
                "\n 2-subtrair " +
                "\n 3-dividir " +
                "\n 4-multiplicar");
            Op = int.Parse(Console.ReadLine());

            switch (Op)
            {
                case 1:
                    Console.WriteLine(Num1 + Num2);
                    Console.ReadKey();
                    break;

                case 2:
                    Console.WriteLine(Num1 - Num2);
                    Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine(Num1 / Num2);
                    Console.ReadKey();
                    break;
                case 4:
                    Console.WriteLine(Num1 * Num2);
                    Console.ReadKey();
                    break;

            }
            
            //Console.WriteLine("Você digitou: " + Id);
            //Console.ReadKey();



        }
    }
}
