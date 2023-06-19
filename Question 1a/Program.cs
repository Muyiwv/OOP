namespace Question_1a;
class Program
{
    static void Main(string[] args)
    {
        Student[] students = new Student[10]; // creating an array of students with 10 elements 
        var info = "";
        for (int i = 0; i < students.Length; i++) // looping through the lenght of the array to set the values for the student property
        {
            students[i] = new Student(); // creating a new student object 
            students[i].Name = "STUDENT_" + i; // name +1 to make them unique
            students[i].Id = "ID_" + i; // ID 
            students[i].Age = 20 + i; // Age + the value of the element index
        }

        info = Student.GetInformation(students); // to get the value
        Console.WriteLine("INFO: " + info); //. to print it out
        _ = Console.ReadKey();
    }
}