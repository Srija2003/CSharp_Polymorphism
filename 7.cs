class Baseclass
{
    public virtual void showw()
    {
        Console.WriteLine("Base class");
    }
}
class Derivedclass : Baseclass{
    public override void showw()
    {
        Console.WriteLine("Derived class");
    }
}
class another: Baseclass
{
    public  void display()
    {
        Console.WriteLine("Another class");
    }
    public override void showw()
    {
        Console.WriteLine("Another class in last class");
    }
}