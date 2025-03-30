class Customer {

    private string _name = "";

    public Customer() {

        _name = "";
    }
    public Customer(string name) {

        _name = name;
    }

    public void GetAddress() {

        Address address = new Address();
        GetIsUS(address.GetIsUSAddress());
    }
    public bool GetIsUS(bool isUS) {

        return isUS;
    }
}