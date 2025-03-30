class Order {

    private List<Product> _products = new List<Product>();
    private float _totalCost;
    private string _packagingLabel;
    private string _shippingLabel;

    public Order() {

        _products = [];
        _totalCost = 0;
        _packagingLabel = "";
        _shippingLabel = "";
    }
    public Order(List<Product> products, float totalCost, string packagingLabel, string shippingLabel) {

        _products = products;
        _totalCost = totalCost;
        _packagingLabel = packagingLabel;
        _shippingLabel = shippingLabel;
    }

    public void AddProduct() {


    }

    public float CalcualteCost() {

        return _totalCost;
    }

    public string GetPackagingLabel() {

        return _packagingLabel;
    }

    public string GetShippingLabel() {

        return _shippingLabel;
    }
}