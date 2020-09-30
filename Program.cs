using System;

namespace AreaTrianguloRet
{
    class Program
    {
        static void Main(string[] args)
        {
        
        double Base;
        double altura;
        double area;
        
        Console.Write("Digite o valor da base: ");                   
        Base = double.Parse(Console.ReadLine());
        
        Console.Write("Digite o valor de altura: ");
        altura = double.Parse(Console.ReadLine());

        area = Base * altura /2; 

        Console.WriteLine("Resultado da area é: ");
        Console.WriteLine(area);
        Console.ReadKey();   
        
        }
    }
}
