namespace DAL.Models
{
    public class Classroom 
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Floor { get; set; }

        public virtual ICollection<Student> Students { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
