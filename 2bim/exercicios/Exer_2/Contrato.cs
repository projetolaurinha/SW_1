namespace Exer_2;
class Contrato
{
     public string? Nome  {get;set;}
     public string? Email {get;set;}
     public string? CPF   {get;set;}

     public virtual string Base(){


        Console.WriteLine("seus dados") ;

        Console.Write ("seu nome: ");
        Nome = Console.ReadLine(); 

        Console.Write ("seu email: ");
        Email = Console.ReadLine();

        return vazio;
        
     }
}