using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public int Id{ get ; set; }
    public string Name { get ; set; }
    public int Age { get ; set ; }
    public string Course { get ; set ;}
}

class Program
{
    static List <Student> studentsList = new List<Student>();

    static void Main()
    {
        while (true)
        {
           Console.WriteLine("\n===== Student Management System =====");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. View All Students");
            Console.WriteLine("3. Search Student");
            Console.WriteLine("4. Update Student");
            Console.WriteLine("5. Delete Student");
            Console.WriteLine("6. Exit");
            Console.Write("Enter choice: "); 

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1: AddStudent(); break;
                case 2: ViewStudents(); break;
                case 3: SearchStudent(); break;
                case 4: UpdateStudent(); break;
                case 5: DeleteStudent(); break;
                case 6: return;
                default: Console.WriteLine("Invalid choice!"); break;
            }
        }
    }
    static void AddStudent()
    {
        Student s = new Student();

        Console.Write("Enter the Id :");
        s.Id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Name: ");
        s.Name = Console.ReadLine();

        Console.Write("Enter Age: ");
        s.Age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Course: ");
        s.Course = Console.ReadLine();

        studentsList.Add(s);
        Console.WriteLine("Student added successfully!");
    }
    static void ViewStudents()
    {
        if (studentsList.Count == 0)
        {
            Console.WriteLine("Student record not found...");
            return;
        }
        Console.WriteLine("List of student is: ");
        foreach(var s in studentsList)
        {
            Console.WriteLine($"ID: {s.Id}, Name:{s.Name}, Age:{s.Age},Course: {s.Course}");

        }
    }
    static void SearchStudent()
    {
         Console.Write("Enter ID to search: ");
        int id = Convert.ToInt32(Console.ReadLine());

        var student = studentsList.FirstOrDefault(s => s.Id == id);


        if(student != null)
        {
            Console.WriteLine($"Found: {student.Name}, Age: {student.Age}, Course: {student.Course}");
        
        }
        else
        {
            Console.WriteLine("Student not found.");
        }
    }



 static void UpdateStudent()
    {
        Console.Write("Enter ID to update: ");
        int id = Convert.ToInt32(Console.ReadLine());

        var student = studentsList.FirstOrDefault(s => s.Id == id);

        if (student != null)
        {
            Console.Write("Enter New Name: ");
            student.Name = Console.ReadLine();

            Console.Write("Enter New Age: ");
            student.Age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter New Course: ");
            student.Course = Console.ReadLine();

            Console.WriteLine("Student updated successfully!");
        }
        else
        {
            Console.WriteLine("Student not found.");
        }
    }

 static void DeleteStudent()
    {
        Console.Write("Enter ID to delete: ");
        int id = Convert.ToInt32(Console.ReadLine());

        var student = studentsList.FirstOrDefault(s => s.Id == id);

        if (student != null)
        {
            studentsList.Remove(student);
            Console.WriteLine("Student deleted successfully!");
        }
        else
        {
            Console.WriteLine("Student not found.");
        }
    }

}