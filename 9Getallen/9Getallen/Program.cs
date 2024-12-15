namespace _9Getallen
{
    internal class Program
    {
        private static int[] numbers = new int[9];
        static void Main(string[] args)
        {
            Console.WriteLine("Getal opvragen uit 9");
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < numbers.Length;i++)
            {
                Console.Write($"Geef getal {i+1}/9 : ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            
            Console.Write("Welk getal van de 9 getallen wens je opniew te zien? ");
            int index = int.Parse(Console.ReadLine());
            Console.Write($"Jouw getal is {numbers[index-1]}");
            Console.ReadKey(true);


        }
    }
}
