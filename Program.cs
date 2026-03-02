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