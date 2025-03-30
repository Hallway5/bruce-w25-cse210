class Address {

    private string _streetAdr = "";
    private string _city = "";
    private string _stateProvince = "";
    private string _country = "";

    public Address() {

        _streetAdr = "";
        _city = "";
        _stateProvince = "";
        _country = "";
    }
    public Address(string streetAdr, string city, string stateProvince, string country) {

        _streetAdr = streetAdr;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    public bool GetIsUSAddress() {

        if (_country == "United States") {

            return true;
        }
        else {

            return false;
        }
    }
}