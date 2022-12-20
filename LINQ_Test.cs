// See https://aka.ms/new-console-template for more information

//var test = new RecyclingBin();
//test.Add("metal pipe");
//test.Add("plastic toy");
//test.Add("metal bar");
//test.Add("copper wire");
//test.Add("plastic button");
//test.Add("brass");

//var output = test.SortRecyclables();
//foreach (var item in output)
//{
//    Console.WriteLine("{0} - {1}", item.Key, string.Join(",", item));
//}

// OUTPUT:
//metal - metal pipe,metal bar
//plastic - plastic toy, plastic button
//copper - copper wire

public class RecyclingBin
{
    protected List<string> recyclables = new List<string>();

    public void Add(string recyclable)
    {
        if (recyclable.Split(' ').Length > 1)
        {
            recyclables.Add(recyclable);
        }
    }

    public List<IGrouping<string, string>> SortRecyclables()
    {
        return recyclables.GroupBy(recyclable => recyclable.Split(' ').First()).ToList();
    }
}