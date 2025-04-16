namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // # Partie 1 : Générique / Collections

            Stock<Article> stock = new Stock<Article>();

            Article livre = new Article("Le Silmarilion", "0123456789111", 10.99);

            stock.Add(livre, 1);
            stock.Add(livre, 2);

            stock.Add(new Article("Dictionnaire", "9876543210999", 39.99), 5);

            // stock.RemoveWhen(x => x.Prix < 20);

            foreach(var row in stock.Storage)
            {
                Console.WriteLine($"{row.Key}, qté : {row.Value}");
            }

            // # Partie 2 : Méthodes d'extension / Exceptions

            int number = "ab".ToInt32();
            Console.WriteLine(number);
        }
    }
}