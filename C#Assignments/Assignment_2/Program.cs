// Write a C# program to validate an Email ID using – 
// a) Using Regex

/*

using System;
using System.Text.RegularExpressions;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = "kavita@123.com";
            Regex regex = new Regex(@"^([\w\. \-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match= regex.Match(email);
            if(match.Success )
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

// Output:- Valid

//--------------------------------------------------------------------------------------------

// Q.2)  Write a C# program that demonstrates NullReference, DivideByZero, StackOverFlow, Generic exceptions.

/*

using System;

namespace Assignment_2
{
    class Program
    {
        int result;

        Program()
        {
            result = 0; 
        }

        public void Division(int n1, int n2)
        {
            try
            {
                result = n1 / n2;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught: {0} ", e);
            }
            finally
            {
                Console.WriteLine("Result: {0}", result);                      
            }       
        }
        public static void Main(string[] args)
        {
            Program p = new();
            p.Division(12, 0);                                         
            Console.ReadLine();                                         
        }
    }
}

*/

/*
 
 Output:- Exception caught: System.DivideByZeroException: Attempted to divide by zero.
                            Result: 0 

*/

//----------------------------------------------------------------------------------------------------------------------

// Q. 3) Write a C# Program to Display the Student Details using Select Clause LINQ.

/*

using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public class Student
    {
        int Id;
        string Name;
        int Sem;
        string Dept;

        public override string ToString()
        {
            return Id + " " + Name + " " + Sem + " " + Dept;
        }

        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
        {
            new Student {Id=101, Name="Kaivta", Sem=2, Dept="Computer Science"},
            new Student {Id=102, Name="Neha", Sem=4, Dept="Networking"},
            new Student {Id=103, Name="Prachi", Sem=3, Dept="Computer Science"},
            new Student {Id=104, Name="Pritam", Sem=6, Dept="Electronic"},
            new Student {Id=105, Name="Sayali", Sem=5, Dept="Electric"},
        };

            var result = from student in students select student;

            Console.WriteLine("ID   Name    Semester  Department");
            Console.WriteLine("-------------------------------------------------");

            foreach (Student e in result)
            {
                Console.WriteLine(e.Id + "  " + e.Name + "   " + e.Sem + "    " + e.Dept);
            }
        }
    }

}

*/

/* OUTPUT:-
 
ID    Name    Semester  Department
-------------------------------------------------
101  Kaivta     2       Computer Science
102  Neha       4       Networking
103  Prachi     3       Computer Science
104  Pritam     6       Electronic
105  Sayali     5       Electric

*/

//-----------------------------------------------------------------------------------------------------------------------------

// Q. 4)  Write a C# Program to Read a Text File.

/*

using System;

namespace Assignemt_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            foreach (string line in System.IO.File.ReadLines("C:\\Users\\kavita.dake\\Desktop\\C# Assignments  II.txt"))
            {
                Console.WriteLine(line);
                count++;
            }
            Console.WriteLine("There are {0} lines.", count);
            Console.ReadLine();
        }
    }
}

*/

/*  OUTPUT:-
 
C# Assignments - II

1.      Write a C# program to validate an Email ID using -
a.      Using Regex

2. Write a C# program that demonstrates NullReference, DivideByZero, StackOverFlow, Generic exceptions.

3. Write a C# Program to Display the Student Details using Select Clause LINQ.

4. Write a C# Program to Read a Text File.

5. Write a C# Program to sort a list of employees based on salary in descending order and whose department is XYZ

6. Write a C# Program to demonstrate the use of Generic classes and methods.
There are 14 lines.

*/

//--------------------------------------------------------------------------------------

// Q.5) Write a C# Program to sort a list of employees based on salary in descending order and whose department is XYZ.

/*
 
using System;
using System.Linq;
using System.Collections.Generic;

namespace Assignment_2
{
    public class Employee
    {
        int Id;
        string Name;
        int Salary;
        string Department;

        public override string ToString()
        {
            return Id + " " + Name + " " + Salary + " " + Department;
        }

        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
        {
            new Employee {Id=101, Name="Kaivta", Salary=1000, Department="ABC"},
            new Employee {Id=102, Name="Neha", Salary=2000, Department="XYZ"},
            new Employee {Id=103, Name="Prachi", Salary=3000, Department="CDE"},
            new Employee {Id=104, Name="Pritam", Salary=4000, Department="XYZ"},
            new Employee {Id=105, Name="Sayali", Salary=5000, Department="UTY"},
        };

            var result = employees.Where(emp => emp.Department == "XYZ").OrderByDescending(sal => sal.Salary);

            Console.WriteLine("ID   Name    Salary  Department");
            Console.WriteLine("-------------------------------------------------");

            foreach (Employee e in result)
            {
                Console.WriteLine(e.Id + "  "  +  e.Name +  "   " + e.Salary + "    " +   e.Department);
            }
        }
    }
}

*/

/* OUTPUT:-
 
ID   Name       Salary      Department
-------------------------------------------------
104  Pritam      4000       XYZ
102  Neha       2000        XYZ

*/

//--------------------------------------------------------------------------------------------

// Q. 6)  Write a C# Program to demonstrate the use of Generic classes and methods.

/*

using System;

namespace Assignment_2
{
    // Create Generic Class
    class Program<T>
    {
       public Program(T msg)
        {
            Console.WriteLine(msg);
        }
    }

    // Create Generic Method

    class Program1
    {
        public void Show<T>(T msg)
        {
            Console.WriteLine(msg);
        }
    }
    class Program2
    {
        static void Main(string[] args)
        {
            Program<string> p1 = new Program<string>("This is generic class.");
            Program<int> p2 = new Program<int>(1);
            Program<char> p3 = new Program<char>('I');

            Program1 Pr1 = new Program1();
            Pr1.Show("This is generic method.");
            Pr1.Show(101);
            Pr1.Show('I');
        }
    }
}

*/

/* OUTPUT:-
 
// Generic Class Output:-

This is generic class.
1
I

// Generic Method Output:-

This is generic method.
101
I

*/

//-------------------------------------------------------------------------------------------