using System.Numerics;     

class Program
{
    static void Main(string[] args)
    {
        int n = 4;   
        int m = 8;   

       
        int[,] matrix = new int[n, m];
        Random random = new Random();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = random.Next(-100, 100);
            }
        }
        int count = 0;            
        BigInteger product = 1;   
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] > 0)
                {
                    count++;
                    product *= matrix[i, j];
                }
            }
        }

        double averageGeom = Math.Pow((double)product, 1.0 / count);

        Console.WriteLine("Среднее геометрическое положительных элементов матрицы: {0}", averageGeom);
    }
}
