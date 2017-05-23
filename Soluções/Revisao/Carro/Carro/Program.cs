using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioRevisao
{
    class Program
    {
        public struct Carro
        {
            public string Modelo;
            public double Quilometragem;
            public int Potencia;
            public string Placa;
            public string Cor;
            public string Fabricante;
            public int Ano;

        }

        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Informe a quantidade de carros");
            n = int.Parse(Console.ReadLine());
            Carro[] carros = new Carro[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Informe o modelo do carro {0}", i + 1);
                carros[i].Modelo = Console.ReadLine();
                Console.WriteLine("Informe a quilometragem do carro {0}", i + 1);
                carros[i].Quilometragem = double.Parse(Console.ReadLine());
                Console.WriteLine("Informe a potência do carro {0}", i + 1);
                carros[i].Potencia = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe a placa do carro {0}", i + 1);
                carros[i].Placa = Console.ReadLine();
                Console.WriteLine("Informe a cor do carro {0}", i + 1);
                carros[i].Cor = Console.ReadLine();
                Console.WriteLine("Informe o fabricante do carro {0}", i + 1);
                carros[i].Fabricante = Console.ReadLine();
                Console.WriteLine("Informe o ano do carro {0}", i + 1);
                carros[i].Ano = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
                Console.WriteLine(Classificar(carros[i]));
        }

        public static string Classificar(Carro c)
        {
            string classifRodagem, classifPot;

            if (c.Quilometragem <= 5000)
                classifRodagem = "Novo";
            else if (c.Quilometragem <= 30000)
                classifRodagem = "Seminovo";
            else
                classifRodagem = "Velho";

            if (c.Potencia < 120)
                classifPot = "Popular";
            else if (c.Potencia <= 200)
                classifPot = "Forte";
            else
                classifPot = "Potente";

            return String.Format("{0} - {1} - {2}", c.Modelo, classifRodagem, classifPot);
        }

        public static double CalcularTaxaDeUso(Carro a)
        {
            int ano = DateTime.Now.Year;
            double media;
            media = a.Quilometragem / (a.Ano - ano);
            return media;
        }
        public static void AtualizarKM(Carro s, double km)
        {
            s.Quilometragem = km;
        }
        public static void AtualizarCor(Carro b, string colornew)
        {
            b.Cor = colornew;
        }

    }
}