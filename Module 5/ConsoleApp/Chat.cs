namespace ConsoleApp
{
    public class Chat : Animal
    {
        public Chat(string nom, int age) : base(nom, age)
        {

        }

        public override string EmettreSon()
        {
            return "Miaou";
        }
    }
}
