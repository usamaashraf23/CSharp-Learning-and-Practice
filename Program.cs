// See https://aka.ms/new-console-template for more information



                //Variables and Data Types


//string name = "Usama";
//int age = 22;
//double height = 163.5;
//Console.WriteLine(name + " is " + age + " years old and is " + height + " cm tall");

//int a = 8;
//int b = 9;
//Console.WriteLine("Before Swapping value of \nA=" + a + "\nB=" + b);

//a = a + b;
//b = a - b;
//a = a - b;

//Console.WriteLine("After Swapping value of \nA=" + a + "\nB=" + b);

//Reverse a String

//string firstName = "usama";
//string lastName = "ashraf";
//Console.WriteLine(firstName + " " + lastName);

//string str = "Hello";
//Console.WriteLine("first letter is " + str[0] + "\nlast letter is "+str[str.Length - 1]);

//string text = "cSharp";
//string textUpper = text.ToUpper();
//string textLower = text.ToLower();

//Console.WriteLine(textUpper + "\n" + textLower);

//string sentence = "I love CSharp";
//Console.WriteLine(sentence.Length);

//string phrase = "I love Java";
//Console.WriteLine(phrase.Replace("Java", "C#"));

//string messy = "   Hello World  ";
//Console.WriteLine(messy.TrimStart().TrimEnd()) ;

//string sentence = "Learning C# is Fun";
//Console.WriteLine(sentence.Substring(sentence.IndexOf("C#"),2));

//Console.Write("Enter Your Name: ");
//string name = Console.ReadLine();
//Console.Write("Enter Your Age: ");
//int age =Convert.ToInt32( Console.ReadLine());
//Console.WriteLine($"Hello {name} you are {age} years old");


                //Methods

//static void SayHi(string name)
//{
//    Console.WriteLine("Hello " + name);
//}

//SayHi("Usama");

//static double Add(double num1,double num2)
//{
//    return num1 + num2;
//}
//Console.Write("Enter First Number:");
//double num1 = Convert.ToInt16(Console.ReadLine());
//Console.Write("Enter Second Number:");
//double num2 = Convert.ToInt16(Console.ReadLine());

//Console.WriteLine(Add(num1, num2));

                
            //Conditions

//static bool IsEven(int num)
//{
//    if (num % 2 == 0)
//    {
//        return true;
//    }
//    else
//    {
//        return false;
//    }
//}

//Console.Write("Enter Number:");
//int num = Convert.ToInt16(Console.ReadLine());
//Console.WriteLine(IsEven(num));

//static int Factorial(int num)
//{
//    int fact = 1;
//    for(int i = 1; i <= num; i++)
//    {
//        fact *= i;
//    }
//    return fact;
//}

//Console.Write("Enter Number:");
//int num = Convert.ToInt16(Console.ReadLine());
//Console.WriteLine("Factorial of Number is " + Factorial(num));

//static double Multiply(double num1,double num2)
//{
//    return num1 * num2;
//}
//static double Multiply(double num1, double num2,double num3)
//{
//    return num1 * num2*num3;
//}
//Console.Write("Enter first Number");
//double num1 = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Enter Second Number");
//double num2 = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Enter Second Number");
//double num3 = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine(Multiply(num1, num2));
//Console.WriteLine(Multiply(num1, num2, num3));

//static double Add(double num1,double num2)
//{
//    return num1 + num2;
//}
//static double Multiply(double num1,double num2)
//{
//    return num1 * num2;
//}
//static double Subtract(double num1,double num2)
//{
//    return num1 - num2;
//}
//static double Division(double num1,double num2)
//{
//    return num1 / num2;
//}

//Console.Write("Enter a First Number:");
//double num1 = Convert.ToDouble(Console.ReadLine());
//Console.Write("Enter a Second Number");
//double num2 = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Select the Operator");
//Console.WriteLine("1.+ \n2.x \n3.- \n4./");
//int oper = Convert.ToInt16(Console.ReadLine());

//if (oper == 1)
//{
//    Console.WriteLine(Add(num1, num2));
//}
//else if (oper == 2)
//{
//    Console.WriteLine(Multiply(num1, num2));
//}
//else if (oper == 3)
//{

//    Console.WriteLine(Subtract(num1, num2));
//}
//else if (oper == 4)
//{
//    Console.WriteLine(Division(num1, num2));
//}
//else
//{
//    Console.WriteLine("Invalid Operator");
//}

