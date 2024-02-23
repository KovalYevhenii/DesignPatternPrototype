namespace DesignPatternPrototype;
    /// <summary>
    /// Represents a ship in the cosmos.
    /// </summary>
public class CosmoShip : BaseShip, ICloneable
{
    protected readonly Engine _engine;
    /// <summary>
    /// Initializes a new instance of the <see cref="CosmoShip"/> class.
    /// </summary>
    public CosmoShip()
    {
        Weight = 120_4000;
        MaxCrewCapacity = 50;
        MaxLoadCapacity = 20_0000;
        _engine = new Engine("Ion engine turbo");
    }
    /// <summary>
    /// Creates a new ship that is a copy of the current instance.
    /// </summary>
    /// <returns>A new object that is a copy of this instance.</returns>
    public virtual object Clone()
    {
        return new CosmoShip()
        {
            Weight = Weight,
            MaxCrewCapacity = MaxCrewCapacity,
            MaxLoadCapacity = MaxLoadCapacity
        };
    }
    /// <summary>
    /// Moves the ship.
    /// </summary>
    public override void Move()
    {
        Console.WriteLine("I believe I can fly....");
    }
}
