class A
{
    static void Main()
    {
        string[,] chess = {
            { "0 ", "0 ", "0 ", "0 ", "0 ", "0 ", "0 ", "0 "},
            { "0 ", "0 ", "0 ", "0 ", "0 ", "0 ", "0 ", "0 "},
            { "0 ", "0 ", "0 ", "0 ", "0 ", "0 ", "0 ", "0 "},
            { "0 ", "0 ", "0 ", "0 ", "0 ", "0 ", "0 ", "0 "},
            { "0 ", "0 ", "0 ", "0 ", "0 ", "0 ", "0 ", "0 "},
            { "0 ", "0 ", "0 ", "0 ", "0 ", "0 ", "0 ", "0 "},
            { "0 ", "0 ", "0 ", "0 ", "0 ", "0 ", "0 ", "0 "},
            { "0 ", "0 ", "0 ", "0 ", "0 ", "0 ", "0 ", "0 "},
        };

        for (int i = 0; i < chess.GetLength(0); i++)
        {
            for (int j = 0; j < chess.GetLength(1); j++)
            {
                Console.Write(chess[i, j]);
            }
            Console.WriteLine();
        }
        
        Console.WriteLine();
        Console.Write("Enter the number of row from 1 to 8: ");
        int r = int.Parse(Console.ReadLine()) - 1;
        Console.Write("Enter the number of column from 1 to 8: ");
        int c = int.Parse(Console.ReadLine()) - 1;
        Console.WriteLine();

        for (int i = 0; i < 8; i++)
        {
            chess[i, c] = "1 ";
            chess[r, i] = "1 ";
        }

        for (int i = -7; i < 8; i++)
        {
            int r1 = r + i;
            int c1 = c + i;

            if (r1 >= 0 && r1 < 8 && c1 >= 0 && c1 < 8)
            {
                chess[r1, c1] = "1 ";
            }
            else
            {
                continue;
            }
        }

        for (int k = -7; k < 8; k++)
        {
            int r2 = r - k;
            int c2 = c + k;

            if (r2 >= 0 && r2 < 8 && c2 >= 0 && c2 < 8)
            {
                chess[r2, c2] = "1 ";
            }
            else
            {
                continue;
            }
        }

        chess[r, c] = "Q ";

        for (int i = 0; i < chess.GetLength(0); i++)
        {
            for (int j = 0; j < chess.GetLength(1); j++)
            {
                Console.Write(chess[i, j]);
            }
            Console.WriteLine();
        }

        do
        {
            Console.WriteLine();
            Console.Write("Do you want to continue? (y/n): ");
            string answer = Console.ReadLine().ToLower();

            int[] x = new int[64];
            int[] y = new int[64];

            int n = 0;
            for (int i = 0; i < chess.GetLength(0); i++)
            {
                for (int j = 0; j < chess.GetLength(1); j++)
                {
                    if (chess[i, j] == "0 ")
                    {
                        x[n] = i;
                        y[n] = j;
                        n++;
                    }
                }
            }
            Console.WriteLine(n);
            if (n == 0)
            {
                Console.WriteLine("There is no free spaces.");
                break;
            }

            if (answer == "y")
            {
                Random random = new Random();
                int m = random.Next(n);

                for (int i = 0; i < 8; i++)
                {
                    chess[i, y[m]] = "1 ";
                    chess[x[m], i] = "1 ";
                }

                for (int i = -7; i < 8; i++)
                {
                    int r1 = x[m] + i;
                    int c1 = y[m] + i;

                    if (r1 >= 0 && r1 < 8 && c1 >= 0 && c1 < 8)
                    {
                        chess[r1, c1] = "1 ";
                    }
                    else
                    {
                        continue;
                    }
                }

                for (int k = -7; k < 8; k++)
                {
                    int r2 = x[m] - k;
                    int c2 = y[m] + k;

                    if (r2 >= 0 && r2 < 8 && c2 >= 0 && c2 < 8)
                    {
                        chess[r2, c2] = "1 ";
                    }
                    else
                    {
                        continue;
                    }
                }

                chess[x[m], y[m]] = "Q ";

                Console.WriteLine();
                for (int i = 0; i < chess.GetLength(0); i++)
                {
                    for (int j = 0; j < chess.GetLength(1); j++)
                    {
                        Console.Write(chess[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                break;
            }
        } while (true);
    }
}
