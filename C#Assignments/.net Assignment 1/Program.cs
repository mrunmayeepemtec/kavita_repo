
// Q. 1) Write a C# program that performs all string operations like COMPARE, CONCAT, SUBSTRING, REVERSE using –  

// a) Manual Array operations for character array ‘char[]’ 

/*
 
using System;

namespace Assignment_1
{
    class Program
    {
        public static void Main(String[] args)
        {
            char[] ch1 = { 'a', 'b', 'c', 'd', 'e', 'f' };
            char[] ch2 = { 'a', 'b', 'c', 'd', 'e' };

            // Compare
            Console.WriteLine(ch1.Equals(ch2));               // False

            // Concat
            string str1 = string.Concat(ch1);
            string str2 = string.Concat(ch1);
            Console.WriteLine(string.Concat(str1, str2));       // abcdefabcdef

            // Substring
            Console.WriteLine(str1.Substring(0, str1.Length));      // abcdef

            //Reverse
            for (int i = ch1.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(ch1[i]);                          // fedcba
            }
        }
    }
}

*/

//--------------------------------------------------------------------------------

/* b) Built-in functions for ‘string’ variables */

/*
 
using System;

namespace Assignment_1
{
    class Program
    {
        public static void Main(String[] args)
        {
            string str1 = "C# Programming";
            string str2 = "Python";

            // Compare
            Console.WriteLine(str1.Equals(str2));               // False

            // Concat
            Console.WriteLine(string.Concat(str1, str2));       // C# Programming Python

            // Substring
            Console.WriteLine(str1.Substring(0, str1.Length));      // C# Programming

            //Reverse
            char[] chars1 = str1.ToCharArray();
            Array.Reverse(chars1);
            Console.WriteLine(chars1);                              // gnimmargorP #C

        }
    }
}

*/

//------------------------------------------------------------------------------------------

// Q. 2) Write a C# program to validate an Email ID using –  

// a) Custom logic with loop & conditions 

/*
 
using System;

namespace Assignment_1
{
    class Program
    {
        public static bool IsEmailValid(string email)
        {
            bool result = true;
            int count = email.Count(f => f == '@');

            if (count == 0)
            {
                return false;
            }
            if (count > 1)
            {
                return false;
            }
            count = email.Count(f => f == '.');
            if (count == 0)
            {
                return false;
            }
            if (count > 1)
            {
                return false;
            }
            string theChar = email.Split('@')[1].ToString();
            int theCharLen = theChar.Split('.')[0].ToString().Length;

            if (theCharLen < 2)
            {
                result = false;
            }
            return result;
        }

        static void Main(string[] args)
        {
            string email = "kavita@live.com";

            bool isValid = IsEmailValid(email);

            if (isValid)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }

    }
}

*/

//---------------------------------------------------------------------------------------

// Q. 3) Write a C# program that demonstrates the use of Enums for countries – INDIA, AUSTRALIA, USA, JAPAN, FRANCE, ENGLAND 

/*
 
using System;

namespace Assignment_1
{
    public class Program
    {
        public enum Countries
        {
            INDIA, AUSTRALIA, USA, JAPAN, FRANCE, ENGLAND
        };

        public static void Main(String[] args)
        {
            foreach (Countries c in Enum.GetValues(typeof(Countries)))
            {
                Console.WriteLine(c);
            }
        }
    }
}

*/

//------------------------------------------------------------------------------------------

/* Q. 4) Write a C# program which demoes the concept of OOPS – 

a.Class
b.Constructor
c.Method Overloading
d.Method Overriding
e.Inheritance

 */

/*
 
using System;
using System.Transactions;

namespace Assignment_1
{
    interface Account
    {
        bool Deposit(decimal amount);
        bool Withdraw(decimal amount);
        decimal Balance { get; }

    }

    // Inheritance
    public class SavingAccount : Account
    {
        private decimal balance;
        private decimal perDayLimit;
        public bool Deposit(decimal amount)
        {
            balance += amount;
            return true;
        }
        public bool Withdraw(decimal amount)
        {
            if (balance < amount)
            {
                Console.WriteLine("Insuficient balance!");
                return false;
            }
            else if (perDayLimit + amount > 5000)
            {
                Console.WriteLine("Withrawal attempt failed!");
                return false;
            }
            else
            {
                balance -= amount;
                perDayLimit += amount;

                Console.WriteLine(String.Format("Successfully wuthdraw: {0,6:C}", amount));
                return true;
            }
        }
        public decimal Balance
        {
            get { return balance; }
        }
        public override string ToString()
        {
            return String.Format("Saving Account Balance = {0,6:C}", balance);
        }
    }

    public class CurrentAccount : Account
    {
        private decimal balance;

        public bool Deposit(decimal amount)
        {
            balance += amount;
            return true;
        }

        public bool Withdraw(decimal amount)
        {
            if (balance < amount)
            {
                Console.WriteLine("Insufficient balance!");
                return false;
            }
            else
            {
                balance -= amount;
                Console.WriteLine(String.Format("Successfully withdraw: {0,6:C}", amount));
                return true;
            }
        }
        public decimal Balance
        {
            get { return balance; }
        }
        public override string ToString()
        {
            return String.Format("Current Account Balance = {0,6:C}", balance);
        }
    }

    // class

    public class Customer
    {
        private string firstName = "";
        private string lastName = "";
        private string email = "";
        private string address = "";
        private string phoneNumber = "";

        // Constructor

        public Customer()
        {
            firstName = "Kavita";
            lastName = "Dake";
            email = "kavita@22gmail.com";
            address = "Pune";
            phoneNumber = "12345678901";

        }

        // Overriding

        public override string ToString()
        {
            return "FirstName: " + firstName + "\n" +
                    "LastName: " + lastName + "\n" +
                    "Email: " + email + "\n" +
                    "Address: " + address + "\n" +
                    "PhoneNumber: " + phoneNumber;
        }
    }

    class Program
    {
        int amount, rate, time;
        public static void calculateInterest(int amount, int rate, int time)
        {
            Console.WriteLine("Simple Interest is: " + (amount * rate * time) / 100);
        }
        
        public static void calculateInterest(int amount, int rate)
        {
            int time = 5;
            Console.WriteLine("Simple Interest is: " + (amount * rate * time) / 100)
        }
        

        static void Main(String[] args)
        {
            Account savingAccount = new SavingAccount();
            Account currentAccount = new CurrentAccount();


            savingAccount.Deposit(200);
            savingAccount.Withdraw(100);
            savingAccount.ToString();

            currentAccount.Deposit(500);
            currentAccount.Withdraw(600);
            currentAccount.Withdraw(200);
            currentAccount.ToString();

            Customer customer = new Customer();
            Console.WriteLine(customer);


            // Overlading
            calculateInterest(1000, 4, 4);
            calculateInterest(3000, 2);


            Console.ReadLine();

        }
    }
}

*/

//----------------------------------------------------------------------------------