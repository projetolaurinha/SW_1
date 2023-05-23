namespace Exer_2;
class Contratopessoa: Contrato
{
   public long CPF {get;set;}

    public override string Base()
    {
        base.Base();

        Console.Write ("seu cpf: ");
        CPF = Console.ReadLine();

        return vazio;
    }
}
