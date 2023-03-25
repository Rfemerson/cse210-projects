using System;

class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        this._products.Add(product);
    }

    public decimal CalculateTotalCost()
    {
        decimal total = 0;
        foreach (Product product in _products)
        {
            total += product.Price;
        }

        if (_customer.Address.Country == "USA")
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return total;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n\n";
        foreach (Product product in _products)
        {
            packingLabel += $"Product name: {product.Name}, Product ID: {product.ID}\n";
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = "Shipping Label:\n\n";
        shippingLabel += $"Customer Name: {_customer.Name}\n";
        shippingLabel += $"Address: {_customer.Address.GetAddressString()}\n";

        return shippingLabel;
    }
}