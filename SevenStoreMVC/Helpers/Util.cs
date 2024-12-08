using System.Text;

namespace SevenStoreMVC.Helpers
{
    public class Util
    {
        public static string GenerateRamdomKey(int length =5)
        {
            var pattern = @"adiuqhwhcbkjdhfuiwehvhkjsdnfkjhiwehriw!";
            var sb = new StringBuilder();
            var rd = new Random();
            for (int i = 0; i < length; i++) 
            {
                sb.Append(pattern[rd.Next(0, pattern.Length)]);
            }

            return sb.ToString();
        }
    }
}
