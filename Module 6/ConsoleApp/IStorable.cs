namespace ConsoleApp
{
    public interface IStorable
    {
        string ISBN { get; set; }
    }

    public class StorableMisconfiguredException : Exception
    {
        public StorableMisconfiguredException(string? message, Exception? inner) : base(message, inner)
        {
        }
    }
}
