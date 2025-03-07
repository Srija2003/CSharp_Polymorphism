using System;
interface Animal
{
    void name();
    void sound();
}
class Dog : Animal{
    public void name()
    {
        Console.WriteLine("Dog");
    }
    public void sound()
    {
        Console.WriteLine("Bark");

    }
    public void legs()
    {
        Console.WriteLine("Dog has 4 legs");
    }
}
class cat:Animal{
    public void name()
    {
        Console.WriteLine("Cat");
    }
    public void sound()
    {
        Console.WriteLine("Meow");
    }
}