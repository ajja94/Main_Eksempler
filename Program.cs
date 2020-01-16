//Eksempel 1: 
//           Console.Write("enter your name: ");
//            string name = Console.ReadLine();
//Console.Write("enter your age: ");
//            string age = Console.ReadLine();
//Console.WriteLine("hello " + name + " you are " + age + " years old ");

////------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//Eksempel 2 kalkulator: 
//            Console.Write("Enter a number: ");
//            int num1 = Convert.ToInt32(Console.ReadLine());
//Console.Write("Enter another number: ");
//            int num2 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine(num1* num2);

//            Console.ReadLine();
////------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
////Eksempel 3 kalkulator med desimal: 

//            Console.Write("Enter a number: ");
//            double num1 = Convert.ToDouble(Console.ReadLine());
//Console.Write("Enter another number: ");
//            double num2 = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine(num1* num2);

//            Console.ReadLine();
////------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
////Eksempel 4 Array:

//            int[] luckyNumbers = { 4, 8, 15, 23, 42, 55 };

//Console.WriteLine(luckyNumbers[3]);

//             Console.ReadLine();
////------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
////Eksempel 5 Array med Navn:

//            string[] friends = new string[10];
//friends[0] = "Jim";
//            friends[1] = "Kelly";
//            friends[2] = "Anja";
//            friends[3] = "Bob-kåre";


//            Console.WriteLine(friends[3]);

//             Console.ReadLine();
////------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
////Eksempel 6 med methods:

//        static void Main(string[] args)
//{
//    SayHi();
//    Console.ReadLine();
//}

//static void SayHi()
//{
//    Console.WriteLine("Hello User");
//}
////------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
////Ekspempel 7 methods2/functions:

//static void Main(string[] args)
//{
//    SayHi();
//    Console.ReadLine();
//    SayBy();
//    Console.ReadLine();
//}

//static void SayHi()
//{
//    parameter
//            Console.WriteLine("Hello");
//}

//static void SayBy()
//{
//    Console.WriteLine("Hade bra");
//}
////------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
////Eksempel 8 Return statement: 

//static void Main(string[] args)
//{
//    Console.WriteLine(cube(5));
//    Console.ReadLine();
//}

//static int cube(int num)
//{
//    int result = num * num * num;
//    return result;
//}
////-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
////Eksempel 9 På hvordan en If statments fungerer: 

//I wake up
// IF i'm hungry (condison true/false)
//   i eat brekfast(if true)
////------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
////Eksempel 10 IF statments : 
//        static void Main(string[] args)
//{
//    bool Ishyungry = true;

//    if (Ishyungry)
//    {
//        Console.WriteLine("Eat somting");

//    }
//    Console.ReadLine();
//}
////------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
////Eksempel 11 If statement: 
//static void Main(string[] args)
//{
//    bool Ishyungry = false;

//    if (Ishyungry)
//    {
//        Console.WriteLine("Eat somting");

//    }
//    else
//    {
//        Console.WriteLine("you are nor hungery, go on whit youre day");
//    }
//    Console.ReadLine();
//    //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//    //Eksempel 12 If staitments :

//    static void Main(string[] args)
//    {
//        bool IsMale = true;
//        bool IsTall = false; kan være True da kjøer linje 1

//                   || sjekker begge
//            if (IsMale && IsTall)
//        {
//            Console.WriteLine("you are a tall male");

//        }
//        else
//        {
//            Console.WriteLine("you are either not male or not tall or both");
//        }
//        Console.ReadLine();
//    }
//    //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//    //Eksempel 13 IF og Else statements :

//    static void Main(string[] args)
//    {
//        bool IsMale = false;
//        bool IsTall = true;

//        if (IsMale && IsTall)
//        {
//            Console.WriteLine("you are a tall male");

//        }
//        else if (IsMale && !IsTall)
//        {
//            Console.WriteLine("you are a short male");
//        }
//        else if (!IsMale && IsTall)
//        {
//            Console.WriteLine("you are not a male but you are tall");
//        }
//        else
//        {
//            Console.WriteLine("you are not male and not tall");
//        }
//        Console.ReadLine();
//    }
//    //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//    //Eksempel 14 if statments med comparison :

