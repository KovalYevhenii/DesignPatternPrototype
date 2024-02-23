using DesignPatternPrototype;

namespace CloneObjektsTest
{
    public class CloneCosmoTransporterTest
    {
        [Fact]
        public void Clone_CreatesIdenticalObj()
        {
            CosmoTransporter original = new();
            CosmoTransporter clone = (CosmoTransporter)original.Clone();

            Assert.Equal(original.IsResourceTransportabe, clone.IsResourceTransportabe);
            Assert.Equal(original.Weight, clone.Weight);
            Assert.Equal(original.MaxCrewCapacity,clone.MaxCrewCapacity);
            Assert.Equal(original.MaxLoadCapacity,clone.MaxLoadCapacity);
            Assert.Equal(original.Engine.Type, clone.Engine.Type);
        }
    }
}