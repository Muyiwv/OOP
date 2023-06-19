using System;
namespace Question_1a
{
    public class Student
    {
        public Student()
        {
        }
        private string? name; // define the 3 properties of the student object
        private string? id;
        private int age;

        public string Name
        {
            get { if (name == null) { return ""; } return name; } // defining a public getter and setter so the properties will be accessible outside of this class
            set { name = value; }
        }

        public string Id
        {
            get { if (id == null) { return ""; } return id; }
            set { id = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public static string GetInformation(Student[]? students) // declaring a method that takes an array of students
        {
            string studentInfo = "";
            if (students == null) { return studentInfo; } // Checking that the value of our array is not null.
            for (int i = 0; i < students.Length; i++)  // looping through the array of students to get the values in the object properties
            {
                studentInfo += " Name : " + students[i].Name + " Id : " + students[i].Id + " Age : " + students[i].Age + "\n";
            }
            return studentInfo; // returning the values from the student property
        }
    }
}

