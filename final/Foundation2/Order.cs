class Order {

    private Customer _customer;
    private List<Product> _products = new List<Product>();
    private double _totalCost;
    private string _packagingLabel;
    private string _shippingLabel;

    public Order() {

        _customer = new Customer();
        _products = [];
        _totalCost = 0;
        _packagingLabel = "";
        _shippingLabel = "";
    }
    public Order(Customer customer, List<Product> products, float totalCost, string packagingLabel, string shippingLabel) {

        _customer = customer;
        _products = products;
        _totalCost = totalCost;
        _packagingLabel = packagingLabel;
        _shippingLabel = shippingLabel;
    }

    public double CalcualteCost() {

        foreach (Product product in _products) {

            _totalCost += (product.GetPricePerUnit() * product.GetQuantity());
        }

        if (_customer.GetIsUS() == true) {

            _totalCost += 5.00;
        }
        else {

            _totalCost += 35.00;
        }
        
        return _totalCost;
    }

    public string GetPackagingLabel() {

        return _packagingLabel;
    }

    public string GetShippingLabel() {

        return _shippingLabel;
    }
}