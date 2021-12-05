using System;

namespace desafio_0_para_vetores_negativos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] posicoes = { -4, -3, -2, -1, 0, 1, 2, 3, 4, 5 };

            for (int i = 0; i < 10; i++)
            {
                if (posicoes[i] < 0)
                {
                    posicoes[i] = 0;
                }
            }

            foreach (int p in posicoes)
            {
                Console.WriteLine(p);
            }
        }
    }
}
