namespace ConsoleApp
{
    public class Chien : Animal
    {
        public string Race { get; set; }

        public Chien(string nom, int age, string race) : base(nom, age) {
            this.Race = race;
        }

        public override string EmettreSon()
        {
            return "Wouf";
        }

        public override string GetInfos()
        {
            return $"{base.GetInfos()}. C'est un {this.Race}";
        }
    }
}
