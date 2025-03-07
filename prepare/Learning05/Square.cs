using System.Drawing;
using System.Formats.Asn1;

class Square : Shape {

    private double _side;

    public Square() : base() {

        _color = "";
        _side = 0;
    }
    public Square(string color, double side) : base(color) {

        _color = color;
        _side = side;
    }

    public override double GetArea() {

        double area = Math.Pow(_side, 2);
        return area;
    }
}