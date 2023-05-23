namespace Exer_2;
class Contratoempresa :Contrato
{
     public  string? CNPJ {get;set;}

    public override string Base()
    {
        base.Base;

        Console.Write ("CNPJ:  ");
        CNPJ= Console.ReadLine();
    }
}