//    static void Main(string[] args)
//    {
//        Console.WriteLine(GetMax(20, 10));

//        Console.ReadLine();
//    }

//    static int GetMax(int num1, int num2)
//    {
//        int result;
//        if (num1 > num2)
//        {
//            result = num1;
//        }
//        else
//        {
//            result = num2;
//        }
//        return result;
//    }
//    //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//    //Eksempel 15 if statments med comparison til 3 tall: 

//    static void Main(string[] args)
//    {
//        Console.WriteLine(GetMax(20, 10, 70));

//        Console.ReadLine();
//    }

//    static int GetMax(int num1, int num2, int num3)
//    {
//        int result;
//        if (num1 >= num2 && num1 >= num3)
//        {
//            result = num1;
//        }
//        else if (num2 >= num1 && num2 >= num3)
//        {
//            result = num2;
//        }
//        else
//        {
//            result = num3;
//        }
//        return result;
//    }
//}
////------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
////Eksempel 16 Kalkulator med input valg:

//static void Main(string[] args)
//{
//    Console.Write("Enter a number : ");
//    double num1 = Convert.ToDouble(Console.ReadLine());

//    Console.Write("Enter Operator : ");
//    string op = Console.ReadLine();

//    Console.Write("Enter another number : ");
//    double num2 = Convert.ToDouble(Console.ReadLine());

//    if (op == "+")
//    {
//        Console.WriteLine(num1 + num2);
//    }
//    else if (op == "-")
//    {
//        Console.WriteLine(num1 - num2);
//    }
//    else if (op == "/")
//    {
//        Console.WriteLine(num1 / num2);
//    }
//    else if (op == "*")
//    {
//        Console.WriteLine(num1 * num2);
//    }
//    else
//    {
//        Console.WriteLine("Invalid Operator");
//    }
//    Console.ReadLine();
//}
////------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
////Eksempel 17 switch statments:

//static void Main(string[] args)
//{
//    Console.WriteLine(GetDay(5));
//    Console.ReadLine();
//}

//static string GetDay(int dayNum)
//{
//    string dayName;

//    switch (dayNum)
//    {
//        case 0:
//            dayName = "Monday";
//            break;
//        case 1:
//            dayName = "Tuesday";
//            break;
//        case 2:
//            dayName = "Wendsday";
//            break;
//        case 3:
//            dayName = "Thursday";
//            break;
//        case 4:
//            dayName = "Friday";
//            break;
//        case 5:
//            dayName = "Saturday";
//            break;
//        case 6:
//            dayName = "sunday";
//            break;
//        default:
//            dayName = "invalid day number";
//            break;
//    }

//    return dayName;
//}
////-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
////Eksempel 18 while loops: 

//static void Main(string[] args)
//{
//    int index = 1;
//    while (index <= 50)
//    {
//        Console.Write(index);
//        index++;
//    }
//    Console.ReadLine();
//}
////------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
////Eksempel 19 do while loop :

//static void Main(string[] args)
//{
//    int index = 6;
//    do
//    {
//        Console.Write(index);
//        index++;
//    } while (index <= 5);

//    Console.ReadLine();
//}
////------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
////Eksempel 20 guessing game with while loop. kan skrives om til do while loop: 

//static void Main(string[] args)
//{
//    string SecretWord = "hei";
//    string guess = " ";
//    int guessCount = 0;
//    int guessLimit = 10;
//    bool outOfGuesses = false;

//    while (guess != SecretWord && !outOfGuesses)
//    {
//        if (guessCount < guessLimit)
//        {
//            Console.Write("Enter guess: ");
//            guess = Console.ReadLine();
//            guessCount++;

//        }
//        else
//        {
//            outOfGuesses = true;
//        }
//    }
//    if (outOfGuesses)
//    {
//        Console.WriteLine("you loose");
//    }
//    else
//    {
//        Console.Write("you win");
//    }


//    Console.ReadLine();
//}
////------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
////Eksempel 21 For loops: 

//static void Main(string[] args)
//{
//    int[] Numbers = { 4, 8, 16, 32, 64, 128 };

//    for (int i = 0; i < Numbers.Length; i++)
//    {
//        Console.WriteLine(Numbers[i]);
//    }

