public class ChecklistGoal : Goal
{

    //Attributes    
    private int _timesRequired;
    private int _timesCompleted;
    private int _bonusPoints;

    //Getters & Setters
    public int GetTimesRequired(){
        return _timesRequired;
    }
    public void SetTimesRequired(int timesRequired){
        _timesRequired = timesRequired;
    }
    public int GetTimesCompleted(){
        return _timesCompleted;
    }
    public void SetTimesCompleted(int timesCompleted){
        _timesCompleted = timesCompleted;
    }
    public int GetBonusPoints(){
        return _bonusPoints;
    }
    public void SetBonusPoint(int bonusPoints){
        _bonusPoints = bonusPoints;
    }

    //Constructors        
    public ChecklistGoal(string name, string description, int basePoints, int bonusPoints, int timesRequired): base(name, description, basePoints)
    {         
        _timesRequired = timesRequired;
        _timesCompleted = 0;
        _bonusPoints = bonusPoints; 
    }

    //Methods    
    public override int CompleteGoal()
    {
        if (_timesCompleted == _timesRequired)
        {
            return 0;
        }
        else
        {
            _timesCompleted++;

            if (_timesCompleted == _timesRequired)
            {
                return GetBasePoints() + GetBonusPoints();
            }
            else
            {
                return GetBasePoints();
            }
        }
    }

    public override string GetInfo()
    {
        string checkmark = " ";
        if (_timesCompleted == _timesRequired)
        {
            checkmark = "X";
        }
        return $"[{checkmark}] {GetName()} ({GetDescription()}) -- Currently completed: {GetTimesCompleted()}/{GetTimesRequired()}";
    }

    public override string Serialize()
    {
        return $"ChecklistGoal | {GetName()} | {GetDescription()} | {GetBasePoints()} | {GetBonusPoints()} | {GetTimesRequired()} | {GetTimesCompleted()}";
    }

}