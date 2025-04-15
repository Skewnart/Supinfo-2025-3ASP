namespace ConsoleApp
{
    public abstract class Animal : IComparable<Animal>
    {
        protected string Nom { get; set; }
        public int Age { get; set; }

        public Animal(string nom, int age)
        {
            Nom = nom;
            Age = age;
        }

        public virtual string GetInfos()
        {
            return $"{this.GetType().Name} : {this.Nom}, {this.Age} ans";
        }

        public abstract string EmettreSon();

        public int CompareTo(Animal? other)
        {
            return other == null ? 1 : this.Age.CompareTo(other.Age);
        }
    }
}
