using System;

// Namespace matches our application
namespace EmployeeApp
{
    // Main program execution class
    class Program
    {
        // Entry point of the console application
        static void Main(string[] args)
        {
            // Instantiate the first Employee object and assign property values
            Employee employee1 = new Employee { Id = 101, FirstName = "John", LastName = "Doe" };

            // Instantiate the second Employee object with a matching ID but different name
            Employee employee2 = new Employee { Id = 101, FirstName = "Jane", LastName = "Smith" };

            // Instantiate a third Employee object with a completely different ID
            Employee employee3 = new Employee { Id = 102, FirstName = "Bob", LastName = "Brown" };

            // Compare employee1 and employee2 using the overloaded "==" operator
            bool areEqual1And2 = (employee1 == employee2);

            // Compare employee1 and employee3 using the overloaded "==" operator
            bool areEqual1And3 = (employee1 == employee3);

            // Display the details and comparison result for employee1 and employee2
            Console.WriteLine($"Employee 1: {employee1.FirstName} (ID: {employee1.Id})");
            Console.WriteLine($"Employee 2: {employee2.FirstName} (ID: {employee2.Id})");
            Console.WriteLine($"Are Employee 1 and Employee 2 equal? {areEqual1And2}\n");

            // Display the details and comparison result for employee1 and employee3
            Console.WriteLine($"Employee 1: {employee1.FirstName} (ID: {employee1.Id})");
            Console.WriteLine($"Employee 3: {employee3.FirstName} (ID: {employee3.Id})");
            Console.WriteLine($"Are Employee 1 and Employee 3 equal? {areEqual1And3}");

            // Keep console window open
            Console.ReadLine();
        }
    }
}
