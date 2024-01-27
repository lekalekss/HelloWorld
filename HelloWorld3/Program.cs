
internal class Program
{
    private static void Main(string[] args)
    {
        int intMin = 15;
        int intMax = 45637;

        long longMin = 5463746645763;
        long longMax = 9999998388378989;

        bool isPositive = false;
        bool isNegative = true;

        char charFirst = 'a';
        char charLast = 'q';

        string string1 = "Everything is working great";
        string string2 = "Something weard";

            string goodRes = intMin +" + "+ longMax + " < " + "0" + " is " + isPositive;

        Console.WriteLine(goodRes);



        string Sol = "When the programm is created correctly " + ", then" + string1;
        //новый комментарий
        //new one
        Console.WriteLine(Sol);

    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}