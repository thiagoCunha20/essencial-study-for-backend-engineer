using System.Reflection;
using DataStructuresStudy.Util;

var dataStructureTypes = Assembly.GetExecutingAssembly().GetTypes()
    .Where(t => t.IsClass &&
                 !t.IsAbstract &&
                 t.Namespace == "DataStructuresStudy.DataStructures" &&
                 typeof(IDataStructures).IsAssignableFrom(t) &&
                 t != typeof(IDataStructures)
          )
    .ToArray();

foreach (var dataStructureType in dataStructureTypes)
{
    var instance = Activator.CreateInstance(dataStructureType);
    if (instance is IDataStructures dataStructureInstance)
    {
        Console.WriteLine($"-------------- {dataStructureType.Name} --------------");
        Console.WriteLine($"Start: {DateTime.Now}");
        dataStructureInstance.Run();
        Console.WriteLine($"End: {DateTime.Now}");
    }
}
