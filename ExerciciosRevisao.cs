using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
	

    class Program
    {
        static void Main(string[] args)
        {
            string modelo, classkm, classpot;
            int pot;
            double km;

            Console.WriteLine("Informe o modelo do veículo:");
            modelo = Console.ReadLine();
            Console.WriteLine("Informe a quantidade de quilometros rodados do veículo:");
            km = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a potência do veículo:");
            pot = Convert.ToInt32(Console.ReadLine());
            
          
            if (km <= 5000)
              classkm = "Novo";

            else if ( km <= 30000)
              classkm = "Seminovo";
            
            else
              classkm = "Velho";
            
            
            if (pot > 200)
               classpot = "Potente";
     
            else if ( pot > 120 && pot <= 200)
               classpot = "Fote";
          
            else 
               classpot = "Popular";
          

            Console.WriteLine(" {0} - {1} - {2}", modelo, classkm, classpot);
            

        }
    }
}
