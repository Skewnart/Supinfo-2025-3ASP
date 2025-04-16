namespace ConsoleApp
{
    public class Auteur
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public virtual List<Livre> Bibliography { get; set; }
    }
}
