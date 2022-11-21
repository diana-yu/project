internal class Program
{
    private static void Main(string[] args)
    {
        int[] array = {10,19,8,7,-6,5,4,578,2,1,1000000,7,456,567789543};
        int max = int.MinValue;
        
        for (int i = array.Length - 1; i >= 0 ; i--)
        {
           if(array[i] > max)
           {
                max = array [i];
           }           
        }

        Console.WriteLine(max);
    }
}