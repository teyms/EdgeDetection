# Edge Detection Using Sobel/ Prewitt
  A C# .NET Console Application that accepts a grayscale image as an input and outputs an image after Edge Detection using either Sobel/ Prewitt.

## Prerequisites
- [.NET SDK](https://dotnet.microsoft.com/download) (8.0 or higher)

## Getting Started

1. Clone this repository:

   ```bash
   git clone https://github.com/teyms/EdgeDetection.git
2. Navigate to the project folder:

   ```bash
   cd EdgeDetection\EdgeDetection
3. Build and run the application:

   ```bash
    dotnet run
4. Enter ImagePath for grayscale image:

  ![image](https://github.com/user-attachments/assets/1134f9af-e679-4960-8d9d-9cb433ebbb9d)
5. Select to use Sobel/ Prewitt:

  ![image](https://github.com/user-attachments/assets/8114601f-b4d8-49e1-9962-6d14996385be)
6. The Output Image will be saved to /images, which can be found by:

  ![image](https://github.com/user-attachments/assets/c35a0f20-57f8-4894-8db1-c93df07357bb)

## Unit Test

1. Navigate to the test folder:

   ```bash
   cd EdgeDetection\EdgeDetection.Tests
2. Replace file path with absolute file path for files(FileValidatorTests.cs, SobelEdgeDetectionTests.cs, PrewittEdgeDetectionTests.cs)

  ![image](https://github.com/user-attachments/assets/620bf791-adbe-452a-804d-25b3d457287c)

4. Run test
   ```bash
    dotnet test
