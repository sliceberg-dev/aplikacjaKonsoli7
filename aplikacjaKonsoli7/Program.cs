class Program
{
    
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj liczbe");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Podaj liczbe");
        int b = Convert.ToInt32(Console.ReadLine());
        while (a != b) { 
        
            if(a > b) {
                a = a - b;
            } else {
                b = b - a;
            }

        }
        Console.WriteLine($"Największy wspólny dzielnik to: {a}");

    }
}