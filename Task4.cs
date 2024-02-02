class Chess
{
    static void Main()
    {
        string[,] chess = { { "0 ", "0 ", "0 " , "0 ", "0 ", "0 ", "0 ", "0 "},
                         { "0 ", "0 ", "0 " , "0 ", "0 ", "0 ", "0 ", "0 "},
                         { "0 ", "0 ", "0 " , "0 ", "0 ", "0 ", "0 ", "0 "},
                         { "0 ", "0 ", "0 " , "0 ", "0 ", "0 ", "0 ", "0 "},
                         { "0 ", "0 ", "0 " , "0 ", "0 ", "0 ", "0 ", "0 "},
                         { "0 ", "0 ", "0 " , "0 ", "0 ", "0 ", "0 ", "0 "},
                         { "0 ", "0 ", "0 " , "0 ", "0 ", "0 ", "0 ", "0 "},
                         { "0 ", "0 ", "0 " , "0 ", "0 ", "0 ", "0 ", "0 "},
        };

        for(int i = 0; i < chess.GetLength(0); i++)
        {
            for(int j = 0; j < chess.GetLength(1); j++)
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

        chess[r, c] = "H ";

        int[] row = { 2, 1, -1, -2, -2, -1, 1, 2 };
        int[] col = { 1, 2, 2, 1, -1, -2, -2, -1 };

        for(int k = 0; k < 8; k++)
        {
            int r1 = r + row[k];
            int c1 = c + col[k];

            if (r1 >= 0 && r1 < 8 && c1 >= 0 && c1 < 8)
            {
                chess[r1, c1] = "1 ";
            }
            else
            {
                continue;
            }
        }

        for (int i = 0; i < chess.GetLength(0); i++)
        {
            for (int j = 0; j < chess.GetLength(1); j++)
            {
                Console.Write(chess[i, j]);
            }
            Console.WriteLine();
        }

        int count = 0;

        for (int i = 0; i < chess.GetLength(0); i++)
        {
            for (int j = 0; j < chess.GetLength(1); j++)
            {
                if (chess[i, j] == "1 ")
                {
                    count++;
                }
                else
                {
                    continue;
                }
            }
        }

        int[] x = new int[count];
        int[] y = new int[count];

        int n = 0;

        for (int i = 0; i < chess.GetLength(0); i++)
        {
            for (int j = 0; j < chess.GetLength(1); j++)
            {
                if (chess[i, j] == "1 ")
                {
                    x[n] = i;
                    y[n] = j;
                    n++;
                    chess[i, j] = "0 ";
                }
                else
                {
                    continue;
                }
            }
        }

        Console.WriteLine();
        Random random = new Random();
        int m = random.Next(x.Length);

        Console.Write("Do you want to continue? (y/n): ");
        string answer = Console.ReadLine().ToLower();
        Console.WriteLine();

        if(answer == "y")
        {
            chess[x[m], y[m]] = "H ";

            for (int k = 0; k < 8; k++)
            {
                int r1 = x[m] + row[k];
                int c1 = y[m] + col[k];

                if (r1 >= 0 && r1 < 8 && c1 >= 0 && c1 < 8)
                {
                    chess[r1, c1] = "1 ";
                }
                else
                {
                    continue;
                }
            }
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
            for (int i = 0; i < chess.GetLength(0); i++)
            {
                for (int j = 0; j < chess.GetLength(1); j++)
                {
                    Console.Write(chess[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}