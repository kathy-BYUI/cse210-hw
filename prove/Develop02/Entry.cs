using System;
using System.IO; 

public class Entry
{
    public string _fecha = "";
    public string _response = "";
    public string _prompt = "";
    public void SaveEntry() 
    {
        Console.WriteLine(":::::SaveEntry:::::");      
    }
    public void DisplayEntry()
    {              
        Console.WriteLine(":::::DisplayEntry:::::");
    }
    public void WriteEntry()
    {
        Console.WriteLine(":::::WriteEntry:::::");        
    }
}

