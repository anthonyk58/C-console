class List
{
    public static void List1(string[] args)
    {
       
        
         List<string> fruit = new List<string> {"Apple" , "banana" , "plum"};    

        fruit.Add("grapes");
        fruit.Remove("banana");
        fruit.IndexOf("grapes");

        Console.WriteLine(fruit.Count);

    foreach(string fruits in fruit)
        {
              Console.WriteLine(fruit.Count);        
        }

    }
}