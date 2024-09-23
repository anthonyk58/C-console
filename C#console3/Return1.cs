class Return1
{
     public static  void PrintSquare(int number)
    {
        Console.WriteLine(number * number);
    }
    public static  void checkEvenOdd (int number)
    {
        if(number % 2 == 0)
        {
            Console.WriteLine(number + "is even");
        }
    }
     public static int AddNumber(int num1, int num2)
    {
        return num1 + num2;
    }
}