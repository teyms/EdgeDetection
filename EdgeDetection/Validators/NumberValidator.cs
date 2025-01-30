namespace Validators
{
    public static class NumberValidator
    {
        public static bool IsValidInputInteger(string? input, int min, int max)
        {
            // Check if the input is not null/empty
            if(string.IsNullOrEmpty(input)){
                Console.WriteLine("Input cannot be empty.");
                return false;
            }
            // parse the input as an integer
            if (int.TryParse(input, out int result))
            {
                if(result >= min && result <= max)
                    return true;
            }
            else
            {
                Console.WriteLine($"Invalid input. Please enter a valid integer within range {min} to {max}.");
                return false;
            }
            return false;
        }
    }
}
