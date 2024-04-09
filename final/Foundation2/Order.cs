public class Order
{
    private List<Product> _products = new(); 
    private Customer _customer;
    private string _id;

    public Order(Customer customer, string id)
    {
        _customer = customer;
        _id = id;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public List<Product> GetProductList()
    {
        return _products;
    }

    public string GetCustName()
    {
        return _customer.GetName();
    }

    public bool GetIntShipping()
    {
        return _customer.IsUSA();
    }

    public string GetOrder()
    {
        return $"{_id}";
    }

    // public string GetProductName()
    // {
    //     return 
    // }

    // public float GetOrderTotal()
    // {
    //     if (isUSA)
    // }

    // public string GetPackingLabel()
    // {

    // }

    public string GetShippingLabel()
    {
        return $"  {_customer.GetName()}\n{_customer.GetAddress()}";
    }
}