using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competição
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double t1, t2, t3;
            int n, i;
            
            Console.WriteLine("Quantos competidores?");
            n = int.Parse(Console.ReadLine());
              Competidor[] corredor = new Competidor [i];
            for (i = 0; i < n; i++)
            {
            Console.WriteLine("Informe o nome:");
            nome = Console.ReadLine();
            Console.WriteLine ("Informe o 1º tempo:");
            t1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o 2º tempo:");
            t2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o 3º tempo:");
            t3 = Convert.ToDouble(Console.ReadLine());
             }


             
           
        }
    }
}
