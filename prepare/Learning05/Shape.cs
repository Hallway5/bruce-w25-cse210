using System.Formats.Asn1;

class Shape {

    protected string _color;

    public Shape() {

        _color = "";
    }
    public Shape(string color) {

        _color = color;
    }

    public string GetColor() {

        return _color;
    }

    public void SetColor(string color) {

        _color = color;
    }

    public virtual double GetArea() {

        double area = 0;
        return area;
    }
}