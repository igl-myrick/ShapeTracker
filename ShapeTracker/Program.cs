using System;
using ShapeTracker.Models;

namespace ShapeTracker
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("Welcome to the Shape Tracker app!");
      Console.WriteLine("What shape would you like to calculate?");
      string userShape = Console.ReadLine();
      if (userShape == "triangle")
      {
        Console.WriteLine("We'll calculate what type of triangle you have based off of the lengths of the triangle's 3 sides.");
        Console.WriteLine("Please enter a number:");
        string stringNumber1 = Console.ReadLine();
        Console.WriteLine("Enter another number:");
        string stringNumber2 = Console.ReadLine();
        Console.WriteLine("Enter a third number:");
        string stringNumber3 = Console.ReadLine();
        int length1 = int.Parse(stringNumber1);
        int length2 = int.Parse(stringNumber2);
        int length3 = int.Parse(stringNumber3);
        Triangle tri = new Triangle(length1, length2, length3);
        ConfirmOrEditTriangle(tri);
      }
      else
      {
        Console.WriteLine("Let's calculate the area of your rectangle.");
        Console.WriteLine("Please enter a number for the first side:");
        string stringNumber1 = Console.ReadLine();
        Console.WriteLine("Please enter a number for the second side:");
        string stringNumber2 = Console.ReadLine();
        int length1 = int.Parse(stringNumber1);
        int length2 = int.Parse(stringNumber2);
        Rectangle userRectangle = new Rectangle(length1, length2);
        ConfirmOrEditRectangle(userRectangle);
      }
    }

    static void ConfirmOrEditTriangle(Triangle tri) {
      Console.WriteLine("Please confirm that you entered in your triangle correctly:");
      Console.WriteLine($"Side 1 has a length of {tri.Side1}");
      Console.WriteLine($"Side 2 has a length of {tri.Side2}");
      Console.WriteLine($"Side 3 has a length of {tri.GetSide3()}");
      Console.WriteLine("Is that correct? Enter 'yes' to proceed, or 'no' to re-enter the triangle's sides");
      string userInput = Console.ReadLine();
      if (userInput == "yes")
      {
        CheckTriangleType(tri);
      }
      else
      {
        Console.WriteLine("Let's fix your triangle. Please enter the 3 sides again!");
        Console.WriteLine("Please enter a number:");
        string stringNumber1 = Console.ReadLine();
        Console.WriteLine("Enter another number:");
        string stringNumber2 = Console.ReadLine();
        Console.WriteLine("Enter a third number:");
        string stringNumber3 = Console.ReadLine();
        tri.Side1 = int.Parse(stringNumber1);
        tri.Side2 = int.Parse(stringNumber2);
        tri.SetSide3(int.Parse(stringNumber3));
        ConfirmOrEditTriangle(tri);
      }
    }
    
    static void CheckTriangleType(Triangle tri)
    {
      string result = tri.CheckType();
      Console.WriteLine("-----------------------------------------");
      Console.WriteLine("Your result is: " + result + ".");
      Console.WriteLine("-----------------------------------------");
      Console.WriteLine("What's next?");
      Console.WriteLine("Would you like to check a new triangle (new)?");
      Console.WriteLine("Please enter 'new' to check the type of a new triangle. To exit, enter any key.");
      string userResponse = Console.ReadLine();
      if (userResponse == "new" || userResponse == "New")
      {
        Main();
      }
      else
      {
        Console.WriteLine("Goodbye!");
      }
    }

    static void ConfirmOrEditRectangle(Rectangle userRectangle)
    {
      Console.WriteLine("Please confirm that you entered in your rectangle correctly:");
      Console.WriteLine($"Side 1 has a length of {userRectangle.Side1}");
      Console.WriteLine($"Side 2 has a length of {userRectangle.Side2}");
      Console.WriteLine("Is that correct? Enter 'yes' to proceed, or 'no' to re-enter the rectangle's sides");
      string userInput = Console.ReadLine();
      if (userInput == "yes")
      {
        CheckRectangleArea(userRectangle);
      }
      else
      {
        Console.WriteLine("Please re-enter the two sides of your rectangle.");
        Console.WriteLine("Please enter a number for the first side:");
        string stringNumber1 = Console.ReadLine();
        Console.WriteLine("Please enter a number for the second side:");
        string stringNumber2 = Console.ReadLine();
        userRectangle.Side1 = int.Parse(stringNumber1);
        userRectangle.Side2 = int.Parse(stringNumber2);
        ConfirmOrEditRectangle(userRectangle);
      }
    }

    static void CheckRectangleArea(Rectangle userRectangle)
    {
      int result = userRectangle.GetArea();
      Console.WriteLine("-----------------------------------------");
      Console.WriteLine("Your result is: " + result + ".");
      Console.WriteLine("-----------------------------------------");
      Console.WriteLine("What's next?");
      Console.WriteLine("Would you like to check a new shape?");
      Console.WriteLine("Please enter 'new' to check a new shape. To exit, enter any key.");
      string userResponse = Console.ReadLine();
      if (userResponse == "new" || userResponse == "New")
      {
        Main();
      }
      else
      {
        Console.WriteLine("Goodbye!");
      }
    }
  }
}