using System;

// namespace Staff_Information
namespace intro_session
{
    class Staff
    {
        public string Names(string firstName, string lastName)
        {
            string fullName = firstName + " " + lastName;
            return fullName;
        }
        // polymorphism
        public void dateOfBirth(int value)
        {
            Console.WriteLine($"Your date of birth was inputted as an int.");
        }
        public void dateOfBirth(string value)
        {
            Console.WriteLine("Your date of birth was inputted as a string");
        }
        public void dateOfBirth(bool value)
        {
            Console.WriteLine("I don't know what you even mean here?");
        }

        public void TruthCheck(bool check)
        {
            Console.WriteLine("Okay, you check out.");
        }
        public void TruthCheck(int check)
        { 
            bool value = Convert.ToBoolean(check);
            Console.WriteLine(check.GetType());
            Console.WriteLine(value.GetType());
        }

    }
}

/*

To access a class in another namespace, you have to access it through the namespace. 

E.g. From intro_sessions:

Staff_Information.Staff

From Staff_Information:

intro_sessions.Mathematics

 */