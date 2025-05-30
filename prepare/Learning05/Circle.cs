class Circle : Shape {
    
    private double _radius;

    public Circle() : base() {

        _color = "";
        _radius = 0;
    }
    public Circle(string color, double radius) : base(color) {

        _color = color;
        _radius = radius;
    }

    public override double GetArea() {

        double area = Math.PI * Math.Pow(_radius, 2);
        return area;
    }
}