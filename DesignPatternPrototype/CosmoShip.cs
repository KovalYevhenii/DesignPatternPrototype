namespace DesignPatternPrototype;
public class CosmoShip : BaseShip
{
    protected readonly Engine _engine;
    
    public CosmoShip()
    {
        Weight = 120_4000;
        MaxCrewCapacity = 50;
        MaxLoadCapacity = 20_0000;
        _engine = new Engine("Ion engine turbo");
    }
    public override void Move()
    {
        Console.WriteLine("I believe I can fly....");
    }
}
