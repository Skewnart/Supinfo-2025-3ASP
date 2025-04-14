using System.Collections.Concurrent;
using System.Collections.Immutable;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // # Partie 1 : Boucles et Tableaux

            double[] table = new double[10];
            Random rand = new Random();

            for (int i = 0; i < table.Length; i++)
            {
                Console.Write($"Donnez une valeur pour la {i + 1}e valeur du thermomètre : ");
                table[i] = double.Parse(Console.ReadLine());

                //table[i] = Math.Round(rand.NextDouble() * 45 - 10, 1);

                //if (table[i] < -10 || table[i] >= 35)
                //    i--;
            }

            foreach (var row in table) { Console.WriteLine(row); }

            double mean = 0;
            int k = 0;
            while (k < table.Length)
                mean += table[k++];
            mean = Math.Round(mean / table.Length, 1);

            Console.WriteLine($"Moyenne : {mean}");

            double min = table[0], max = table[0];
            k = 1;
            do
            {
                if (table[k] < min) min = table[k];
                if (table[k] > max) max = table[k];
            } while (++k < table.Length);

            Console.WriteLine($"Min : {min}, Max : {max}");

            double[,] temperatures = new double[4, 7];
            for (int i = 0; i < temperatures.GetLength(0); i++)
                for (int j = 0; j < temperatures.GetLength(1); j++)
                    temperatures[i, j] = Math.Round(rand.NextDouble() * 45 - 10, 1);

            // # Partie 2 : Méthodes

            //var array = CreateArray(10);

            //Random random = new Random();
            //Populate(array, random);

            //Console.WriteLine(string.Join("\t", array));

            //double mean = GetMean(array);

            //Console.WriteLine($"Moyenne : {mean}");

            //DisplayFrozen(mean);

            //int[] array_int = GetInts(array);

            //int min = 0, max = 0;
            //GetMinMax(array_int, ref min, ref max);

            //Console.WriteLine($"Min : {min}, Max : {max}");

            //Swap(ref min, ref max);

            //Console.WriteLine($"Min : {max}, Max : {min}");
        }

        //public static double[] CreateArray(int dimension)
        //{
        //    return new double[dimension];
        //}

        //public static void Populate(double[] data, Random random)
        //{
        //    for(int i = 0; i < data.Length; i++)
        //    {
        //        data[i] = Math.Round(random.NextDouble() * 40 - 20, 1);
        //    }
        //}

        //public static double GetMean(double[] data)
        //{
        //    double mean = 0;
        //    for (int i = 0; i < data.Length; i++)
        //    {
        //        mean += data[i];
        //    }

        //    return mean / data.Length;
        //}

        //public static void DisplayFrozen(double mean)
        //{
        //    if (mean <= 0)
        //        Console.WriteLine("L'eau est gelée");
        //    else
        //        Console.WriteLine("L'eau n'est pas gelée");
        //}

        //public static int[] GetInts(double[] data)
        //{
        //    int[] array = new int[data.Length];
        //    for(int i = 0; i < data.Length; i++)
        //        array[i] = (int)data[i];

        //    return array;
        //}

        //public static void GetMinMax(int[] data, ref int min, ref int max)
        //{
        //    min = max = data[0];

        //    for (int i = 1; i < data.Length; i++)
        //    {
        //        if (data[i] < min) min = data[i];
        //        if (data[i] > max) max = data[i];
        //    }
        //}

        //public static void Swap(ref int min, ref int max)
        //{
        //    min ^= max;
        //    max ^= min;
        //    min ^= max;
        //}
    }
}