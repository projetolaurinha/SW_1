namespace exercicio03;
class ContratoPF:Contrato
{

 public long CPF {get;set;}

   public int Idade {get;set;}

    public override string MostraDados(){
          string Dados = this.Nome + "-" + this.Email + "-" + this.Celular + "-" + this.Idade + "-" + this.CPF;
          return Dados;
    }
public override double Prestacao(){
    if (Idade <= 30)
    {
        return ((base.Prestacao()/Prazo)+1);
    }
    else if (Idade <= 40) 
    {
        return ((base.Prestacao()/Prazo)+2);
    }
    else if (Idade <= 50) 
    {
        return ((base.Prestacao()/Prazo)+3);
    }
    else 
    {
        return ((base.Prestacao()/Prazo)+4);
    }
}
  
}