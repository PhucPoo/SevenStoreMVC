using System.Text;

namespace SevenStoreMVC.Helpers
{
    public class MyUtil
    {
        public static string UploadHinh(IFormFile Hinh, string folder)
        {
            try
            {
                var fullPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Hinh, folder, Hinh.FileName)");
                using (var myflie = new FileStream(fullPath, FileMode.CreateNew))
                {
                    Hinh.CopyTo(myflie);
                }
                return Hinh.FileName;
            } catch (Exception ex)
            {
                return string.Empty;            
            }
        }
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
