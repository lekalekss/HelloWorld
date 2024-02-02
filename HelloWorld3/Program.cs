
internal class Program
{
    private static void Main(string[] args)
    {
        //        //int intMin = 15;
        //        //int intMax = 45637;

        //        //long longMin = 5463746645763;
        //        //long longMax = 9999998388378989;

        //        //bool isPositive = false;
        //        //bool isNegative = true;

        //        //char charFirst = 'a';
        //        //char charLast = 'q';

        //        //string string1 = "Everything is working great";
        //        //string string2 = "Something weard";

        //        //    string goodRes = intMin +" + "+ longMax + " < " + "0" + " is " + isPositive;

        //        //Console.WriteLine();


        //        //string Sol = "When the programm is created correctly " + ", then" + string1;
        //        ////новый комментарий
        //        ////new one
        //        //Console.WriteLine();

        //        //int first = 25;
        //        //int last = 256783;
        //        //    int plus = first + last;
        //        //int minus = first - last;
        //        //int multipl = first * last;
        //        //int division = last / first;

        //        //Console.WriteLine("Division result = " + division);
        //        //Console.WriteLine("Multiplication result = " + multipl);
        //        //Console.WriteLine("Addition result = " + plus);

        //        //division++;
        //        //division++;
        //        //division++;
        //        //division++;
        //        //division++;
        //        //division++;
        //        //Console.WriteLine("New division result = " + division);

        //        //multipl--;
        //        //multipl--;
        //        //multipl--;
        //        //multipl--;
        //        //multipl--;
        //        //multipl--;
        //        //Console.WriteLine("New multiplication result = " + multipl);

        //        //string Name = "Ivan";
        //        //string Lastname = "Bolvan";
        //        //int age = 67;
        //        //Console.WriteLine(Name + " " + Lastname + " is " + age + " years old");

        //        //bool Employeed = true;
        //        //bool Manager = !Employeed;

        //        //bool happy = Employeed && Manager;
        //        //bool ok = Employeed || Manager;
        //        //Console.WriteLine(happy);
        //        //Console.WriteLine(ok);

        //        ////bool res = 75 == 75;
        //        ////bool res2 = 75 <= 75;
        //        ////bool res3 = 75 != 64;
        //        ////bool res4 = 45 > 76;
        //        //bool res5 = 87 >= 23;
        //        //Console.WriteLine(res);
        //        //Console.WriteLine(res2);
        //        //Console.WriteLine(res3);
        //        //Console.WriteLine(res4);
        //        //Console.WriteLine(res5);

        //        Console.WriteLine("Please enter your name");
        //        string Name = Console.ReadLine();

        //        Console.WriteLine("Please enter your Lastname");
        //        string Lastname = Console.ReadLine();

        //        Console.WriteLine("Please enter your age");
        //        string age = Console.ReadLine();
        //        int convertAge = int.Parse(age);

        //        Console.WriteLine("Please enter your occupation");
        //        string profession = Console.ReadLine();

        //        Console.WriteLine("Hello " + Name + " " + Lastname + "," + "I couldn't imagine you are " + convertAge + " years old.");
        //        Console.WriteLine(profession + " - is a very interesting and important occupation!");

        int a = 50;

        if (a <= 50 && a==50)
            Console.WriteLine("the number a  is equal");
        if (a != 50)
            Console.WriteLine("the number a  is more or less");
        if (a > 50 || a < 50)
            Console.WriteLine("the number a isn't equal");

        int b = 50;

        if (b == 5)
            Console.WriteLine("number is equal");
        if (b < 10)
            Console.WriteLine("number is less");
        if (b <= 25)
            Console.WriteLine("number less or equal 25");
        if (b == 50)
            Console.WriteLine("number b is equal");
        if (b > 50)
            Console.WriteLine("number is more");
        if (b != 100)
            Console.WriteLine("number isn't equal 100");
        else Console.WriteLine("another number volue");


        int c = 50;

        if (c == 5)
            Console.WriteLine("number c is equal");
        else if (c < 10)
            Console.WriteLine("number c is less");
        else if (c <= 25)
            Console.WriteLine("number c is less or equal 25");
        else if (c == 50)
            Console.WriteLine("number c is equal");
        else if (c > 50)
            Console.WriteLine("number c is more");
        else if (c != 100)
            Console.WriteLine("number c isn't equal 100");
        else Console.WriteLine("another number volue");

        int d = 45;
        if (d <= 34)
            Console.WriteLine("true");
        else
            Console.WriteLine("false");

        int g = 50;
        switch (g) 
        { 
            case 5: 
                Console.WriteLine("first");
                break;
            case 40: Console.WriteLine("second");
                break;
            case 67: Console.WriteLine("third");
                break;
                default: Console.WriteLine("another number volume");
                break;

                

        }




         






    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}