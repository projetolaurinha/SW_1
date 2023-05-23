namespace exer_1;
class Program
{
    static void Main(string[] args)
    {
        Gato g = new Gato();
        Cao c = new Cao();
        Humano h = new Humano();

        Console.WriteLine("o gato " + g.Emite());
        Console.WriteLine("o cão " + c.Emite());
        Console.WriteLine("o humano  " + h.Emite());
    }
}
