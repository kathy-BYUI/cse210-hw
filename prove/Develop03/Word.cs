class Word
{
    //Attributes
    private string _word;
    private bool _hidden;

    //Constructor
    public Word()
    {
        _word = "";
        _hidden = false;
    }
    public Word(string word)
    {
        _word = word;
        _hidden = false;
    }
    
    //Getters and Setters
    public string GetWord()
    {
        return _word;
    }
    public void SetWord(string word)
    {
        _word = word;
    }

    public bool GetHidden()
    {
        return _hidden;
    }
    public void SetHidden(bool hidden)
    {
        _hidden = hidden;
    }

    //Methods
    public string GetDisplayString(){
        if(!_hidden)
        {
            return _word;
        }
        return new string('_',_word.Length);
    }
}