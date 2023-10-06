namespace HapinessArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] happiness = new int[] { 1,2,3,4,5 };
            UpgradeHappiness(happiness);
            Console.WriteLine("The updated happiness array is: ");
            foreach (int i in happiness)
            {
                Console.WriteLine(i);
            }
        }
        static void UpgradeHappiness(int[] happiness)
        {
            for(int i = 0; i < happiness.Length; i++)
            {
                happiness[i] = happiness[i] + 2;
            }
        }
    }
}