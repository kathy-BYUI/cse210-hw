using System;
using System.IO; 

public class Entry
{
    public string _fecha = "";
    public string _response = "";

    public string _prompt;
    string fileName = "myText2.txt";

    public void SaveEntry()
    {
           
      
        Console.WriteLine(":::::::::Ya está");
        


    }
    public void DisplayEntry()
    {              
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            string date = parts[0];
            string prompt = parts[1];
            string response = parts[2];
            // string[] parts = line.Split(",");
            // string firstName = parts[0];
            // string firstName = parts[1];
            //Console.WriteLine($"My name is {firstName} and my lastname is {firstName}");            
            Console.WriteLine($"Date: {date} - Prompt: {prompt}");
            Console.WriteLine(response);

        }
    }

    public void WriteEntry()
    {
        
        //Hice una prueba escribiendo en el archivo fileName nombres y apellidos y los pinté
        // en consola mediante el método DisplayEntry()
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {            
            PromptGenerator question = new PromptGenerator();
                        
            outputFile.WriteLine($"{_fecha},{question._promt},{_response}");
            // // You can add text to the file with the WriteLine method
            // outputFile.WriteLine("Kathy,Campos");
            
            // // You can use the $ and include variables just like with Console.WriteLine
            // string color = "Blue";
            // outputFile.WriteLine($"Sofia, {color}");
        }
    }


}

