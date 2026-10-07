using System;
using System.Collections.Generic;

class Student
{
    public int Id;
    public string Name;
    public int Age;
}

class Program
{
    static List<Student> students = new List<Student>();

    static void Main()
    {
        Console.WriteLine("Student Management System");

        Console.Write("Enter Student ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Student Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Student Age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        students.Add(new Student
        {
            Id = id,
            Name = name,
            Age = age
        });

        Console.WriteLine("Student added successfully!");
        Console.WriteLine("CRUD feature branch is working!");
        Console.WriteLine("\nStudent List:");
foreach (Student student in students)
{
    Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
}
// UPDATE STUDENT

Console.Write("\nEnter Student ID to update: ");
int updateId = Convert.ToInt32(Console.ReadLine());

foreach (Student student in students)
{
    if (student.Id == updateId)
    {
        Console.Write("Enter new name: ");
        student.Name = Console.ReadLine();

        Console.Write("Enter new age: ");
        student.Age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Student updated successfully!");
    }
}
// DELETE STUDENT

Console.Write("\nEnter Student ID to delete: ");
int deleteId = Convert.ToInt32(Console.ReadLine());

Student studentToDelete = students.Find(s => s.Id == deleteId);

if (studentToDelete != null)
{
    students.Remove(studentToDelete);
    Console.WriteLine("Student deleted successfully!");
}
else
{
    Console.WriteLine("Student not found!");
}
}
}