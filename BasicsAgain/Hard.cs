
using System;
namespace BasicsAgain
{
    public class Hard
    {
        public static int CountTowns(int[][] map)
        {
            static int[][] Color(int[][] map, int x, int y, int color)
            {
                if (x >= 0 && y >= 0 && x < map.Length && y < map[x].Length && map[x][y] == 1)
                {
                    map[x][y] = color;
                    map = Color(map, x + 1, y, color);
                    map = Color(map, x - 1, y, color);
                    map = Color(map, x, y + 1, color);
                    map = Color(map, x, y - 1, color);
                }

                return map;
            }

            int k;
            int result = 1;
            for (int i = 0; i < map.Length ; i++)
            {
                for (int j = 0; j < map[i].Length; j++)
                {
                    if (map[i][j] == 1)
                    {
                        result += 1;
                        map = Color(map, i, j, result);


                    }
                }
            }

            /*foreach (int[] line in map)
            {
                foreach (int current in line)
                {
                    Console.Write(current);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }*/
            return result-1;
        }
    }
}
