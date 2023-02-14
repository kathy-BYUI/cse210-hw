public class WritingAsignment : Assigment{
    //Atributos
    private string _title;

    public WritingAsignment(string studentName, string topic, string title)
        :base(studentName,topic){
        _title = title;
    }

    public string GetTitle(){
        return _title;
    }

    public string GetWritingInformation(){
        return GetTitle() + " by " + GetStudentName();
    }
}