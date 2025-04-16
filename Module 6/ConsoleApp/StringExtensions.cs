namespace ConsoleApp
{
    public static class StringExtensions
    {
        public static int ToInt32(this string str)
        {
            try
            {
                return int.Parse(str);
            }
            catch(Exception e)
            {
                throw new StringToIntConversionException(e);
            }
        }
    }

    public class StringToIntConversionException : Exception
    {
        public StringToIntConversionException(Exception? inner) : base("Conversion échouée", inner)
        { }
    }
}
