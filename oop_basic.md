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




using System;


public abstract class Payment
{
    public int Amount { get; set; }


    public string TransactionId { get; set; }

    public abstract void ValidatePayment();

    public abstract void ProcessPayment();

    // Card validation process payment and bikash validation process payment not same



    // public void ValidatePayment()
    // {
    //     Console.WriteLine("validating payment");
    // } 

    // public void ProcessPayment()
    // {
    //     Console.WriteLine("Processing Payment");
    // }

    public void ShowInfo()
    {
        Console.WriteLine("amount: {0}", Amount);
        Console.WriteLine("TransactionId: {0}", TransactionId);
    }



}

public class CreditCardPayment : Payment
{
    public string CardNumber { get; set; }

    public override void ValidatePayment()
    {
        Console.WriteLine("Validate Payment By Card");
    }

    public override void ProcessPayment()
    {
        Console.WriteLine("Process Payment By Card");
    }
}

public class bikashPayment : Payment
{
    public string MobileNumber { get; set; }

    public override void ValidatePayment()
    {
        Console.WriteLine("Validate Payment By bikash");
    }

    public override void ProcessPayment()
    {
        Console.WriteLine("Process Payment By bikash");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Payment creditCardPayment = new CreditCardPayment
        {
            Amount = 100,
            TransactionId = "123456",
            CardNumber = "123456"
        };

        creditCardPayment.ValidatePayment();

        creditCardPayment.ProcessPayment();

        creditCardPayment.ShowInfo();


        Payment bikashPayment = new bikashPayment
        {
            Amount = 200,
            TransactionId = "123456",
            MobileNumber = "019222"
        };

        bikashPayment.ValidatePayment();

        bikashPayment.ProcessPayment();

        bikashPayment.ShowInfo();
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

<!-- interface class thakbei na -->

public interface Payment
{
   
}

<!-- interface and abstract main class same -->

using System;


public interface Payment
{
   public void Payment();
   public void PaymentDetails();
}

public class creditPayment : Payment
{
    public void Payment()
    {
        Console.WriteLine("Payment Show Info interface");
    }

    public void PaymentDetails()
    {
        Console.WriteLine("Payment Details Info interface");
    }
}

// bikash e only show info dekabo

class Program
{
    static void Main(string[] args)
    {
        Payment payment = new creditPayment();

        payment.PaymentDetails();

        payment.Payment();
    }
}