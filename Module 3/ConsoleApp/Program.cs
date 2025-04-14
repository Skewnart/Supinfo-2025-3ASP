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
                // ou
                table[i] = Math.Round(rand.NextDouble() * 45 - 10, 1);

                if (table[i] < -10 || table[i] >= 35)
                    i--;
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
        }
    }
}