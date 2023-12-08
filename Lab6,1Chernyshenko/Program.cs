class Program
{
    static bool Simm(string S, int i, int j)
    {
        if (i >= j)
        {
            return true;
        }
        if (S[i] != S[j])
        {
            return false;
        }
        return Simm(S, i + 1, j - 1);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Введите строку:");
        string S = Console.ReadLine();

        Console.WriteLine("Введите индекс начала i:");
        int i = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите индекс конца j:");
        int j = Convert.ToInt32(Console.ReadLine());

        bool isSymmetric = Simm(S, i, j);
        Console.WriteLine("Симметричная ли часть строки S: " + isSymmetric);
    }
}