namespace proj_pessoa;
class Pessoa

{
    public Pessoa(){
        this.Nome = "Não informado";
        this.Sobrenome = "Não informado";
        this.Idade = 0;

    }

    public Pessoa(string nome, int idade){
        this.Nome = nome;
        this.Sobrenome = "não informado";
        this.Idade= idade;
    }
      private string? Nome {get;set;}

      private string? Sobrenome {get;set;}
 
      private int Idade {get;set;}

      public void Alteranome(string nome){
        this.Nome= nome;
      }

      public void AlteraSobrenome (string sobrenome){
        this.Sobrenome = sobrenome;
      }

      public void Alteraidade (int idade){
        this.Idade = Idade;
      }

      public void MostraDados (){
        Console.WriteLine ("Nome: " + this.Nome);
        Console.WriteLine ("Sobrenome: " + this.Sobrenome);
        Console.WriteLine ("Idade: " + this.Idade);
      }


}