//    Console.ReadLine();
//}
//    }
////------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
////Eksempel 22 Building an Exponent Method: 

//        static void Main(string[] args)
//{
//    Console.WriteLine(GetPow(4, 3));
//    Console.ReadLine();
//}

//static int GetPow(int baseNum, int powNum)
//{
//    int result = 1;

//    for (int i = 0; i < powNum; i++)
//    {
//        result = result * baseNum;
//    }
//    return result;
//}
////------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
////Eksempel 23 arrays forskjell på [] og {} :

//static void Main(string[] args)
//{

//    //int[,] luckyNumbers = { { 1, 2 }, { 3, 8 } };
//    int[] luckyNumbers = { 10 };
//    int[] luckyNumbers2 = new int[10];
//    Console.WriteLine(luckyNumbers.Length);
//    Console.WriteLine(luckyNumbers[0]);

//    Console.WriteLine(luckyNumbers2.Length);
//    Console.WriteLine(luckyNumbers2[0]);
//    //Console.WriteLine(luckyNumbers[1][1]);
//}
////------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
////Eksempel 24 2d arrays: 

////man kan og putte inn fler , i [] og lage flere dimensjoner.

//static void Main(string[] args)
//{
//    int[,] numberGrid = {
//                { 1, 2 },
//                { 3, 8 },
//                {10, 14 },
//                {16, 19 }
//            };

//    Console.WriteLine(numberGrid[1, 1]);

//    Console.ReadLine();
//}
////-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
////Eksempel 25 Excheption handeling :

//static void Main(string[] args)
//{
//    try
//    {
//        Console.Write("Enter a number: ");
//        double num1 = Convert.ToDouble(Console.ReadLine());
//        Console.Write("Enter another number: ");
//        double num2 = Convert.ToDouble(Console.ReadLine());

//        Console.WriteLine(num1 / num2);
//    }
//    catch (Exception e)
//    {
//        Console.WriteLine(e.Message);
//    }
//    Console.ReadLine();
//}
////------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
////Eksempel 26 Excheption handeling:
//static void Main(string[] args)
//{
//    try
//    {
//        Console.Write("Enter a number: ");
//        int num1 = Convert.ToInt32(Console.ReadLine());
//        Console.Write("Enter another number: ");
//        int num2 = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine(num1 / num2);
//    }
//    catch (DivideByZeroException e)
//    {
//        Console.WriteLine(e.Message);
//    }
//    catch (FormatException e)
//    {
//        Console.WriteLine(e.Message);
//    }
//    finally //blir alltid skrevet ut
//    {
//        Console.WriteLine("You rock! :P ");
//    }
//    Console.ReadLine();
//}
////------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
////Eksempel 27 Classes and Objects:
///*laget egen class file til class book      

//class Book
//  {
//      public string title;
//      public string author;
//      public int pages;

//  }
//*/
//static void Main(string[] args)
//{
//    Book book1 = new Book();
//    book1.title = "Harry-potter";
//    book1.author = "Anja";
//    book1.pages = 400;

//    Book book2 = new Book();
//    book1.title = "Lord of the rings";
//    book1.author = "Martin l.King";
//    book1.pages = 1400;

//    Console.WriteLine(book1.title);


//    Console.ReadLine();
//}
////------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
////Eksempel 28 Constructors :
////-----class file-------------------------------------------------
//class Book
//{
//    public string title;
//    public string author;
//    public int pages;
//    //Constructors
//    public Book(string aTitle, string aAuthor, int aPages)
//    {
//        title = aTitle;
//        author = aAuthor;
//        pages = aPages;

//    }
//}
////---------------------------------------------------------------------------------------
//static void Main(string[] args)
//{
//    Book book1 = new Book("Harry-potter", "JK.Rowling", 400);
//    Book book2 = new Book("Lord of the rings", "Tolken", 700);

//    Console.WriteLine(book2.title);


//    Console.ReadLine();
//}
////------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
////Eksempel 29 Class med Objects methodes:
////-----------Class-------------------------------------
//class student
//{
//    public string studentName;
//    public string major;
//    public double gpa;

