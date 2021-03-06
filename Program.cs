using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marquezani
{
    class Program
    {

        static int[] vetor = new int[] { 1, 2, 3, 11, 5, 123, 5, 9, 2, 4, 44 };

        static void Trocar(int[] vetor, int pos1, int pos2)
        {

            int aux = 0;
            aux = vetor[pos1];
            vetor[pos1] = vetor[pos2];
            vetor[pos2] = aux;

        }

        /// <summary>
        /// Imprimir o vetor.
        /// </summary>
        /// <param name="vetor"></param>
        static void ImprimeFor(int[] vetor)
        {

            //for (int i = 0; i < vetor.Length; i++)
            //{
            //    if (i == 10)
            //        Console.Write(vetor[i]);
            //    else
            //        Console.Write(vetor[i] + "\t");
            //}

            for (int i = 0, n = vetor.Length; i < n; ++i)
            {
                if (i == 10)
                    Console.Write(vetor[i]);
                else
                    Console.Write(vetor[i] + "\t");
            }

            Console.WriteLine("\n");

        }

        static void ImprimeForEach(int[] vetor)
        {

            int indice = 0;
            int temp = 0;

            foreach (var item in vetor)
            {
                if (temp == 0)
                    Console.WriteLine("\n");
                else
                    Console.Write("\t");

                Console.Write(vetor[temp]);

                if (indice == 1)
                    temp = indice + 1;
                else
                    temp = temp + 1;

            }

            Console.WriteLine("\n");

        }

        static void Usuario()
        {

            Mensagem("Digite por favor o tamanho do seu veto: ", 2);
            int tamanhovetor = Convert.ToInt32(Console.ReadLine());
            Mensagem("Por favor digite os numeros para o vetor \n Condizente ao tamanho do vetor: ", 2);
            string valorpos = Console.ReadLine();

            string[] cortar = valorpos.Split(' ');

            foreach (string s in cortar)
            {

                Console.Write(s + "\t");

            }

        }

        static void Mensagem(string mensagem, int pos)
        {

            switch (pos)
            {

                case 1:
                    Console.WriteLine(mensagem);
                    break;

                case 2:
                    Console.Write(mensagem);
                    break;

                default:
                    Console.WriteLine(mensagem);
                    break;
            }

        }

        static void Main(string[] args)
        {

            int pos1 = 0;
            int pos2 = 0;


            ImprimeFor(vetor);
            Trocar(vetor, 1, 3);
            ImprimeFor(vetor);

            Mensagem("Digite as posições que deseja trocar, meu anjo!", 0);
            Mensagem("Posição 1: ", 2);
            pos1 = Convert.ToInt32(Console.ReadLine());

            if (pos1 < 0 || pos1 > vetor.Length)
            {
                do
                {
                    Console.Clear();
                    Mensagem($"Esse numero {pos1} não é valido.", 1);
                    Mensagem("Digite um numero valido para a posição 1. ", 1);
                    Mensagem("Posição 1: ", 2);
                    pos1 = Convert.ToInt32(Console.ReadLine());
                } while (pos1 < 0 || pos1 > vetor.Length);
            }

            Mensagem("\nPosição 2: ", 2);
            pos2 = Convert.ToInt32(Console.ReadLine());

            if (pos2 < 0 || pos2 > vetor.Length)
            {
                do
                {
                    Console.Clear();
                    Mensagem($"\nEsse numero {pos2} não é valido.", 1);
                    Mensagem("Digite um numero valido para a posição 2. ", 1);
                    Mensagem("Posição 2: ", 2);
                    pos2 = Convert.ToInt32(Console.ReadLine());
                } while (pos2 < 0 || pos2 > vetor.Length);
            }

            Mensagem("Resultado do vetor agora: ", 1);
            Trocar(vetor, pos1, pos2);
            ImprimeFor(vetor);

            Usuario();

            Console.ReadKey();

        }
    }
}
