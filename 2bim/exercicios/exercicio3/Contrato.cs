namespace exercicio03;
class Contrato


{
   public string? Nome {get;set;}

   public string? Email {get;set;}

   public string? Celular{get;set;}

   public virtual string MostraDados(){

      string Dados = this.Nome + "-" + this.Email + "-" + this.Celular;
      return Dados;

   }

   public int Prazo {get;set;}


   public virtual double Prestacao(){
        return 1200;
    }

    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override string? ToString()
    {
        return base.ToString();
    }
}
