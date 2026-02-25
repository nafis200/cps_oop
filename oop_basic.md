<!-- encapsulation -->

using System;


public class Car
{
    public string brand;
    public int speed;

    public Car()
    {
        
    }
    public Car(string brand, int spedd)
    {
        this.brand = brand;
        this.speed = spedd;
    }

    public void Drive()
    {
        Console.WriteLine("hellow Drive");
    }

    public int CarSpeed()
    {
        return speed;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car("nafis",26);

        Console.WriteLine(car.CarSpeed());
    }
}


<!-- inheritance -->


using System;


public class Person
{
    public string name;
    public string email;
    public string phoneNumber;
}

public class Student : Person
{
    public int RollNumber;
    public Student(string name)
    {
        this.name = name;
    }

    public void printf()
    {
        Console.WriteLine($"Name is {name}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student("nafis");

        student.printf();
        
    }
}


<!-- abstract Class -->

using System;

public abstract class Animal
{
    public abstract void makeSound();

    public void Eats(){
       Console.WriteLine("Animals are eats");   
    }
}

class Dog : Animal{
public override void makeSound()
{
    Console.WriteLine("Dog is bark");
}

}

class Program
{
    static void Main(string[] args)
    {

      Dog dogs = new Dog();
      dogs.makeSound();  
      dogs.Eats();
        
    }
}


<!-- sealed  not inherit-->

using System;

public sealed class Sealed{
    public void Test(){

    }
}

class Program
{
    static void Main(string[] args)
    {
        
    }
}