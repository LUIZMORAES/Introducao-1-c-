using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main(string[] args)
        {
        int n1, n2, n3, n4, soma;
        n1 = Int16.Parse(Console.ReadLine());
        n2 = Int16.Parse(Console.ReadLine());
        n3 = Int16.Parse(Console.ReadLine());
        n4 = Int16.Parse(Console.ReadLine());
        soma = n1 + n2 + n3 + n4;
        Console.WriteLine(&quot;{0}&quot;, soma);
        // Parar o programa a espera de um ENTER
        Console.ReadKey();
    }
}

