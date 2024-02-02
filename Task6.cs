class A
{
    static void Main()
    {
        Console.Write("Enter the number of row: ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of columns: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();

        int[,]matrix = new int[m, n];

        Random random = new Random();
        List<int> used = new List<int>();

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                do
                {
                    matrix[i, j] = random.Next();
                } while (used.Contains(matrix[i, j]));
                
                used.Add(matrix[i, j]);
            }
        }

        for (int i = 0;i < m; i++)
        {
            for(int j = 0;j < n; j++)
            {
                Console.Write(matrix[i, j] + "   ");
            }
            Console.WriteLine();    
        }
    }
}