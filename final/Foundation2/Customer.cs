class Customer {

    private string _name;
    private Address _address;

    public Customer() {

        _name = "";
        _address = new Address();
    }
    public Customer(string name, Address address) {

        _name = name;
        _address = address;
    }

    public bool GetIsUS() {

        return _address.GetIsUSAddress();
    }
}