//7. Class Attribute vs Instance Attribute
//Definition:
//Instance attribute: Belongs to each object separately.
// Class attribute (static): Shared across all objects of the class.


public class Student
{
    public string Name;              // Instance attribute
    public static int StudentCount;  // Class attribute

    public Student(string name)
    {
        Name = name;
        StudentCount++;
    }
}

Student s1 = new Student("Alice");
Student s2 = new Student("Bob");
Console.WriteLine(Student.StudentCount); // 2
