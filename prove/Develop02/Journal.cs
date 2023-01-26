using System;
using System.IO; 


public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public string _fileName = "";
    public string _filePath = "journals/";

    public void AddNewEntry(Entry entry)
    {
        this._entries.Add(entry);
    }

    public void DisplayJourney()
    {
        Console.WriteLine("****************** Your entries ***************");
        foreach (var entry in _entries)
        {
            Console.WriteLine($"Date: {entry._fecha} - Prompt: {entry._prompt}");                
            Console.WriteLine($"Response {entry._response} \n");
        }
        Console.WriteLine("***********************************************"); 
    }

    public void SaveToFile()
    {

        using (StreamWriter outputFile = new StreamWriter(_filePath+_fileName))
        {            
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._fecha},{entry._prompt},{entry._response}");
            }
                        
        }
     
    }

    public void LoadFromFile()
    {
        string[] lines = System.IO.File.ReadAllLines(_filePath+_fileName);

        Console.WriteLine($"********** Load from '{_fileName}' **********"); 
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            string date = parts[0];
            string prompt = parts[1];
            string response = parts[2];
                     
            Console.WriteLine($"Date: {date} - Prompt: {prompt}");
            Console.WriteLine($"{response}\n");         
        }
        Console.WriteLine("***********************************************");
    }

}