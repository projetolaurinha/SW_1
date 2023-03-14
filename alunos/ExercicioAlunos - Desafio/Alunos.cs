namespace ExercicioAlunos;
class Alunos

{
    public string nome= "";

    public double nota1, nota2;

    //media
      public double obtermedia(){
        double media= (nota1+nota2)/2;
        return media;
    }

    //situacao (aprovado/reprovado)

    public string obtersituacao(double media){
        string situacao="";
        if( media>=6){
            situacao="Aprovado";
        }else{
            situacao="Reprovado";
        }
        return situacao;
    }

    //mensagem (detalhes)

    public void mensagem(){
        double mediacalculada= obtermedia();
        string resultadosituacao= obtersituacao (mediacalculada);
        Console.WriteLine (nome+ " esta " +resultadosituacao+  " com media: "+mediacalculada);
    }
}