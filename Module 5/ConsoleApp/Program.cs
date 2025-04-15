namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>()
            {
                new Chien("Rex", 12, "Berger Allemand"),
                new Chat("Ramses", 5),
                new Chat("Garfield", 7)
            };

            animals.Sort();

            foreach(Animal animal in animals)
            {
                Console.WriteLine($"{animal.GetInfos()}. Il fait {animal.EmettreSon()}");
            }
        }
    }
}