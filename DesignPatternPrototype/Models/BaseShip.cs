namespace DesignPatternPrototype;
public abstract class BaseShip
{
    public int MaxCrewCapacity { get; set; }
    public double Weight { get; set; }
    public int MaxLoadCapacity { get; set; }
    public abstract void Move(); 
}
