namespace DesignPatternPrototype;
/// <summary>
/// Represents an engine for a ship.
/// </summary>
public class Engine
{
    /// <summary>
    /// Gets or sets the type of the engine.
    /// </summary>
    public string Type { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="Engine"/> class.
    /// </summary>
    /// <param name="type">The type of the engine.</param>
    public Engine(string type) => Type = type;
    
}
