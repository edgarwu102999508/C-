using System;
using System.Collections.Generic;

namespace Classes_Submittable_Task
{
  class Program
  {
    static void Main(string[] args)
    {
      // ======== Task 1 ========
      // Colours colourA = new Colours(255, 0, 0, "Red");
      // Cookies cookieA = new Cookies(12, "Rectangle", colourA);
      // Colours colourB = new Colours(0, 255, 0, "Green");
      // Cookies cookieB = new Cookies(6, "Circle", colourB);

      // System.Console.WriteLine("==== Cookie A ====");
      // System.Console.WriteLine("Weight: " + cookieA.Weight);
      // System.Console.WriteLine("Shape: " + cookieA.Shape);
      // System.Console.WriteLine("RGB Colour: " + cookieA.colour.colour);
      // System.Console.WriteLine("==== Cookie B ====");
      // System.Console.WriteLine("Weight: " + cookieB.Weight);
      // System.Console.WriteLine("Shape: " + cookieB.Shape);
      // System.Console.WriteLine("RGB Colour: " + cookieB.colour.colour);
      // System.Console.Read();

      // ======== Task 2 ========

      Person.Subject p1 = new Person.Subject("SubjectA");
      Person.Subject p2 = new Person.Subject("SubjectB");
      Person.Subject p3 = new Person.Subject("SubjectC");
      List<Person.Subject> ProjectA = new List<Person.Subject>();
      ProjectA.Add(p1);

      List<Person.Subject> ProjectB = new List<Person.Subject>();
      ProjectB.Add(p2);

      List<Person.Subject> ProjectC = new List<Person.Subject>();
      ProjectC.Add(p3);

      Person PersonA = new Person("Edgar", "Wu", "07/10/1984", 183, ProjectA);
      Person PersonB = new Person("Andrew", "Lau", "07/08/1979", 192, ProjectB);
      Person PersonC = new Person("John", "Doe", "02/04/1972", 175, ProjectA);
      //====== Person A ======
      System.Console.WriteLine("ID: " + PersonA.RandId() + " " + PersonA.GetFullName());
      System.Console.WriteLine("Height Difference: " + PersonA.GetHeightDifference(PersonB) + "cm");
      System.Console.WriteLine(ProjectA);

      //====== Person B ======
      System.Console.WriteLine("ID: " + PersonB.RandId() + " " + PersonB.GetFullName());
      System.Console.WriteLine("Height Difference: " + PersonB.GetHeightDifference(PersonC) + "cm");
      System.Console.WriteLine(ProjectB);

      //====== Person C ======
      System.Console.WriteLine("ID: " + PersonC.RandId() + " " + PersonC.GetFullName());
      System.Console.WriteLine("Height Difference: " + PersonA.GetHeightDifference(PersonC) + "cm");
      System.Console.WriteLine(ProjectC);
    }
  }

  class Person
  {
    public string Firstname;
    public string Surname;
    public string Dob;
    public int Height;

    public class Subject
    {
      public string SubName;
      public string YearOfDelivery;
      private string newSubject;

      public Subject(string newSubject)
      {
        this.newSubject = newSubject;
      }
    }

    public List<Subject> Subjects;

    public int RandId()
    {
      Random rand = new Random();
      int Id = rand.Next(1000, 9000);
      return Id;
    }


    public Person(string Firstname, string Surname, string Dob, int Height, List<Subject> subjects)
    {
      this.Firstname = Firstname;
      this.Surname = Surname;
      this.Dob = Dob;
      this.Height = Height;
    }
    public string GetFullName()
    {
      return this.Firstname + " " + this.Surname;
    }

    public int GetHeightDifference(Person Other)
    {
      return Math.Abs(this.Height - Other.Height);
    }

    public void AddNewSubject(string newSubject)
    {
      Subject sub = new Subject(newSubject);
      this.Subjects.Add(sub);
    }
  }

  class Cookies
  {
    // ATTRIBUTES
    public int Weight;
    public string Shape;
    public Colours colour;

    public Cookies(int Weight, string Shape, Colours colour)
    {
      this.Weight = Weight;
      this.Shape = Shape;
      this.colour = colour;
    }
  }
  class Colours
  {
    public int R;
    public int G;
    public int B;
    public string colour;
    public Colours(int R, int G, int B, string colour)
    {
      this.R = R;
      this.G = G;
      this.B = B;
      this.colour = colour;
    }
  }
}




