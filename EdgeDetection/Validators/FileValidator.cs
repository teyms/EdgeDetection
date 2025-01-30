namespace Validators
{
    public static class FileValidator
    {
        public static bool IsValidImageFile(string? filePath)
        {
            // Check if the input is not null/empty
            if(string.IsNullOrEmpty(filePath)){
                Console.WriteLine("Input cannot be empty.");
                return false;
            }
            // Check if the file exists
            if (!File.Exists(filePath))
            {
                Console.WriteLine("File does not exist.");
                return false;
            }

            // Validate file extension (PNG, JPG, JPEG)
            string extension = Path.GetExtension(filePath).ToLower();
            if (extension != ".png" && extension != ".jpg" && extension != ".jpeg")
            {
                Console.WriteLine("Invalid file extension. Only .png, .jpg, and .jpeg are allowed.");
                return false;
            }
            return true;
        }
    }
}
