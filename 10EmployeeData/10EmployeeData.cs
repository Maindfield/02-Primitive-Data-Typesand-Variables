using System;

namespace EmployeeData
{
    class EmployeeData

        //Problem 10. Employee Data

        //A marketing company wants to keep record of its employees. Each record would have the following characteristics:
        //    First name
        //    Last name
        //    Age (0...100)
        //    Gender (m or f)
        //    Personal ID number (e.g. 8306112507)
        //    Unique employee number (27560000…27569999)

        //Declare the variables needed to keep the information for a single employee using appropriate primitive data types.
        //Use descriptive names. Print the data at the console.

    {
        static void Main()
        {
           
            string firstName = "Georgi";
            string lastName = "Rizov";
            byte age = 28;
            string gender = "M";
            long personalId = 1122334455;
            long employeeNumber = 27561234;

            Console.WriteLine(" First Name: {0}\n Last Name: {1}\n Age: {2}\n Gender {3}\n Personal ID: {4}\n Unique employee number: {5}\n",
                                firstName, lastName, age, gender, personalId, employeeNumber);

        }
    }
}
