namespace ConsoleApp
{
    public class Article : IStorable
    {
        public string Name { get; set; }
        public string ISBN { get; set; }
        public double Prix { get; set; }

        public Article(string name, string isbn, double prix)
        {
            this.Name = name;
            this.ISBN = isbn;
            this.Prix = prix;
        }

        public override string ToString()
        {
            return $"{this.Name} ({this.ISBN}) : {this.Prix}";
        }
    }
}
