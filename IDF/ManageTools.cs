using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.ExceptionServices;

public class ManageTools
{
    // שלא כתוב כאן כלום מה זה אומר 
    // זה אומר שהוא נמצא בברירת מחדל כלומר הוא מוגדר כ private
    static List<Drone> drons = new List<Drone>();
    static List<FighterJet> fighterJets = new List<FighterJet>();
    static List<Artillery> artilleries = new List<Artillery>();
    static List<CreateAttackTolls> CreateAttackTolls = new List<CreateAttackTolls>();

    public void showData()
    {
        foreach (Drone item in drons)
        {
        // שים לב הערכים אותם אתה מציג הם ערכים מהאב האבסטרקטי ממנו לוקחים את הכל 
        // ושים לב כי הערכים המוצגים בלולאה הם 
        Console.WriteLine($"" +
            $"THE DRONES LIST" +
            $" name: {item.InsertNameGun} efective against {item.SelectedEfective} type bomb {item.SelectedTypeBomb}" +
            $" activate by {item.SelectedActiveBy} count of ammo {item.AmountOfAmmunation}");
        }

        foreach (FighterJet item in fighterJets)
        {
            Console.WriteLine($"TEH FIGHT JETS LIST" +
            $"name {item.InsertNameGun} efective against {item.SelectedEfective} type bomb {item.SelectedTypeBomb}" +
            $" activate by {item.SelectedActiveBy} count of ammo {item.AmountOfAmmunation}");
        }

        foreach (Artillery item in artilleries)
        {
            Console.WriteLine($"TEH ARTILLERY LIST" +
            $"name {item.InsertNameGun} efective against {item.SelectedEfective} type bomb {item.SelectedTypeBomb}" +
            $" activate by {item.SelectedActiveBy} count of ammo {item.AmountOfAmmunation}");
        }

        foreach (CreateAttackTolls item in CreateAttackTolls)
        {
            Console.WriteLine($"TEH ARTILLERY LIST" +
            $"name {item.InsertNameGun} efective against {item.SelectedEfective} type bomb {item.SelectedTypeBomb}" +
            $" activate by {item.SelectedActiveBy} count of ammo {item.AmountOfAmmunation}");
        }


    }
    

}