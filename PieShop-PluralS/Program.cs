using PieShop_PluralS.HR;
using PieShop_PluralS.Accounting;
using System.Text;

//Value Types
/*int a = 42;
int aCopy = a;
Console.WriteLine($"Value of a : {a} and value of copy of a :{aCopy}");
aCopy = 100;
*/

//Reference Types
Console.WriteLine("Creating an employee");
Console.WriteLine("-----------------------");

//initially throws error because we need employee type. The constructor has changed
Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25, EmployeeType.Manager);//added type Manager

Employee testEmployee = bethany;
testEmployee.firstName = "Ashley";
testEmployee.DisplayEmployeeDetails();
bethany.DisplayEmployeeDetails();

//using structs
WorkTask task;
task.description = "Bake delicious Pies";
task.hours = 3;
task.PerformWorkTask();



Customer customer = new Customer();



//need to install Newton.jsoft
//string bethanyAsJson = bethany.ConvertToJson();
//Console.WriteLine(bethanyAsJson);

//bethany.PerformWork(25);


/*
* using reference to invoke change on the ORIGINAL value of the variable 
int minimumBonus = 100;
int bonusTax = 0;
int receivedBonus = bethany.CalculateBonusAndBonusTax(minimumBonus , ref bonusTax);
Console.WriteLine($"The minimum bonus is {minimumBonus}, the bonus tax is {bonusTax} and {bethany.firstName} has received a bonus of {receivedBonus}");
*/

/*using out keyword
int minimumBonus = 100;
int bonusTax = 0;
int receivedBonus = bethany.CalculateBonusAndBonusTax(minimumBonus, out bonusTax);
Console.WriteLine($"The minimum bonus is {minimumBonus}, the bonus tax is {bonusTax} and {bethany.firstName} has received a bonus of {receivedBonus}");
*/
/*
 Console.WriteLine("Creating an employee");
Console.WriteLine("-----------------------");

Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979,1,16), 25);
//can also use var 

bethany.DisplayEmployeeDetails();

bethany.PerformWork();
bethany.PerformWork();
bethany.PerformWork(12);
bethany.PerformWork();


bethany.firstName = "John";
bethany.hourlyRate = 10;

//can directly change info about specific object
//overloading 


double receivedWageBethany = Bethany.ReceiveWage(true);
Console.WriteLine($"Wage paid(message from program): { receivedWageBethany}");

Console.WriteLine("Creating an employee");
Console.WriteLine("-----------------------");
*/

var george = new Employee("George", "Jones", "george@snowball.be", new DateTime(1984, 3, 28), 30, EmployeeType.Research);

Employee mysteryEmployee = null;


int[] sampleArray1 = new int[5];
//created on heap. Thats why keyword new
int[] sampleArray2 = new int[] { 1, 2, 3, 4, 5 };
//2 different ways to create arrays

//int[] sampleArray3 = new int[5] { 1, 2, 3, 4, 5, 6 };
//cant change length of array

//DEMONSTATION

Console.WriteLine("How many employee IDs do you want to register?");

int length = int.Parse(Console.ReadLine());
//number is put into length variable

int[] employeeIds = new int[length];
//new array made with length variable being number in new array
var testId = employeeIds[0];

for( int i = 0; i< length; i++)
{
    Console.Write("Enter the employee ID: ");
    int id = int.Parse(Console.ReadLine());//assuming user will always enter int value
    employeeIds[i] = id;
}
//iterating through length to put variables in employeeIds array

for(int i = 0;i < employeeIds.Length; i++)
{
    Console.WriteLine($"ID {i + 1}: \t{employeeIds[i]}");
}
//displaying array to console

#region First run Bethany
//creates a collapsible 
//good for code readability

bethany.DisplayEmployeeDetails();
bethany.PerformWork();
bethany.PerformWork(3);
bethany.PerformWork();
bethany.PerformWork();
bethany.PerformWork(8);

#endregion


//can also use var 

#region First run George
george.DisplayEmployeeDetails();
george.PerformWork();
george.PerformWork(3);
george.PerformWork();
george.PerformWork();
george.PerformWork(8);

var receivedWageGeorge = george.ReceiveWage(true);

#endregion



/*
//string immutability
string name = "bethany;";
string anotherName = name;
name += "smith";

Console.WriteLine("Name: " + name);
Console.WriteLine("Another name: " + anotherName);

string upperCaseName = name.ToUpper();

Console.WriteLine("Name: " + name);
Console.WriteLine("Uppercase name: " + upperCaseName);

//////////////////////////////////////////////////////////////

//creating 2500 copies in memory; opportunity to use StringBuilder
string indexes = string.Empty;

for (int i = 0; i < 2500; i++)
{
    indexes += i.ToString();
}

//how to use StringBuilder
string firstName = "Bethany";
string lastName = "Smith";

StringBuilder sb = new StringBuilder();

sb.Append("Last name: ");
sb.AppendLine(lastName);
sb.Append("First Name: ");
sb.Append(firstName);

string result = sb.ToString();

//using it with loop
StringBuilder sb2 = new StringBuilder();
for (int i = 0; i < 2500; i++)
{
    sb.Append(i);
    sb.Append(" ");
}
*/



//Account account = new Account("12345677");
//IT IS POSITIONAL RECORD NOW, YOU CANNOT CHANGE VALUE OF NUMBER AFTER IT IS SET