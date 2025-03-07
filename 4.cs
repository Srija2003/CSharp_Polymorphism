class vehicle
{
    public virtual void Start()
    {
        Console.WriteLine("Vehicle started");
    }
    public virtual void Stop()
    {
        Console.WriteLine("Vehicle stopped");
    }
}
class bike : vehicle{
    public override void Start()
    {
        Console.WriteLine("Bike started");
    }
    public override void Stop()
    {
        Console.WriteLine("Bike stopped");
    }
}
class car : vehicle
{
    public override void Start()
    {
        Console.WriteLine("Car started");
    }
    public override void Stop()
    {
        Console.WriteLine("Car stopped");
    }
}