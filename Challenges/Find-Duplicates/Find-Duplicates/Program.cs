namespace challenges_and_data_structures2
{
    internal class Program3
    {
        public static void Main(string[] args)
        {

            // Find-Duplicates
            int[] input1 = { 1, 2, 3, 1, 2, 3 };
            int[] output1 = FindDuplicates(input1);
            Console.WriteLine("Input: [16, 8 ,31, 17, 15, 23, 17, 8]");
            Console.WriteLine("Output: [" + string.Join(", ", output1) + "]");
        }
        static int[] FindDuplicates(int[] exampleArray)
        {
            int n = exampleArray.Length;
            bool[] seen = new bool[n];
            bool[] added = new bool[n];
            int[] tempArray = new int[n];
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (exampleArray[i] == exampleArray[j] && !added[j])
                    {
                        if (!seen[i])
                        {
                            tempArray[count++] = exampleArray[i];
                            added[i] = true;
                        }
                        seen[j] = true;
                        added[j] = true;
                    }
                }
            }

            int[] resultArray = new int[count];
            for (int i = 0; i < count; i++)
            {
                resultArray[i] = tempArray[i];
            }

            return resultArray;
        }
    }
}