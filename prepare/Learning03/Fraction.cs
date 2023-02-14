public class Fraction 

{
    //Variables
    private int _top;
    private int _bottom;

    //Constructores
    public Fraction(){
        _top = 1;
        _bottom = 1;
    }    
    public Fraction(int wholeNumber){
        _bottom = 1;
    }
    public Fraction(int top, int bottom){}

    //Getters and Setters
    public int GetTop()
    {
        return _top;
    }
    public void SetTop(int top)
    {
        _top = top;
    }

    
    public int GetBottom()
    {
        return _bottom;
    }

     public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    //Methods
    public string GetFractionString(){
        return GetTop() + "/" + GetBottom();
    }

    public double GetDecimalValue(){
        double result = ((double)GetTop())/GetBottom();
        return result;
    }

}