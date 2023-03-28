namespace proj_loja;
class Produto
{

    public Produto (string nome, int desconto){
        this.Nome= nome;
        this.Preco = 10 -(10*desconto/100);
    }
   public Produto (string nome){
        this.Nome= nome;
        this.Preco = 10;
    }

     public Produto (){
        this.Nome= "TicToc";
        this.Preco = 10;
    }

   private string? Nome {get;set;}

   private double Preco {get;set;}

   public void Alteranome (string nome){
    this.Nome = nome;
   }

   public void Alterapreco (double preco){
    this.Preco = preco;
   }

   public void MostraDados(){
    Console.WriteLine("Nome: "+ this.Nome);
    Console.WriteLine("Preco: " + this.Preco);
   }
}
