class Scripture
{
    //Attributes
    private Reference _scriptureReference = new Reference();
    private List<Word> _scriptureWord = new List<Word>();

    //Constructors
    public Scripture(){

    }
	
    public Scripture(string referenceWord, string scriptureWord)
    {
        _scriptureReference = new Reference(referenceWord);
        StringToWords(scriptureWord);
    }  

    //Methods
	
	private void StringToWords(string scriptureWord)
    {
        List<string> splitScriptureWord = scriptureWord.Replace(Environment.NewLine," ").Split(" ").ToList<string>();
        {
            _scriptureWord = new List<Word>();
            splitScriptureWord.ForEach((string newWordword) => {_scriptureWord.Add(new Word(newWordword));});
        }
    }


    public bool HideWords(int wordHideMax)
    {
        if(wordHideMax < 0)
        {
            wordHideMax = RandomHideMax(wordHideMax);
            wordHideMax = (new Random().Next(1, wordHideMax));
        }
        List<int> visibleWordsList = GetAllVisibleIndex();
        if(visibleWordsList.Count > 0)
        {
            bool wordHidden = false;
            while(visibleWordsList.Count > 0 && wordHideMax > 0)
            {
                int hideWordIndex = new Random().Next(0, visibleWordsList.Count);
                _scriptureWord[visibleWordsList[hideWordIndex]].SetHidden(true);
                visibleWordsList.RemoveAt(hideWordIndex);
                wordHideMax--;
                wordHidden = true;
            }
            return wordHidden;
        }
        else
        {
            return false;
        }
    }
	
    public int RandomHideMax(int newRemoveCount)
    {
        newRemoveCount = (-newRemoveCount) + 1;
        if(newRemoveCount > _scriptureWord.Count + 1)
        {
            newRemoveCount = _scriptureWord.Count + 1;
        }
        return newRemoveCount;
    }

    private List<int> GetAllVisibleIndex()
    {
        if(IsAnyVisible())
        {
            List<int> returnList = new List<int>();
            for(int i = 0; i < _scriptureWord.Count; i++)
            {
                if(!_scriptureWord[i].GetHidden())
                {
                    returnList.Add(i);
                }
            }
            return returnList;
        }
        return new List<int>(0);

    }
    private bool IsAnyVisible(){

        return _scriptureWord.Exists((Word currentWord)=>{return currentWord.GetHidden()==false;});
    }
    public void DisplayFull()
    {
        Console.WriteLine(_scriptureReference.GetReference()+" "+WordListToString());
    }

    private string WordListToString()
    {
        string returnString = "";
        for(int i=0;i<_scriptureWord.Count;i++)
        {
            if(i != 0)
            {
                returnString+=" ";
            }
            returnString += _scriptureWord[i].GetDisplayString();
        }
        return returnString;
    }

    public void Reset()
    {
        _scriptureWord.FindAll((Word wordItem) => {return wordItem.GetHidden();}).ForEach((Word HiddenWordItem)=>{HiddenWordItem.SetHidden(false);});
 
    }    
}