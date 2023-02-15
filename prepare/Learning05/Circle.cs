public class Circle : Shape
{
    private double _radius;

    public Circle(string color, double radius):base(color){
        _radius = radius;
    }

    public double GetRadius(){
        return _radius;
    }

    public void SetRadius(double radius){
        radius=_radius;
    }

    public override double GetArea()
    {
        return GetRadius()*GetRadius()*3.1416;
    }

}