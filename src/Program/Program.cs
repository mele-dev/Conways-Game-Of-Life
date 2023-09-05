
namespace Ucu.Poo.GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[,] leemosArchivo = FileReader.ReadFile();
            Print.PrintBoard(leemosArchivo);
        }
    }
}
