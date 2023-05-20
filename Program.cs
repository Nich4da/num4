using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number of segments and the range (N K):");
        string[] input = Console.ReadLine().Split(' ');
        int n = int.Parse(input[0]);
        int k = int.Parse(input[1]);

        Console.WriteLine("Enter the population for each segment (separated by a space):");
        string[] populationInput = Console.ReadLine().Split(' ');
        int[] population = new int[n];

        for (int i = 0; i < n; i++)
        {
            population[i] = int.Parse(populationInput[i]);
        }

        int maxCustomers = GetMaxCustomers(population, k);
        Console.WriteLine("Maximum number of customers: " + maxCustomers);
    }

    static int GetMaxCustomers(int[] population, int k)
    {
        int maxCustomers = 0;

        for (int i = 0; i < population.Length; i++)
        {
            int currentSum = 0;

            for (int j = i; j <= i + k && j < population.Length; j++)
            {
                currentSum += population[j];
                maxCustomers = Math.Max(maxCustomers, currentSum);
            }
        }

        return maxCustomers;
    }
}
