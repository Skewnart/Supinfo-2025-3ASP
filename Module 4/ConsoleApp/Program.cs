namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var livre = new Livre()
            {
                Titre = "Les Misérables",
                Auteur = "Victor Hugo",
                Genre = Genre.Roman,
                DatePublication = new DateTime(1862, 1, 1),
                DispoMagasin = true,
                NombreDePages = 2598
            };

            Console.WriteLine(livre);

            var livre_2 = new Livre(livre);     //La copie implique qu'il y a maintenant deux références

            Console.WriteLine($"Temps estimé de lecture : {livre_2.TempsEstimeSeconds} s");
            Console.WriteLine($"Temps estimé de lecture : {livre_2.GetTempsEstimeSeconds()} s");
        }
    }
}