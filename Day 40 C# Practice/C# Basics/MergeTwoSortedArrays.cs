public class Program
{
    public static void Main()
    {
        int[] arr1 = [1, 2, 3, 4, 5, 6];
        int[] arr2 = [11, 12, 13, 14, 15, 16];
        int[] merged = new int[arr1.Length + arr2.Length];
        int i = 0, j = 0, k = 0;
        while (i < arr1.Length && j < arr2.Length)
        {
            if(arr1[i] < arr2[j])
            {
                merged[k++] = arr1[i++];
            }
            else
            {
                merged[k++] = arr2[j++];
            }
        }
        while(i<arr1.Length) merged[k++] = arr1[i++];
        while(j<arr2.Length) merged[k++] = arr2[j++];

        Console.WriteLine(string.Join(',',merged));
    }
}