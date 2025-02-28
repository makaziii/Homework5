//QUESTION1
public class Vehicle
{
    // Properties
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    // Constructor
    public Vehicle(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }

    // Override ToString() 
    public override string ToString()
    {
        return $"{Year} {Make} {Model}";
    }
}

public class Car : Vehicle
{
    // Additional property
    public int NumberOfDoors { get; set; }

    // Constructor
    public Car(string make, string model, int year, int numberOfDoors) : base(make, model, year)
    {
        NumberOfDoors = numberOfDoors;
    }

    // Override ToString()
    public override string ToString()
    {
        return $"{Year} {Make} {Model} with {NumberOfDoors} doors";
    }
}

public class Motorcycle : Vehicle
{
    // Additional property
    public bool HasSidecar { get; set; }

    // Constructor
    public Motorcycle(string make, string model, int year, bool hasSidecar) : base(make, model, year)
    {
        HasSidecar = hasSidecar;
    }

    // Override ToString()
    public override string ToString()
    {
        return $"{Year} {Make} {Model} (Has Sidecar: {HasSidecar})";
    }
}

//QUESTION2

//Create Class
public class Employee
{
    //Properties
    public string Name { get; set; }
    public double Salary { get; set; }


    //Constructor
    public Employee(string name, double salary)
    {
        Name = name;
        Salary = salary;
    }

    //ToString Method
    public override string ToString()
    {
        return $"Employee: {Name}, Salary: ${Salary}";
    }
}
//Create Class
public class Manager : Employee
{
    // Properties
    public int NumberOfEmployeesManaged { get; set; }


    //Constructor
    public Manager(string name, double salary, int numberOfEmployeesManaged)
        : base(name, salary)
    {
        NumberOfEmployeesManaged = numberOfEmployeesManaged;
    }

    //ToString Method
    public override string ToString()
    {
        return $"Manager: {Name}, Salary: ${Salary}, Employees Managed: {NumberOfEmployeesManaged}";
    }
}
//Create Class
public class Engineer : Employee
{
    // Properties
    public string Specialization { get; set; }


    // Constructor
    public Engineer(string name, double salary, string specialization)
        : base(name, salary)
    {
        Specialization = specialization;
    }

    // ToString Method
    public override string ToString()
    {
        return $"Engineer: {Name}, Salary: ${Salary}, Specialization: {Specialization}";
    }
}

//QUESION3
public abstract class Shape
{
    // Property for Color
    public string Color { get; set; }

    // Constructor
    public Shape(string color)
    {
        Color = color;
    }

    // Abstract method
    public abstract double GetArea();

    // Override ToString() method
    public override string ToString()
    {
        return $"{Color} Shape";
    }
}
public class Rectangle : Shape
{
    // Properties
    public double Width { get; set; }
    public double Height { get; set; }

    // Constructor
    public Rectangle(string color, double width, double height) : base(color)
    {
        Width = width;
        Height = height;
    }

    // Implement GetArea()
    public override double GetArea()
    {
        return Width * Height;
    }

    // Override ToString()
    public override string ToString()
    {
        return $"{Color} Rectangle with Width: {Width}, Height: {Height}, Area: {GetArea()}";
    }
}
public class Circle : Shape
{
    
    public double Radius { get; set; }

    // Constructor
    public Circle(string color, double radius) : base(color)
    {
        Radius = radius;
    }

    //GetArea()
    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }

    // Override ToString()
    public override string ToString()
    {
        return $"{Color} Circle with Radius: {Radius}, Area: {GetArea()}";
    }
}
//QUESTION4
public class Animal
{
    // Property for Name
    public string Name { get; set; }

    // Constructor
    public Animal(string name)
    {
        Name = name;
    }

    // Virtual method
    public virtual string MakeSound()
    {
        return "Some generic animal sound";
    }

    // Override ToString() method
    public override string ToString()
    {
        return $"Animal: {Name}, Sound: {MakeSound()}";
    }
}
public class Dog : Animal
{
    // Constructor
    public Dog(string name) : base(name) { }

    // Override MakeSound()
    public override string MakeSound()
    {
        return "Bark";
    }
}
public class Cat : Animal
{
    // Constructor
    public Cat(string name) : base(name) { }

    // Override MakeSound()
    public override string MakeSound()
    {
        return "Meow";
    }
}
//QUESTION5
// Create Class
public class Book
{
    //Properties
    public string Title { get; set; }
    public string Author { get; set; }
    public int YearPublished { get; set; }


    // Constructor
    public Book(string title, string author, int yearPublished)
    {
        Title = title;
        Author = author;
        YearPublished = yearPublished;
    }

    //ToString Method
    public override string ToString()
    {
        return $"{Title} by {Author} ({YearPublished})";
    }
}
//Create Class
public class EBook : Book
{
    //Properties
    public double FileSizeMB { get; set; }


    //Constructor
    public EBook(string title, string author, int yearPublished, double fileSizeMB)
        : base(title, author, yearPublished)
    {
        FileSizeMB = fileSizeMB;
    }

    //ToString Method
    public override string ToString()
    {
        return $"{Title} by {Author} ({YearPublished}) - File Size: {FileSizeMB} MB";
    }
}
//Create Class
public class PrintedBook : Book
{
  
    public int PageCount { get; set; }

    //Constructor
    public PrintedBook(string title, string author, int yearPublished, int pageCount)
        : base(title, author, yearPublished)
    {
        PageCount = pageCount;
    }

    //ToString Method
    public override string ToString()
    {
        return $"{Title} by {Author} ({YearPublished}) - Pages: {PageCount}";
    }
}
