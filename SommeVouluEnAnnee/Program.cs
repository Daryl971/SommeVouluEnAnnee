namespace SommeVouluEnAnnee;

class Program
{
    static void Main(string[] args)
    {
        double capital = 1200;
        Console.WriteLine("Votre objectif :");
        double objectif = double.Parse(Console.ReadLine());

        int annees = 0;
        
        while (capital < objectif)
        {
            capital = capital * 1.013;
            annees++;

        }
        Console.WriteLine($"Il faudra {annees} ans avant d'atteindre l'objectif");
    }
}