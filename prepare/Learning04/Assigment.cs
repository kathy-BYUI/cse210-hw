public class Assigment {
    //Variables
    private string _studentName;
    private string _topic;
      
    //Constructores
    public Assigment(string studentName, string topic){
        _studentName = studentName;
        _topic = topic;

    }

    //Getters and Setters
    public string GetStudentName()
    {
        return _studentName;
    }
        
    public string GetTopic()
    {
        return _topic;
    }

    //Methods
    public string GetSummary(){

        return GetStudentName() + " - " + GetTopic();        

    }

}