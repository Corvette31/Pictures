using System;

namespace Pictures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int picturesInRow = 3;
            int totalPictures = 52;
            int extraPictures = totalPictures % picturesInRow;
            int filledRows = (totalPictures - extraPictures) / picturesInRow; 

            Console.WriteLine($"Полностью заполненных рядов с картинками : {filledRows} , картинок сверх меры : {extraPictures}");
        }
    }
}
