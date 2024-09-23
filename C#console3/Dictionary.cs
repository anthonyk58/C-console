using System.Xml;

class Dictionary 
{
    public static void Dict1(string[] args)
    {
        Dictionary<string, string> PhoneBook = new Dictionary<string, string>();

        PhoneBook.Add("Alice" , "123-456-7890");
        PhoneBook.Add("Bob" , "987-654-3210");
        Console.WriteLine(PhoneBook["Bob"]);
    }

    public static void Dict2(string[] args)
    {
        Dictionary<string, int> inventory = new Dictionary<string, int>();
        inventory.Add("apples", 50);
        inventory.Add("oranges", 30);
        inventory.Add("bananas", 40);
        inventory.Add("mangos", 10);

        foreach (KeyValuePair<string, int> item in inventory)
        {
            Console.WriteLine(item.Key + ":" + item.Value);
        }
    }
}