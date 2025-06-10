namespace test._10._06._25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr3 = { 4, 3, 2, 36, 6, 12, 11, 23, 5, 8, 1, 7 };
            int n3 = arr3.Length;

            
            for (int i = 1; i < n3; i++)
            {
                int key = arr3[i];
                int j = i - 1;
                while (j >= 0 && arr3[j] > key)
                {
                    arr3[j + 1] = arr3[j];
                    j--;
                }
                arr3[j + 1] = key;
            } 

            Console.Write("Подреден масив: ");
            Console.WriteLine(string.Join(" ", arr3));          
            Console.Write("Най-дълга поредица от най-малкото: ");
            int count = 1;
            Console.Write(arr3[0] + " ");

            for (int i = 1; i < n3; i++)
            {
                if (arr3[i] == arr3[i - 1] + 1)
                {
                    Console.Write(arr3[i] + " ");
                    count++;
                }
                else
                {
                    break;
                }
            }          
            Console.WriteLine();
            Console.WriteLine("Дължина: " + count);
        }
    }
}
