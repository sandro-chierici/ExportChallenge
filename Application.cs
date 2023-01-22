using ExportChallenge.Entities;
using ExportChallenge.Exporters;

namespace ExportChallenge.Application
{
    #region Exporters Interfaces

    public interface JSONExporter
    {
        string Export();
    }

    public interface CSVExporter
    {
        string Export();
    }

    public interface XMLExporter
    {
        string Export();
    }


    public abstract class Exporter<E> where E : IExportable
    {
        protected E ExportableInstance;
        public Exporter(E instance) => ExportableInstance = instance;
    }

    #endregion

    /// <summary>
    /// Default implementation to avoid throws exceptions.
    /// If ther isn't any implementation yet for a specific entity 
    /// the System still works
    /// </summary>
    public class NullExporter : JSONExporter, CSVExporter, XMLExporter
    {
        string XMLExporter.Export() => $"XML Exporter not implemented yet";
        string JSONExporter.Export() => $"JSON Exporter not implemented yet";
        string CSVExporter.Export() => $"CSV Exporter not implemented yet";
    }

    /// <summary>
    /// De facto Facade Controller for Exporters.
    /// Takes care to build right Exporter for every kind of Export and every kind of Entity.
    /// In the future if many Antities comes it will be easy implement builders' methods using 
    /// an entity types registry
    /// </summary>
    public static class ExporterBuilder
    {
        public static JSONExporter GetJSONExporter(IExportable instance)
        {
            return instance switch
            {
                Person p => new PersonJSONExporter(p),
                Car car => new CarJSONExporter(car),

                _ => new NullExporter()
            };
        }

        public static CSVExporter GetCsvExporter(IExportable instance)
        {
            return instance switch
            {
                Person p => new PersonCSVExporter(p),
                Car car => new CarCSVExporter(car),

                _ => new NullExporter()
            };
        }
        public static XMLExporter GetXMLExporter(IExportable instance)
        {
            return instance switch
            {
                // Here i simulated haven't any implementation
                _ => new NullExporter()
            };
        }
    }
}
