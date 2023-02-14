public class MathAssignment : Assigment{
    //Variables
    private string _textbookSection;
    private string _problems;

    //Constructores    
    public MathAssignment(string studentName, string topic, string textbookSection, string problems):base(studentName,topic){
        _textbookSection = textbookSection;
        _problems = problems;
    }

    //Getters and Setters
    public string GetTextbookSection()
    {
        return _textbookSection;
    }
    public void SetTextbookSection(string textbookSection)
    {
        _textbookSection = textbookSection;
    }

    
    public string GetProblems()
    {
        return _problems;
    }

     public void SetProblems(string problems)
    {
        _problems = problems;
    }

    //Methods
    public string GetHomeworkList(){
        return "Section "+GetTextbookSection()+" Problems "+GetProblems();
    }
}