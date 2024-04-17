using Microsoft.Extensions.Configuration;
using study.Builders;
using study.Entity;
using study.Service;
using study.utils;


namespace study
{
    internal class Program
    {
        internal EventService EventService { get; }


        static void Main(string[] args)
        {
            ((Program)Factory
                    .GetObject(typeof(Program)))
                .StartGame();
        }

        private void StartGame()
        {
            Player player = ContextFactory.GetContext().Player;
            char[,] map = ReadMap("Resource/map.txt");
            Console.Clear();
            DrawMap(map);
            Console.SetCursorPosition(player.Point.X, player.Point.Y);
            while (true)
            {
                EventService.ExecuteEvents();
                Console.WriteLine("@");
                Thread.Sleep(100);
            }
        }

        private void DrawMap(char[,] map)
        {
            for (int y = 0; y < map.GetLength(1); y++)
            {
                for (int x = 0; x < map.GetLength(0); x++)
                {
                    Console.Write(map[x, y]);
                }
                Console.WriteLine();
            }
        }

        private char[,] ReadMap(string path)
        {
            var file = File.ReadAllLines(path);
            var map = new char[file.GetMaxLength(), file.Length];
            for (int x = 0; x < map.GetLength(0); x++)
            {
                for (int y = 0; y < map.GetLength(1); y++)
                {
                    map[x, y] = file[y][x];
                }
            }
            return map;
        }
    }
}