//static double FindMax(double num1,double num2)
//{
//    double max = 0;
//    if (num1 > num2)
//    {
//        max = num1;
//    }
//    else
//    {
//        max = num2;
//    }
//    return max;
//}

//Console.WriteLine(FindMax(22, 21));

//static int Square(int num)
//{
//    return num * num;
//}
//Console.WriteLine(Square(3));

//static double CelciusToFarenheit(double celcius)
//{
//    double farenheit = (celcius * (9 / 5)) + 32;
//    return farenheit;
//}
//Console.WriteLine(CelciusToFarenheit(0));

//static void CheckNum(double num)
//{
//    if (num > 0)
//    {
//        Console.WriteLine("Number is Positive");
//    }
//    else if (num < 0)
//    {
//        Console.WriteLine("Number is Negative");
//    }
//    else
//    {
//        Console.WriteLine("Number is Zero");
//    }
//}
//CheckNum(0);

//static double SumArray(double[] arr)
//{
//    double sum = 0;
//    for(int i = 0; i < arr.Length; i++)
//    {
//        sum += arr[i];
//    }
//    return sum;
//}
//double[] arr = { 2, 3, 4, 5, 6 };
//Console.WriteLine(SumArray(arr));

//static string ReverseString(string str)
//{
//    string newStr = "";
//    for(int i = str.Length - 1; i >= 0; i--)
//    {
//        newStr += str[i];
//    }
//    return newStr;
//}
//string str = "Usama";
//Console.WriteLine(ReverseString(str));

//static bool IsPrime(int num)
//{
//    int i = 2;
//    while (i < num)
//    {
//        if (num % i == 0)
//        {
//            return false;
//        }
//        i++;
//    }
//    return true;
//}
//Console.WriteLine(IsPrime(11));

//Console.Write("Enter a Day:");
//int day = Convert.ToUInt16(Console.ReadLine());

//switch (day)
//{
//    case 1:
//        Console.WriteLine("Today is Monday");
//        break;
//    case 2:
//        Console.WriteLine("Today is Tuesday");
//        break;
//    case 3:
//        Console.WriteLine("Today is Wednesday");
//        break;
//    case 4:
//        Console.WriteLine("Today is Thursday");
//        break;
//    case 5:
//        Console.WriteLine("Today is Friday");
//        break;
//    case 6:
//        Console.WriteLine("Today is Saturday");
//        break;
//    case 7:
//        Console.WriteLine("Today is Sunday");
//        break;
//    default:
//        Console.WriteLine("Invalid Input");
//        break;
//}

//int[,] age = { { 1, 2 },
//    { 3,4} };

//for(int i = 0; i < age.Length; i++)
//{
//    for(int j = 0; j < age.Length-1; j++)
//    {
//        Console.WriteLine(age[i,j]);
//    }

//}


                //Exception Handling
//try
//{
//    Console.Write("Enter a number:");
//    double num1 = Convert.ToDouble(Console.ReadLine());
//    Console.Write("Enter a another number:");
//    double num2 = Convert.ToDouble(Console.ReadLine());
//    Console.WriteLine(num1 / num2);
//}
//catch(DivideByZeroException e)
//{
//    Console.WriteLine(e.Message);
//}

//try
//{
//    Console.Write("Enter your Age");
//    int age = Convert.ToInt32(Console.ReadLine());

//}
//catch (ArgumentException e)
//{

//}

                //Class and Object

using usama;

//Book book = new Book("Usama","Ashraf",201);
//Console.WriteLine(book.title);

//Car c = new Car("Corolla",230,2024);
//c.Details();
//c.StartEngine();
//Console.WriteLine("Enter pin:");
//long pin = Convert.ToInt16(Console.ReadLine());
//Console.WriteLine("Enter Amount:");
//int amount = Convert.ToInt16(Console.ReadLine());

//BankAccount b = new BankAccount(pin,2000);

//b.Withdraw(amount);
//Console.WriteLine($"Your New Balance is {b.GetBalance()}");


Student[] s = new Student[5];

 s[0] = new Student("Usama", 92, 2.72);
 s[1] = new Student("Usman", 91, 3.72);
 s[2] = new Student("Ali", 52, 2.82);
 s[3] = new Student("kamran", 32, 2.22);
 s[4] = new Student("Usama", 12, 2.52);

for(int i = 0; i < s.Length; i++)
{
    s[i].DisplayDetails();
}
