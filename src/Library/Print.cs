using System;
using System.Text;
using System.Threading;

namespace Ucu.Poo.GameOfLife
{
    public class Print
    {
        public static void PrintBoard(bool[,] b)
        {
            int width = b.GetLength(0);
            int height = b.GetLength(1);
            while (true)
            {
                Console.Clear();
                StringBuilder s = new StringBuilder();
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        if (b[x, y])
                        {
                            s.Append("|X|");
                        }
                        else
                        {
                            s.Append("___");
                        }
                    }
                    s.Append("\n");
                }
                Console.WriteLine(s.ToString());
                b = Game.CalculateGeneration(b);
                Thread.Sleep(300);
            }
        }
    }
}
