using System; // using keyword to include / import libraries, frameworks
namespace intro_session
{
    public class Mathematics
    {
        public double pinNumber = 1234;
        private int Addition(int numberOne, int numberTwo)
        // method... inside of a class, a function becomes a method
        {
            // not all code paths return a value
            return numberOne + numberTwo; // the sum of numberOne and numberTwo
        }
        private int Subtraction(int numberOne, int numberTwo)
        {
            return numberOne - numberTwo;
        }
        private int Multiplication(int numberOne, int numberTwo)
        {
            return numberOne * numberTwo;
        }
        private int Division(int numberOne, int numberTwo)
        {
            return numberOne / numberTwo;
        }
        public void LogValue()
        {
            Console.WriteLine(pinNumber);
            int addition = Addition(20, 25);
            int subtraction = Subtraction(25, 20);
            int multiplication = Multiplication(25, 20);
            int division = Division(20, 10);

            Console.WriteLine(addition);
            Console.WriteLine(subtraction);
            Console.WriteLine(multiplication);
            Console.WriteLine(division);

        }
    }
    class Program
    {
        static void Main(string[] args) // entry to the program... entry to our application
        {

            Mathematics maths = new Mathematics();
            Staff staff = new Staff();
            staff.dateOfBirth("18th April, 1965");
            staff.dateOfBirth(18041965);
            staff.dateOfBirth(false);
            maths.pinNumber = 2345;
            staff.TruthCheck(true);
            staff.TruthCheck(123);
            // int total = maths.Subtraction(25,20); // inaccessible due to its protection level
            // maths.LogValue();
            // maths.LogValue(25,20);
            // encapsulation - hiding data - enclosing data from other classes and their members.

        }
    }
}

/*
    identifiers (variables, class, function / method, namespaces) begin with letters - not digits / numbers
    identifiers cannot be keywords... c# keywords - reserved and contextual keywords - bing those bad boys.

*/

// int division = maths.Division(9, 0); // Unhandled exception. System.DivideByZeroException: Attempted to divide by zero.
// DRY principles - don't repeat yourself
// DRY principles - don't repeat yourself
// DRY principles - don't repeat yourself
// WET principles - for testing
// Console.WriteLine(asdfgh); CS0103 
// string myName = "Jacob"; // a string of text
// Console.WriteLine(myName);
// myName = "Neil"; // change the name to Neil from Jacob
// Console.WriteLine(myName);
// int age = 55; // whole number 
// double biggerNumber = 123.3d; // decimal number with a larger range than a float
// decimal aDecimalNumber = 123.3m; // decimal number with a larger range than a double
// float floater = 55.5f; // decimal number
// char singleCharacter = 'P'; // single character surrounded by 'single quotes'
// bool amITrue = false; // no real change