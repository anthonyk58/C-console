class Loops 
{
    public static void Forloop()
    {
        for( int i = 0; i <= 20; i++ )
        {
            Console.WriteLine("Interation:" + i);
        }
    }
    public static void Evenloop()
    {
        for( int i = 0; i <= 20; i++ )
        {
           if(i  % 2 == 0)
           {
             Console.WriteLine("Interation:" + i);
           }
           
        }
    }
     public static void whileloop()
     {
        int health = 100;
        while(health > 0)
        {
            Console.WriteLine("player is alive wit health:" + health);
            health = health -10;

        }
     }
     public static void Increseloop()
     {
        int gold = 0;
        while(gold < 100)
        {
            Console.WriteLine("player is getting rich + 5 <3 " + gold );
            gold += 5;

        }

    } 

    public static void NestedLoops()
    {
        for( int i = 0; i <= 3; i++ )
        {
           if(i  % 2 == 0)
           {
             Console.WriteLine("Interation i:" + i);
             for(int j = 0; j <= 3; j ++)
             {
                Console.WriteLine("  Interation j:  " + i);
             }
             for(int k = 0; k <= 3; k ++)
             {
                Console.WriteLine("  Interation k : " + k);
             }
           }
           
        }
    } 
}