//    public student(string aStudentName, string aMajor, double aGpa)
//    {
//        studentName = aStudentName;
//        major = aMajor;
//        gpa = aGpa;

//    }

//    public bool HasHonors()
//    {
//        if (gpa >= 3.5)
//        {
//            return true;
//        }
//        return false;
//    }
//}
////----------------------------program--------------------------------------------------------
//static void Main(string[] args)
//{
//    student student1 = new student("jim", "art", 3.6);
//    student student2 = new student("kate", "business", 2.8);
//    student student3 = new student("William", "computer sience", 3.9);

//    Console.WriteLine(student1.HasHonors());
//    Console.WriteLine(student2.HasHonors());
//    Console.WriteLine(student3.HasHonors());


//    Console.ReadLine();
//}
////------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
////Eksempel 30 Getters and Setters :
//class Movie
//{
//    public string title;
//    public string director;
//    private string rating;

//    public Movie(string aTitle, string aDirector, string aRating)
//    {
//        title = aTitle;
//        director = aDirector;
//        Rating = aRating;

//    }

//    public string Rating
//    {
//        get { return rating; }
//        set
//        {
//            if (value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
//            {
//                rating = value;
//            }
//            else
//            {
//                rating = "NR";
//            }
//        }
//    }
//}
////--------------------------Program----------
//class program
//{
//    public static void Main(string[] args)
//    {
//        Movie avengers = new Movie("Avengers", "Joss", "PG-13");
//        Movie shrek = new Movie("shrek", "adam", "PG");

//        Console.WriteLine(avengers.Rating);

//        Console.ReadLine();
//    }
//}

////------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
////Eksempel 31 Static Class Attribuets:

//class Song
//{
//    public string title;
//    public string artist;
//    public int duration;
//    public static int songCount = 0;

//    public Song(string aTitle, string aArtist, int aDuration)
//    {
//        title = aTitle;
//        artist = aArtist;
//        duration = aDuration;
//        songCount++;

//    }

//    public int GetSongCount()
//    {
//        return songCount;
//    }
//}
////-------------------Program------------------------
//class program
//{
//    public static void Main(string[] args)
//    {
//        Song holiday = new Song("Holiday", "Green Day", 200);
//        Console.WriteLine(holiday.GetSongCount());
//        Song kashmir = new Song("Kashmir", "Led Zepplin", 150);
//        Console.WriteLine(kashmir.GetSongCount());


//        Console.ReadLine();
//    }
//}

////------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
////Eksempel 32 Static Methods & Classes:

//static class UseFulTools
//{
//    public static void SayHi(string name)
//    {
//        Console.WriteLine("Hello" + name);
//    }


//}

////---------Program-------------------------------

//class program
//{
//    public static void Main(string[] args)
//    {
//        UseFulTools.SayHi(" Torjus");


//        Console.ReadLine();
//    }
//}
////------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
////Eksempel 33 Inheritance/Arv:

////man har Super Class og sub Classes
////Chef er super Class
////ItalianChef er sub Class

////----Super Class-----------------------------------------

//class Chef
//{
//    public void MakeChicken()
//    {
//        Console.WriteLine("The chef makes chicken");
//    }
//    public void MakeSalad()
//    {
//        Console.WriteLine("The chef makes salad");
//    }
//    public virtual void MakeSpecialDish()
//    {
//        Console.WriteLine("The chef makes bbq ribs");
//    }


//}

////------Sub Class----------------------------------------------

//class ItalianChef : Chef
//{
//    public override void MakeSpecialDish()
//    {
//        Console.WriteLine("The chef makes risotto");
//    }
//    public void MakePasta()
//    {
//        Console.WriteLine("The italian chef makes pasta");
//    }
//}

////--------------------Program---------------------------------------

//class program
//{
//    static void Main(string[] args)
//    {
//        Chef chef = new Chef();
//        chef.MakeSpecialDish();

//        ItalianChef italianchef = new ItalianChef();
//        italianchef.MakeSpecialDish();


//        Console.ReadLine();
//    }
//}

////------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
////Eksempel 34:

////------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
////Eksempel 35:

////------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
////Eksempel 36:

////------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
////Eksempel 37:

////------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
////Eksempel 38:

////------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


