


 class First 

{

    public int Greaternum(int x, int y)
    {
        int result;

        if (x > y)

        {
            result = x;
            return result;
        }

        else

        {
            result = y;
            return result;
        }
        
    }

    public static void Main()

    {

        int final;

        First myobj = new First();

        final = myobj.Greaternum(10, 100);

        System.Console.WriteLine(final);

      //  System.Console.WriteLine(myobj.Greaternum(5, 9));

    }


}