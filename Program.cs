using System;

class Delivery
{
    protected string type;
    public Delivery(string type) { this.type = type; }
    public virtual void Deliver() => Console.WriteLine($"Доставка: {type}");
}

class FastDelivery : Delivery
{
    public FastDelivery(string type) : base(type) { }
    public override void Deliver() => Console.WriteLine($"dotnetШвидка доставка: {type}");
}

class Program
{
    static void Main()
    {
        Delivery flowers = new FastDelivery("Букет троянд ");
        flowers.Deliver();
    }
}








