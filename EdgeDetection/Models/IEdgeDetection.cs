using System.Drawing;

namespace EdgeDetection{
    public interface IEdgeDetection
    {
        Bitmap ProcessEdgeDetection(Bitmap inputImage);
    }
}
