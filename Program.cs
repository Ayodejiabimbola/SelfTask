// SECTION 1 (Console.WriteLine and comments)
// The code line below prints my full name 
Console.WriteLine("My name is Khalilur-Rahman Ayodeji Abimbola");

// This line below prints my favorite quote
Console.WriteLine("Stay determined, neither impatient nor discouraged,and with repeated trial and error, \n you're bound to reach the splendid outcome you desire.");

// The line below prints taday's date
Console.WriteLine("Today's date is 3rd of January 2026");

/*The whole of this is to print 
My full name
My favorite quote
and taday's date*/

// SECTION 2(Variables and Data Types)
string studentName = "Khalilur-Rahman Abimbola";
int studentAge = 19;
int studentWeight = 165;
studentAge = 20;
bool isEnrolled = true;
Console.WriteLine(studentName +" aged "+ studentAge +" weighs " +studentWeight +"kg is enrolled: "+ isEnrolled );

// SECTION 3(CONSTANTS)
const decimal pi = 3.142M;
const int daysInAWeek = 7;
Console.WriteLine("We have "+daysInAWeek+ " days in a week and the fixed value of pi in maths is " +pi);

// SECTION 4 (USER Input)
Console.Write("Enter Your Name: ");
string name = Console.ReadLine();
Console.Write("Enter Your Birth Year: ");
int birthYear = int.Parse(Console.ReadLine());
int age = 2026 - birthYear;

Console.Write("Input a number: ");
int firstNum = Convert.ToInt32(Console.ReadLine());

Console.Write("Input another number: ");
int secondNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"The user, {name} is currently {age} years of age ");
Console.WriteLine($"The sum of the numbers are {firstNum + secondNum}\nTheir difference is {firstNum - secondNum}");

