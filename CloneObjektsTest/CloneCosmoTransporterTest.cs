using DesignPatternPrototype;

namespace CloneObjektsTest
{
    public class CloneCosmoTransporterTest
    {
        [Fact]
        public void Clone_CreatesIdenticalObj()
        {
            CosmoTransporter original = new()
            {
                IsResourceTransportabe = true,
                Weight = 130_4000,
                MaxCrewCapacity = 25,
                MaxLoadCapacity = 20_0000,
                Engine = new Engine("defaulf Ion engine")
            };
            CosmoTransporter clone = (CosmoTransporter)original.Clone();

            Assert.Equal(original.IsResourceTransportabe, clone.IsResourceTransportabe);
            Assert.Equal(original.Weight, clone.Weight);
            Assert.Equal(original.MaxCrewCapacity, clone.MaxCrewCapacity);
            Assert.Equal(original.MaxLoadCapacity, clone.MaxLoadCapacity);
            Assert.Equal(original.Engine.Type, clone.Engine.Type);
        }
    }
}