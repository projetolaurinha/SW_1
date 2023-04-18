namespace banco;
class Program
{
    static void Main(string[] args)
    {
       Conta conta = new Conta ();

       Console.Write ("Digite o valor do seu emprestimo:");
       conta.Valor= double.Parse( Console.ReadLine());

       Console.WriteLine("Seu emprestimo é de: " + conta.Valor);
       Console.WriteLine("Seu  juros do emprestimo é de: " + conta.obterjuros());
       Console.WriteLine("Seu emprestimo é de: " + conta.Mensal()+ "  por mes");
       

    }
}
