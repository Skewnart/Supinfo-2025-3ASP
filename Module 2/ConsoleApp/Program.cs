namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // # Partie 1 : Console 

            Console.Write("Quel est votre nom : ");
            Console.ReadLine();

            Console.Write("Quel est votre âge : ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("\nAppuyez sur une touche pour terminer le programme...");
            Console.ReadKey();

            // # Partie 2 : Variables et opérateurs

            Console.Write("Donnez une marque de véhicule : ");
            string marque = Console.ReadLine();

            Console.Write("Donnez son modèle : ");
            string modele = Console.ReadLine();

            Console.WriteLine($"Vous avez donc une {marque} {modele}");

            Console.Write("Donnez sa date de mise en circulation : ");
            string date_str = Console.ReadLine();

            DateTime date;
            if (!DateTime.TryParse(date_str, out date) || date > DateTime.Now)
            {
                Console.Write($"Mauvaise date renseignée {date_str}");
                return;
            }

            TimeSpan span = DateTime.Now - date;
            int age_voiture = (new DateTime(1, 1, 1) + span).Year - 1;
            Console.WriteLine($"Votre voiture à {age_voiture} an{(age_voiture > 1 ? "s" : "")}.");

            int controle = age_voiture >= 4 ? (1 + ((age_voiture - 4) / 2)) : 0;
            Console.WriteLine($"Elle devrait avoir passé {controle} contrôle(s) technique(s).");

            if (age >= 18)
            {
                Console.WriteLine("Vous concernant, vous pouvez rouler cette voiture avec le permis adéquat.");
            }
            else
            {
                Console.WriteLine("Vous ne pouvez pas encore rouler cette voiture.");
            }
        }
    }
}