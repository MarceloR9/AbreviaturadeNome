using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class Exercicio3
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine();
            nome = nome.ToUpper();
            Console.WriteLine($"Seu nome no crachá é: {Abreviatte($"{nome}")}");
            Console.WriteLine("Pressione qualquer tecla para sair!!!");
            
        }

        static string Abreviatte(string nome)
        {
            var meio = " ";
            var nomes = nome.Split(' ');
            for (var i = 0;  i < nomes.Length - 1; i++)
            {
                if (!nomes[i].Equals("de", StringComparison.OrdinalIgnoreCase) &&
                    !nomes[i].Equals("da", StringComparison.OrdinalIgnoreCase) &&
                    !nomes[i].Equals("do", StringComparison.OrdinalIgnoreCase) &&
                    !nomes[i].Equals("das", StringComparison.OrdinalIgnoreCase) &&
                    !nomes[i].Equals("dos", StringComparison.OrdinalIgnoreCase) &&
                    !nomes[i].Equals("e", StringComparison.OrdinalIgnoreCase))
                    meio += nomes[i][0] + ". ";
                      
            }
            return nomes[nomes.Length - 1] + "," + meio;





        }


    }
}