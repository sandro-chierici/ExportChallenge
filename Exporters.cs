using ExportChallenge.Application;
using ExportChallenge.Entities;

namespace ExportChallenge.Exporters
{
    #region Person Exporters
    public class PersonJSONExporter : Exporter<Person>, JSONExporter
    {
        public PersonJSONExporter(Person instance) : base(instance)
        {
        }

        public string Export() => $"{{ name: '{ExportableInstance.Name}'}}";
    }


    public class PersonCSVExporter : Exporter<Person>, CSVExporter
    {
        public PersonCSVExporter(Person instance) : base(instance)
        {
        }

        public string Export() => $",{ExportableInstance.Name}";
    }
    #endregion

    #region Car Exporters

    public class CarJSONExporter : Exporter<Car>, JSONExporter
    {
        public CarJSONExporter(Car instance) : base(instance)
        {
        }

        public string Export() => $"{{ model: '{ExportableInstance.Model}'}}";
    }


    public class CarCSVExporter : Exporter<Car>, CSVExporter
    {
        public CarCSVExporter(Car instance) : base(instance)
        {
        }

        public string Export() => $",{ExportableInstance.Model}";
    }

    #endregion

}
