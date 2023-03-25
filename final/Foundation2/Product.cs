using System;

class Product
{
    private string name;
    private int id;
    private decimal price;
    private int quantity;

    public Product(string name, int id, decimal price, int quantity)
    {
        this.name = name;
        this.id = id;
        this.price = price;
        this.quantity = quantity;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int ID
    {
        get { return id; }
        set { id = value; }
    }

    public decimal Price
    {
        get { return price * quantity; }
        set { price = value; }
    }

    public int Quantity
    {
        get { return quantity; }
        set { quantity = value; }
    }
}