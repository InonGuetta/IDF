using System;
using System.Collections.Generic;
using System.ComponentModel;

public class Hamas
{
    private string Date_of_establishment = "1900";
    public string Census = "Muhammad";
    public List<Terorist> list_terorist = new List<Terorist> { new Terorist ("fgfh",88,true,"gfxg") };
    public void add_terorist(Terorist terorist) {
        list_terorist.Add(terorist);
    }
    //public void print()
    //{
    //    foreach (var terorist in list_terorist)
    //    {
    //        Console.WriteLine(terorist.name);
    //    }
    //}

}

