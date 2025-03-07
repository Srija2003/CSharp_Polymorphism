using System;
class Payment
{
    public virtual void MakePayment()
    {
        Console.WriteLine("Making Payment");
    }
}
class CreditCard : Payment{
    public override void MakePayment()
    {
        Console.WriteLine("Payment through Credit Card");
    }
}
class DebitCard : Payment{
    public override void MakePayment()
    {
        Console.WriteLine("Payment through debit card");
    }
}