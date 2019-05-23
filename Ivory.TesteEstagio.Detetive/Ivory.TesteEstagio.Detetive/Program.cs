using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ivory.TesteEstagio.Detetive
{
    class Program
    {
        static void Main(string[] args)
        {
            var testemunha = new Testemunha();

            //Para testar a funcionalidade do algoritmo
            //Console.WriteLine("Opções escolhidas pelo computador:\n");
            //Console.WriteLine("Criminoso - "+ testemunha.Criminoso);
            //Console.WriteLine("Local - " + testemunha.Local);
            //Console.WriteLine("Arma - " + testemunha.Arma);
            //Console.WriteLine("\n");

            //Variáveis locais
            int criminoso;
            int local;
            int arma;
            int retorno = 1;

            //Loop
            do
            {
                try
                {
                    Console.WriteLine("Digite o número referente ao criminoso dentre as pções abaixo:\n"+
                        "1 - Advogado Sr.Marinho\n"+
                        "2 - Chef.de Cozinha Tony Gourmet\n" +
                        "3 - Coveiro Sérgio Sortuno\n" +
                        "4 - Dançarina Srta.Rosa\n"+
                        "5 - Florista Dona Branca\n" +
                        "6 - Médica Dona Violeta\n" +
                        "7 - Mordomo James\n" +
                        "8 - Sargento Bigode\n");
                    criminoso = Convert.ToInt16(Console.ReadLine());

                    Console.WriteLine("\nDigite o número referente ao local dentre as pções abaixo:\n"+
                        "1 - Biblioteca\n" +
                        "2 - Cozinha\n" +
                        "3 - Hall\n" +
                        "4 - Escritório\n" +
                        "5 - Sala de estar\n" +
                        "6 - Sala de Jantar\n" +
                        "7 - Sala de música\n" +
                        "8 - Salão de festas\n" +
                        "9 - Salão de jogos\n");
                    local = Convert.ToInt16(Console.ReadLine());

                    Console.WriteLine("\nDigite o número referente ao local dentre as pções abaixo:\n" +
                        "1 - Castiçal\n" +
                        "2 - Cano\n" +
                        "3 - Chave Inglesa\n" +
                        "4 - Corda\n" +
                        "5 - Revólver\n" +
                        "6 - Faca\n");
                    arma = Convert.ToInt16(Console.ReadLine());

                    //Retornar resultado da investigação
                    retorno = testemunha.Interrogar(criminoso,local,arma);

                    if (retorno == 0)
                    {
                        Console.WriteLine("Parabéns, você descobriu qual foi o criminoso, o local e a arma!\n");
                    }
                    else if(retorno == 1)
                    {
                        Console.WriteLine("Retorno: " + retorno + " - Este não foi o criminoso.");
                    }
                    else if (retorno == 2)
                    {
                        Console.WriteLine("Retorno: " + retorno + " - Este não foi o local do crime.");
                    }
                    else if (retorno == 3)
                    {
                        Console.WriteLine("Retorno: " + retorno + " - Esta não foi a arma usada.");
                    }
                    Console.ReadKey();

                    Console.Clear();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Opção inválida, tente novamente");
                }
            }
            while (retorno != 0);

            //Fim do algoritmo
            Console.WriteLine("Número de Tentativas: " + testemunha.ObterNumeroInterogatoriosRealizados());
            Console.ReadKey();

        }
    }
}
