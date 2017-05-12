using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Highscore
{
    class Program
    {
        static void Main(string[] args)
        {
            #region variables
            bool active = true;
            bool loading = false;
            string[] nomes = new string[10] { "antoanne", "Lessa", "Jamv", "Barbara", "Leticia", "VoltaCris", "Dm", "SerAbissal", "Oifuturo", "VoltaLeo" };
            int[] highscore = new int[10] { 40, 60, 30, 20, 70, 90, 10, 50, 80, 100  };
            int newscore;
            int lastscoreposition = highscore.Length - 1;
            int lastnameposition = nomes.Length - 1;
            int numeroJogador = 1;
            int loadingtime = 0;
            int loadinganimation = 200;
            #endregion
            while (active)
            {
                #region bubbleSort
                int length = highscore.Length;

                int temp = highscore[0];
                string temp2 = nomes[0];

                for (int i = 0; i < length; i++)
                {
                    for (int j = i + 1; j < length; j++)
                    {
                        if (highscore[i] < highscore[j])
                        {
                            temp = highscore[i];
                            temp2 = nomes[i];

                            highscore[i] = highscore[j];
                            nomes[i] = nomes[j];

                            highscore[j] = temp;
                            nomes[j] = temp2;
                        }

                    }
                    Console.WriteLine("Nome: " + nomes[i] + "  ||   " + "Pontos: " + highscore[i]);
                    Console.WriteLine("-------------------------------------------------");
                }
                #endregion

                #region New scores
                Console.WriteLine("Qual seu nome, ser bissal");

                string novonome = Console.ReadLine().ToString();
                if (novonome == "" || novonome == null)
                {
                    novonome = ("Jogador" + numeroJogador);
                    numeroJogador++;
                }

                Console.WriteLine("Digite sua pontuação");

                while (!int.TryParse(Console.ReadLine(), out newscore))
                {
                    Console.WriteLine("insira um número");
                }

                if (newscore <= highscore[lastscoreposition])
                {
                    loading = true;
                    while (loading)
                    {
                        Console.WriteLine("Atualizando Highscore");
                        System.Threading.Thread.Sleep(loadinganimation);
                        Console.Clear();
                        loadingtime++;

                        Console.WriteLine("Atualizando Highscore.");
                        System.Threading.Thread.Sleep(loadinganimation);
                        Console.Clear();
                        loadingtime++;

                        Console.WriteLine("Atualizando Highscore..");
                        System.Threading.Thread.Sleep(loadinganimation);
                        Console.Clear();
                        loadingtime++;

                        Console.WriteLine("Atualizando Highscore...");
                        System.Threading.Thread.Sleep(loadinganimation);
                        Console.Clear();
                        loadingtime++;

                        if (loadingtime == 12)
                        {
                            loading = false;
                            loadingtime = 0;
                        }
                    }
                    Console.Clear();
                    Console.WriteLine("Pontuação muito baixa, insira outra");
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                }

                else
                {
                    highscore[lastscoreposition] = newscore;
                    nomes[lastnameposition] = novonome;
                    Console.Clear();
                    loading = true;

                    while (loading)
                    {
                        Console.WriteLine("Atualizando Highscore");
                        System.Threading.Thread.Sleep(loadinganimation);
                        Console.Clear();
                        loadingtime++;

                        Console.WriteLine("Atualizando Highscore.");
                        System.Threading.Thread.Sleep(loadinganimation);
                        Console.Clear();
                        loadingtime++;

                        Console.WriteLine("Atualizando Highscore..");
                        System.Threading.Thread.Sleep(loadinganimation);
                        Console.Clear();
                        loadingtime++;

                        Console.WriteLine("Atualizando Highscore...");
                        System.Threading.Thread.Sleep(loadinganimation);
                        Console.Clear();
                        loadingtime++;

                        if (loadingtime == 12)
                        {
                            loading = false;
                            loadingtime = 0;
                        }
                    }
                    Console.Clear();
                }
                #endregion
            }
        }

    }
}
