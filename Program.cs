using ExportChallenge.Application;
using ExportChallenge.Entities;

var expList = new List<IExportable>()
{
    new Person() { Name = "Sandro" },
    new Car() { Model = "Skoda (skodella) "}
};


foreach (var exp in expList)
{
    Console.WriteLine(ExporterBuilder.GetJSONExporter(exp).Export());
}
