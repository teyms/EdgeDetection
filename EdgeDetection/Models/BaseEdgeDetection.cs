using System.Drawing;

namespace EdgeDetection{
    public abstract class BaseEdgeDetection : IEdgeDetection
    {
        public int[,] KernelHorizontal { get; protected set; }
        public int[,] KernelVertical { get; protected set; }

        protected BaseEdgeDetection(int[,] kernelHorizontal, int[,] kernelVertical)
        {
            KernelHorizontal = kernelHorizontal;
            KernelVertical = kernelVertical;
        }

        protected int[,] ProcessFilter(Bitmap inputImage, int[,] kernel){
            int[,] outputImage = new int[inputImage.Width, inputImage.Height];

            // Loop thru the image
            for (int i = 1; i < inputImage.Height - 1; i++)
            {
                for (int j = 1; j < inputImage.Width - 1; j++)
                {
                    //Apply Kernel
                    double value = 
                        (kernel[0, 0] * inputImage.GetPixel(j - 1, i - 1).R) +
                        (kernel[0, 1] * inputImage.GetPixel(j - 1, i).R) +
                        (kernel[0, 2] * inputImage.GetPixel(j - 1, i + 1).R) +
                        (kernel[1, 0] * inputImage.GetPixel(j, i - 1).R) +
                        (kernel[1, 1] * inputImage.GetPixel(j, i).R) +
                        (kernel[1, 2] * inputImage.GetPixel(j, i + 1).R) +
                        (kernel[2, 0] * inputImage.GetPixel(j + 1, i - 1).R) +
                        (kernel[2, 1] * inputImage.GetPixel(j + 1, i).R) +
                        (kernel[2, 2] * inputImage.GetPixel(j + 1, i + 1).R); 

                    int finalValue = (int)value;
                    outputImage[j,i] = finalValue;
                }
            }

            return outputImage;
        }

        public abstract Bitmap ProcessEdgeDetection(Bitmap inputImage);
    }
}
