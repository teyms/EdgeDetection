using System.Drawing;
using System.Drawing.Imaging;
using EdgeDetection;
using Validators;

class Program
{
    private static readonly int OPERATOR_SELECTION_MIN = 1; 
    private static readonly int OPERATOR_SELECTION_MAX = 2;

    static void Main()
    {
        Bitmap? bitmap = null;
        Bitmap? outputBitmap = null;

        string? input;
        try
        {
            // Get input image path
            // Keep looping for prompt if input validation failed
            do{
                Console.WriteLine("\nPlease Enter Image File Path(Only .png, .jpg, and .jpeg are allowed):");
                input = Console.ReadLine();
            }while(!FileValidator.IsValidImageFile(input));

            
            // Read the image as a Bitmap
            bitmap = new Bitmap(input);

            // Get input for operator selection
            // Keep looping for prompt if input validation failed
            do{
                Console.WriteLine("\nEdge Detection Operator:");
                Console.WriteLine("1: Sobel");
                Console.WriteLine("2: Prewitt");
                Console.WriteLine("Please Select the  Edge Detection Operator:");
                input = Console.ReadLine();                
            }while(!NumberValidator.IsValidInputInteger(input, OPERATOR_SELECTION_MIN , OPERATOR_SELECTION_MAX));
            
            // Perform Edge Detection based on user input
            switch (Convert.ToInt32(input)){
                case 1:
                    SobelEdgeDetection sobel = new SobelEdgeDetection();
                    outputBitmap = sobel.ProcessEdgeDetection(bitmap); 
                    break;
                case 2:         
                    PrewittEdgeDetection prewitt = new PrewittEdgeDetection();
                    outputBitmap = prewitt.ProcessEdgeDetection(bitmap); 
                    break;      
            }

            // Save the bitmap as an image file (png)
            string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            string filePath = $"./images/output_{timestamp}.png"; // File path to save the image
            outputBitmap?.Save(filePath, ImageFormat.Png);

            Console.WriteLine($"\nImage saved to {filePath}");

        }
        catch (Exception ex)
        {
            // Handle any errors that occur during loading
            Console.WriteLine("Error loading image: " + ex.Message);
            Console.WriteLine("Error: " + ex);
        }finally{
            if(bitmap!=null) bitmap.Dispose();
        }
    }
}