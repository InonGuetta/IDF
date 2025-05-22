using System.Collections.Generic;
public class Aman : Hamas
{
    Terorist name =;
    string time;
    string place;
    List<string> list_message = new List<string>();
    public Aman()
    {
        //this.name = name;
        this.time = time;
        this.place = place;
        message();
    }
   
    public void message() 
        {
        string msg = $"Report that {name} was in {place} at {time}";
        list_message.Add(msg);
        }  
    }



