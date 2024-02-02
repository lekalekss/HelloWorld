
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

        Console.WriteLine();

        
        string Sol = "When the programm is created correctly " + ", then" + string1;
        //новый комментарий
        //new one
        Console.WriteLine();

        int first = 25;
        int last = 256783;
            int plus = first + last;
        int minus = first - last;
        int multipl = first * last;
        int division = last / first;

        Console.WriteLine("Division result = " + division);
        Console.WriteLine("Multiplication result = " + multipl);
        Console.WriteLine("Addition result = " + plus);

        division++;
        division++;
        division++;
        division++;
        division++;
        division++;
        Console.WriteLine("New division result = " + division);

        multipl--;
        multipl--;
        multipl--;
        multipl--;
        multipl--;
        multipl--;
        Console.WriteLine("New multiplication result = " + multipl);

        string Name = "Ivan";
        string Lastname = "Bolvan";
        int age = 67;
        Console.WriteLine(Name + " " + Lastname + " is " + age + " years old");

        bool Employeed = true;
        bool Manager = !Employeed;

        bool happy = Employeed && Manager;
        bool ok = Employeed || Manager;
        Console.WriteLine(happy);
        Console.WriteLine(ok);

        bool res = 75 == 75;
        bool res2 = 75 <= 75;
        bool res3 = 75 != 64;
        bool res4 = 45 > 76;
        bool res5 = 87 >= 23;
        Console.WriteLine(res);
        Console.WriteLine(res2);
        Console.WriteLine(res3);
        Console.WriteLine(res4);
        Console.WriteLine(res5);












    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}