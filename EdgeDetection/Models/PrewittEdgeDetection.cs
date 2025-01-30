using System.Drawing;

namespace EdgeDetection
{
    public class PrewittEdgeDetection : BaseEdgeDetection
    {
        private static readonly int[,] PREWITT_KERNEL_HORIZONTAL = 
        {
            { -1, 0, 1 },
            { -1, 0, 1 },
            { -1, 0, 1 }
        };

        private static readonly int[,] PREWITT_KERNEL_VERTICAL = 
        {
            {  1,  1,  1 },
            {  0,  0,  0 },
            { -1, -1, -1 }
        };

        public PrewittEdgeDetection() : base(PREWITT_KERNEL_HORIZONTAL, PREWITT_KERNEL_VERTICAL){}

        public override Bitmap ProcessEdgeDetection(Bitmap inputImage)
        {
            int[,] horizontalEdges = ProcessFilter(inputImage, KernelHorizontal);
            int[,] verticalEdges = ProcessFilter(inputImage, KernelVertical);

            Bitmap result = new Bitmap(inputImage.Width, inputImage.Height);

            // Loop thru the image
            for (int i = 0; i < inputImage.Height; i++)
            {
                for (int j = 0; j < inputImage.Width; j++)
                {
                    int horizontalVal = horizontalEdges[j, i];
                    int verticalVal = verticalEdges[j, i];

                    // calculate magnitude
                    int magnitude = (int)Math.Sqrt(Math.Pow(horizontalVal, 2) + Math.Pow(verticalVal, 2));                    
                    magnitude = Math.Min(255, Math.Max(0, magnitude)); // Ensure the within 0 - 255 
                    result.SetPixel(j, i, Color.FromArgb(magnitude, magnitude, magnitude));
                }
            }

            return result;
        }
    }
}
