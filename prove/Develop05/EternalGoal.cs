public class EternalGoal : Goal
{
   
    //Contructor
    public EternalGoal(string name, string description, int basePoints): base(name, description, basePoints)
    {
    }
    //Methods
    public override int CompleteGoal()
    {
        return GetBasePoints();
    }
    public override string GetInfo()
    {
        return $"[ ] {GetName()} ({GetDescription()})";
    }
    public override string Serialize()
    {
        return $"EternalGoal | {GetName()} | {GetDescription()} | {GetBasePoints()}";
    }
}