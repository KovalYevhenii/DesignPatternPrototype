using System.Text.Json;

namespace DesignPatternPrototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CosmoTransporter cosmoTransporter = new();
            cosmoTransporter.TransportResources();
            Console.WriteLine(JsonSerializer.Serialize(cosmoTransporter));

        }
    }
}
