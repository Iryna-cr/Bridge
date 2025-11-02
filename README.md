# Bridge
Ідея : 

розділяє абстракцію й реалізацію, щоб змінювати їх незалежно.

Як працює код: 

Міст розділяє дві частини системи — тип замовлення і тип доставки.
Можна змінювати або розширювати кожну частину незалежно.
Наприклад, можна мати “звичайну доставку квітів” або “швидку доставку подарунків” — не змінюючи існуючих класів.

Навіщо: 

легко розширювати без дублювання коду.

## Код
```csharp
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
```
## Результат
![Результат виконання](sc7.png)
