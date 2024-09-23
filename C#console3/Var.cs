class Var
{
    public static void MyVar()
    {
       string helloWorld = "Hello world";
       
       Console.WriteLine(helloWorld);
    }
    public static void DataTypes()
    {
        string firstName = "anthony";
        string lastName = "King"; 
        string Myname = firstName + lastName;
        int age = 15;
        float gpa = 4.0f;
        bool is_Student = true;

        double length = 2.6;
        decimal dollar = 100.98m;

        Console.WriteLine(Myname);
        Console.WriteLine(age);
        Console.WriteLine(gpa);
        Console.WriteLine(is_Student);
        Console.WriteLine(length);
        Console.WriteLine(dollar);
    }
}