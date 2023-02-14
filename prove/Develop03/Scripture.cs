class Scripture
{
    //Attributes
    private Reference _scriptureReference = new Reference();
    private List<Word> _scriptureword = new List<Word>();

    //Constructors
    public Scripture(){

    }
	
    public Scripture(string referenceword, string scriptureword)
    {
        _scriptureReference = new Reference(referenceword);
        StringToWords(scriptureword);
    }  

    //Methods
	
	private void StringToWords(string scriptureword)
    {
        List<string> splitScriptureword = scriptureword.Replace(Environment.NewLine," ").Split(" ").ToList<string>();
        {
            _scriptureword = new List<Word>();
            splitScriptureword.ForEach((string newWordword) => {_scriptureword.Add(new Word(newWordword));});
        }
    }

    public bool NextTurn()
    {
        return HideWords(2);
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
                _scriptureword[visibleWordsList[hideWordIndex]].SetHidden(true);
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
        if(newRemoveCount > _scriptureword.Count + 1)
        {
            newRemoveCount = _scriptureword.Count + 1;
        }
        return newRemoveCount;
    }

    private List<int> GetAllVisibleIndex()
    {
        if(IsAnyVisible())
        {
            List<int> returnList = new List<int>();
            for(int i = 0; i < _scriptureword.Count; i++)
            {
                if(!_scriptureword[i].GetHidden())
                {
                    returnList.Add(i);
                }
            }
            return returnList;
        }
        return new List<int>(0);

    }
    private bool IsAnyVisible(){

        return _scriptureword.Exists((Word currentWord)=>{return currentWord.GetHidden()==false;});
    }
    public void DisplayFull()
    {
        Console.WriteLine(_scriptureReference.GetReference()+" "+WordListToString());
    }

    private string WordListToString()
    {
        string returnString = "";
        for(int i=0;i<_scriptureword.Count;i++)
        {
            if(i != 0)
            {
                returnString+=" ";
            }
            returnString += _scriptureword[i].GetDisplayString();
        }
        return returnString;
    }    
}