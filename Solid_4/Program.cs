using System;

interface IPriceable
{
    void SetPrice(double price);
}

interface IDiscountable
{
    void ApplyDiscount(String discount);
}

interface IPromocodeable
{
    void ApplyPromocode(String promocode);
}

interface IColorable
{
    void SetColor(byte color);
}

interface ISizable
{
    void SetSize(byte size);
}

class Book : IPriceable, IDiscountable
{
    private double price;
    private String discount;

    public void SetPrice(double price)
    {
        this.price = price;
        Console.WriteLine("Book price: " + price);
    }

    public void ApplyDiscount(String discount)
    {
        this.discount = discount;
        Console.WriteLine("Book discount: " + discount);
    }
}

class Outerwear : IPriceable, IDiscountable, IColorable, ISizable
{
    private double price;
    private String discount;
    private byte color;
    private byte size;

    public void SetPrice(double price)
    {
        this.price = price;
        Console.WriteLine("Outerwear price: " + price);
    }

    public void ApplyDiscount(String discount)
    {
        this.discount = discount;
        Console.WriteLine("Outerwear discount: " + discount);
    }

    public void SetColor(byte color)
    {
        this.color = color;
        Console.WriteLine("Outerwear color: " + color);
    }

    public void SetSize(byte size)
    {
        this.size = size;
        Console.WriteLine("Outerwear size: " + size);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Book book = new Book();
        book.SetPrice(250);
        book.ApplyDiscount("10%");

        Outerwear jacket = new Outerwear();
        jacket.SetPrice(2500);
        jacket.ApplyDiscount("15%");
        jacket.SetColor(3);
        jacket.SetSize(48);

        Console.ReadKey();
    }
}