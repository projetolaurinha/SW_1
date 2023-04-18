namespace banco;
class Conta{
    public double Valor;

    public double obterjuros(){
        double Juros =((Valor* 0.06)*12)+ Valor;
        return Juros;
    }

    public double Mensal(){
        double Mes =((Valor* 0.06)+ Valor/12);
        return Mes;
    }
    
}