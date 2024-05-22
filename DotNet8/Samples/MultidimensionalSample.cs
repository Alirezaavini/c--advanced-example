namespace DotNet8.Samples
{
    public static class MultidimensionalSample
    {
        public static int[,] GetArray()
        {
            return new int[,] {
               { 1,2,3}, //row
               { 4,5,6}, //row
               { 7,8,9}, //row
            };
        }
    }
}
