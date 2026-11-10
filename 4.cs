interface IDiscount
{
    void ApplyDiscount(string discount);
}

interface IPromocode
{
    void ApplyPromocode(string promocode);
}

interface IColor
{
    void SetColor(byte color);
}

interface ISize
{
    void SetSize(byte size);
}

interface IPrice
{
    void SetPrice(double price);
}

class Book : IPrice, IDiscount
{
    public double Price { get; private set; }

    public void SetPrice(double price)
    {
        Price = price;
    }

    public void ApplyDiscount(string discount)
    {
    }
}

class Clothing : IPrice, IDiscount, IColor, ISize
{
    public double Price { get; private set; }
    public byte Color { get; private set; }
    public byte Size { get; private set; }

    public void SetPrice(double price)
    {
        Price = price;
    }

    public void ApplyDiscount(string discount)
    {
    }

    public void SetColor(byte color)
    {
        Color = color;
    }

    public void SetSize(byte size)
    {
        Size = size;
    }
}