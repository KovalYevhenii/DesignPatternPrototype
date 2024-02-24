using DesignPatternPrototype;

namespace CloneObjektsTest;
public class CloneCosmoWarshipTest
{
    [Fact]
    public void Clone_CreatesIdenticalObj()
    {
        CosmoWarship original = new()
        {
            WeaponPower = 1,
            Weight = 130_7000,
            MaxCrewCapacity = 33,
            MaxLoadCapacity = 17_0000,
            Engine = new Engine(" Ion engine turbo")
        };
        CosmoWarship clone = (CosmoWarship)original.Clone();

        Assert.Equal(original.WeaponPower, clone.WeaponPower);
        Assert.Equal(original.Weight, clone.Weight);
        Assert.Equal(original.MaxCrewCapacity, clone.MaxCrewCapacity);
        Assert.Equal(original.MaxLoadCapacity, clone.MaxLoadCapacity);
        Assert.Equal(original.Engine.Type, clone.Engine.Type);
    }
}

