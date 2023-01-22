namespace ExportChallenge.Entities
{
    /// <summary>
    /// Base interface for entities that needs to be Exported
    /// </summary>
    public interface IExportable
    {

    }

    /// <summary>
    /// Simple Entity
    /// </summary>
    public class Person : IExportable
    {
        public string? Name { get; set; }
    }

    /// <summary>
    /// Simple Entity
    /// </summary>
    public class Car : IExportable
    {
        public string? Model { get; set; }
    }

}
