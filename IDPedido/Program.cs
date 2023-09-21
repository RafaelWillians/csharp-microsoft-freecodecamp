string[] fraudulentID = {"B123", "C234", "A345", "C15","B177","G3003","C235","B179"};

foreach (string items in fraudulentID)
{
    if(items.StartsWith("B"))
    {
        // Console.WriteLine("The name starts with 'B'!");
        Console.WriteLine(items);
    }
    
}