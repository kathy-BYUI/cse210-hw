class Reference
{
    //Attributes
    private string _reference;

    //Constructor
    public Reference()
    {
        _reference = "";
    }
	public Reference(string reference)
    {
        _reference = reference;
    }

    public Reference(string book, int chapter, int firstVerse, int lastVerse = -1)
    {
        string newReference = book+" "+chapter+":"+firstVerse;
        if(lastVerse > 0 && lastVerse > firstVerse)
        {
            _reference = newReference+"-"+lastVerse;
        }
        else
        {
            _reference = newReference;
        }
    }    

    public Reference(string book, int chapter, int[][] verseMatrix)
    {
        _reference = book+" "+chapter+":"+VersesMatrixToString(verseMatrix);
    }

    public Reference(string book, int chapter, int[] singleVerseArr)
    {
        _reference = book+" "+chapter+":"+string.Join(",",singleVerseArr);
    }
    



    //Getters and setters
    public string GetReference()
    {
        return _reference;
    }
    public void SetReference(string reference)
    {
        _reference = reference;
    }

    //Methods
    private string VersesMatrixToString(int[][] versesArray){
        string returnString = ""; 
        for(int i = 0; i < versesArray.Length; i++)        {
            if(i != 0){returnString += ",";}
            else{returnString += VerseStringFromSet(versesArray[i]);}
        }
        return returnString;
    }
    private string VerseStringFromSet(int[] verseSet)
    {
        if(verseSet.Length == 1)
        {
            return verseSet[0]+"";
        }
        else if(verseSet.Length > 1)
        {
            return verseSet[0]+"-"+verseSet[verseSet.Length - 1];
        }
        else
        {
            return "";
        }
    }
}