using System;
using System.IO;

namespace Ucu.Poo.GameOfLife
{
    public class FileReader
    {
        public static bool[,] ReadFile()
        {
            try
            {
                string url = @"C:/Users/juana/prog_dos/PII_Game_Of_Life/assets/board.txt";
                string content = File.ReadAllText(url);
                string[] contentLines = content.Split('\n');
                bool[,] board = new bool[contentLines.Length, contentLines[0].Length];
                for (int y = 0; y < contentLines.Length; y++)
                {
                    for (int x = 0; x < contentLines[y].Length; x++)
                    {
                        if (contentLines[y][x] == '1')
                        {
                            board[x, y] = true;
                        }
                    }
                }
                return board;
            }
            catch (System.Exception e)
            {
                Console.WriteLine("Error al leer archivo! = " + e.Message);
                throw;
            }
        }
    }
}
