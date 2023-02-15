public abstract class Goal
{
    //Attributes
    private string _name;
    private string _description;
    private int _basePoints;

    //Constructors
    public Goal(string name, string description, int basePoints)
    {
        _name = name;
        _description = description;
        _basePoints = basePoints;
    }

    //Getters & Setters
    public string GetName(){
        return _name;
    }
    public void SetName(string name){
        _name = name;
    }
    public string GetDescription(){
        return _description;
    }
    public void SetDescription(string description){
        _description = description;
    }
    public int GetBasePoints(){
        return _basePoints;
    }
    public void SetBasePoint(int basePoints){
        _basePoints = basePoints;
    }

    //Abstract Methods
    public abstract int CompleteGoal();
    public abstract string GetInfo();
    public abstract string Serialize();
}