public class SimpleGoal : Goal
{
    //Atributes
    private bool _isComplete;

    //Constructors    
    public SimpleGoal(string name, string description, int basePoints):base(name, description, basePoints)
    {
        _isComplete = false;
    }

    //Getters & Setters
    public bool GetIsComplete(){
        return _isComplete;
    }
    public void SetIsComplete(bool isComplete){
        _isComplete = isComplete;
    }

    //Methods
    public override int CompleteGoal()
    {
        if (GetIsComplete())
        {
            return 0;
        }
        else
        {
            _isComplete = true;
            return GetBasePoints();
        }
    }
    public override string GetInfo()
    {
        string checkMark = " ";
        if (GetIsComplete())
        {
            checkMark = "X";
        }
        return $"[{checkMark}] {GetName()} ({GetDescription()})";
    }

    public override string Serialize()
    {
        return $"SimpleGoal | {GetName()} | {GetDescription()} | {GetBasePoints()} | {GetIsComplete()}";
    }

}