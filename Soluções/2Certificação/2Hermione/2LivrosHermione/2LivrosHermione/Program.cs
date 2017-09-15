﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2LivrosHermione
{
    class Program
    {
        static void Main(string[] args)
        {
            double pph, hpd, tot = 0, totalPossi = 0;
            int n, i;

            Console.WriteLine("Informe a quantidade de livros");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade de páginas por hora");
            pph = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a quantidade de horas diárias");
            hpd = Convert.ToDouble(Console.ReadLine());


            Livro[] livros = new Livro[n];

            for (i = 0; i < n; i++)
            {
                Livro livro = new Livro();
                Console.WriteLine("Informe o título do livro");
                livro.titulo = Console.ReadLine();
                Console.WriteLine("Informe a quantidade de páginas");
                livro.paginas = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe os dias restantes para a leitura");
                livro.dias = int.Parse(Console.ReadLine());
                livros[i] = livro;

            }
            for (i = 0; i < n; i++)
            {

                if (livros[i].dias < livros[i].TempoLeituraHoras(pph) / hpd)
                {
                    Console.WriteLine("O livro é impossível de ser lido a tempo");
                    tot = tot + 1;
                }
                else
                {
                    Console.WriteLine("O livro é possível de ser lido");
                    totalPossi = totalPossi + livros[i].TempoLeituraHoras(pph);
                }

                Console.WriteLine("{0} são impossíveis de serem lidos.", tot);
            }
        }
    }
}
