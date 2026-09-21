namespace Collecties;

internal class Program
{
    static void Main(string[] args)
    {

        int[] array;
        //array = new int[]{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        array = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        //array[0] = 1;
        //array[1] = 2;

        Console.WriteLine(array[^2]);

        int[] test = array[0..5];
        Console.WriteLine(test.Length);

        int[,] matrix = new int[2, 3] { { 1, 2, 3}, { 4, 5, 6 } };
        matrix[0, 2] = 3;

        int[][] jagged = new int[2][];
        jagged[0] = [1, 2, 3, 4];
        jagged[1] = [1, 2];

        foreach (int tmp in array) 
        {
            Console.WriteLine(tmp);
        }

        List<int> array2 = new(10);
        array2.Add(1);

        //Console.WriteLine(array2[4]);
        Dictionary<string, int> lookup = new();
        lookup["een"] = 1;
        lookup["twee"] = 2;
        lookup.Add("een", 10);


    }
}
