using System;

// Namespace groups our classes together
namespace EmployeeApp
{
    // Define the Employee class
    public class Employee
    {
        // Property for Employee ID number
        public int Id { get; set; }

        // Property for Employee first name
        public string FirstName { get; set; }

        // Property for Employee last name
        public string LastName { get; set; }

        // Overload the "==" operator to compare two Employee objects by Id
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // Check if both objects are null or the same instance
            if (ReferenceEquals(emp1, emp2))
            {
                return true;
            }

            // If one is null, they are not equal
            if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
            {
                return false;
            }

            // Compare the Id properties of both employees
            return emp1.Id == emp2.Id;
        }

        // C# requires comparison operators to be overloaded in pairs (== and !=)
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            // Return the opposite of the "==" operator
            return !(emp1 == emp2);
        }

        // Override Equals to match operator behavior and avoid compiler warnings
        public override bool Equals(object obj)
        {
            // Check if the incoming object is an Employee
            if (obj is Employee otherEmployee)
            {
                // Return true if IDs match
                return this.Id == otherEmployee.Id;
            }
            return false;
        }

        // Override GetHashCode since we overrode Equals
        public override int GetHashCode()
        {
            // Return the hash code of the Id property
            return Id.GetHashCode();
        }
    }
}
