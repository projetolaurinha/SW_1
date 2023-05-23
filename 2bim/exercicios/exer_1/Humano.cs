namespace exer_1;
class Humano: Animal
{
    public override string Emite()
    {
        return base.Emite() + "oi oi";
    }
}