class Product {

    private string _name = "";
    private string _productID = "";
    private double _pricePerUnit = 0;
    private int _quantity = 0;

    public Product() {

        _name = "";
        _productID = "";
        _pricePerUnit = 0;
        _quantity = 0;
    }
    public Product(string name, string productID, double pricePerUnit, int quantity) {

        _name = name;
        _productID = productID;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }

    public double GetPricePerUnit() {

        return _pricePerUnit;
    }

    public int GetQuantity() {

        return _quantity;
    }
}