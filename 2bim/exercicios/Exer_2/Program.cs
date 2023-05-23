namespace Exer_2;
class Program
{
    static void Main(string[] args)
    {
       Contratopessoa pessoa = new Contratopessoa();
       Contratoempresa empresa = new Contratoempresa();

       Console.WriteLne ("Você é uma pessoa ou uma empresa?");
       string metrica = Console.ReadLine();

       switch (metrica)
       {
           case "pessoa":
                 Console.WriteLine(pessoa.Base());
                break;

    
    
            case "empresa":
                 Console.WriteLine(empresa.Base());
                break;


                default:
                  Console.WriteLine("Essa opção não existe"); 
                  break;
}

    }
}
