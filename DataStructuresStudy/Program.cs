using DataStructuresStudy.DataStructures;

var dataStructures = new List<Type> { typeof(List), typeof(LinkedList) };

foreach (var dataStructure in dataStructures)
{
    var instance = Activator.CreateInstance(dataStructure);
    if (instance is DataStructuresStudy.Util.IDataStructures dataStructureInstance)
    {
        Console.WriteLine($"-------------- {dataStructure.Name} --------------");
        Console.WriteLine($"Start: {DateTime.Now}");
        dataStructureInstance.Run();
        Console.WriteLine($"End: {DateTime.Now}");
    }
}
