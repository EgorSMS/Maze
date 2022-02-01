using System;

namespace MAZE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Лабиринт!";
            Console.CursorVisible = false;
            int[,] maze =
            {
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 2, 0, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
                {0, 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0},
                {0, 1, 1, 1, 0, 1, 0, 1, 0, 1, 1, 1, 1, 1, 0, 1, 0},
                {0, 0, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 0, 0, 1, 0},
                {0, 1, 1, 1, 0, 1, 0, 1, 1, 1, 0, 1, 1, 1, 1, 1, 0},
                {0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0},
                {0, 1, 1, 1, 0, 1, 0, 1, 1, 1, 0, 1, 1, 1, 1, 1, 0},
                {0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
                {0, 1, 1, 1, 0, 1, 0, 1, 0, 1, 0, 1, 1, 1, 0, 1, 0},
                {0, 0, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 0, 0, 1, 0},
                {0, 1, 0, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 0, 1, 0},
                {0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 1, 0},
                {0, 1, 1, 1, 0, 1, 1, 1, 0, 1, 0, 1, 1, 1, 0, 1, 0},
                {0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0},
                {0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
            }; //17x16
            int x = 1;
            int y = 1;

            DrawMaze(maze);

            while (maze[1,16] != 2)
            {
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.UpArrow:
                        {
                            if (maze[x - 1, y] != 0)
                            {
                                maze[x, y] = 1;
                                maze[x - 1, y] = 2;
                                x -= 1;
                            }
                            break;
                        }

                    case ConsoleKey.DownArrow:
                        {
                            if (maze[x + 1, y] != 0)
                            {
                                maze[x, y] = 1;
                                maze[x + 1, y] = 2;
                                x += 1;
                            }
                            break;
                        }

                    case ConsoleKey.LeftArrow:
                        {
                            if (maze[x, y - 1] != 0)
                            {
                                maze[x, y] = 1;
                                maze[x, y - 1] = 2;
                                y -= 1;
                            }
                            break;
                        }

                    case ConsoleKey.RightArrow:
                        {
                            if (maze[x, y + 1] != 0)
                            {
                                maze[x, y] = 1;
                                maze[x, y + 1] = 2;
                                y += 1;
                            }
                            break;
                        }
                }
                DrawMaze(maze);
            }
            Console.Clear();
            Console.WriteLine("Вы победили!");
            Console.ReadKey();
        }

        private static void DrawMaze(int[,] maze)
        {
            Console.Clear();
            for (int i = 0; i < 17; i++)
            {
                for (int j = 0; j < 17; j++)
                {
                    if (maze[i, j] == 0) Console.Write("█");
                    else if (maze[i, j] == 2) Console.Write("*");
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
