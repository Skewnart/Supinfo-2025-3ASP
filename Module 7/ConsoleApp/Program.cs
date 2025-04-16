namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookContext bookContext = new BookContext();
            bookContext.Database.EnsureCreated();

            bookContext.Books.Add(new Livre()
            {
                Title = "Les Misérables",
                DatePublication = new DateTime(1862, 1, 1)
            });

            bookContext.SaveChanges();

            bookContext.Authors.Add(new Auteur()
            {
                Name = "Victor Hugo",
                BirthDate = new DateTime(1802, 2, 26),
                Bibliography = new List<Livre>()
                {
                    bookContext.Books.First()
                }
            });

            bookContext.SaveChanges();

            var authors1 = (from p in bookContext.Authors
                            orderby p.BirthDate descending
                            select p).Take(5);

            var authors2 = bookContext.Authors.OrderByDescending(x => x.BirthDate).Take(5);
        }
    }
}