class A
{
    static void Main()
    {
        Console.Write("Enter the number of rows: ");
        int r = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of columns: ");
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine();

        int[,] matrix = new int[r, c];

        for (int i = 0; i < r; i++)
        {
            Console.WriteLine("Input " + c + " elements for row " + (i + 1) + " : ");
            for (int j = 0; j < c; j++)
            {
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
        }

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        for (int i = 0; i < r; i++)
        {
            int max = matrix[i, 0];
            int count = 0;

            for (int j = 0; j < c; j++)
            {
                if (matrix[i, j] > max)
                {
                    max = matrix[i, j];
                }
                else if (matrix[i, j] == max)
                {
                    count++;
                }
                else
                {
                    continue;
                }
            }

            if (count != c)
            {
                Console.WriteLine("The maximum value for row " + (i + 1) + " is: " + max);
            }
            else
            {
                Console.WriteLine("The maximum value for row" + (i + 1) + " : No" );
            }
        }
        
        Console.WriteLine();
        for (int i = 0; i < c; i++)
        {
            int min = matrix[0, i];
            int count = 0;

            for (int j = 0; j < r; j++)
            {
                if (matrix[j, i] < min)
                {
                    min = matrix[j, i];
                }
                else if (matrix[j, i] == min)
                {
                    count++;
                }
                else
                {
                    continue;
                }
            }

            if(count != r)
            {
                Console.WriteLine("The minimum value for column " + (i + 1) + " is: " + min);
            }
            else
            {
                Console.WriteLine("The minimum value for column " + (i + 1) + " : No");
            }
        }
    }
}