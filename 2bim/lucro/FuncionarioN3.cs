namespace lucro;
class FuncionarioN3: Funcionario


{

    public string? Cargo {get;set;}
    
     public  override double Lucro(){
        return 12000 * 0.02;
     }

}