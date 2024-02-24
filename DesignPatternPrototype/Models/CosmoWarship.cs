using DesignPatternPrototype.Interfaces;
namespace DesignPatternPrototype;
public class CosmoWarship : CosmoShip, IMyClonable<CosmoWarship>
{
    public int WeaponPower { get; set; }
    public void FireWeapons()
    {
        Console.WriteLine($"Firing weapons with power: {WeaponPower}");
    }
    public CosmoWarship MyClone()
    {
        return new CosmoWarship
        {
            Weight = Weight,
            MaxCrewCapacity = MaxCrewCapacity,
            MaxLoadCapacity = MaxLoadCapacity,
            WeaponPower = WeaponPower,
            Engine = Engine
        };
    }
    public override object Clone()
    {
        return MyClone();
    }
}
