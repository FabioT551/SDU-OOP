using System;
public class Student
{   
    private string name;
   private int age;
   private static int studentCount = 0;
   public Student(string name, int age)
   {
       this.name = name;
       SetAge(age);
       studentCount++;
   }
   public string GetName()
   {
       return name;
   }

   public int GetAge()
   {
       return age;
   }
    public void SetAge(int age)
    {
        if (age < 0)
        {
            throw new ArgumentException("Age cannot be negative.");
        }
        this.age = age;
    }
 public static int GetStudentCount()
    {
        return studentCount;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
       Student peter = new Student("Peter", 20);
       Student mads = new Student("Mads", 22);
       Console.WriteLine(peter.GetName());
       Console.WriteLine(peter.GetAge());
       Console.WriteLine(mads.GetName());
       Console.WriteLine(mads.GetAge());
       
       peter.SetAge(21);
       
       Console.WriteLine(peter.GetName());  
       Console.WriteLine(peter.GetAge()); 
       Console.WriteLine("Student count");
       Console.WriteLine(Student.GetStudentCount());

        // Console.WriteLine(peter.name);
    }
}