using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.ExceptionServices;

public static class ManageTools
{
    // שלא כתוב כאן כלום מה זה אומר 
    // זה אומר שהוא נמצא בברירת מחדל כלומר הוא מוגדר כ private
    public static List<AttackTool> drons = new List<AttackTool>();
    public static List<AttackTool> fighterJets = new List<AttackTool>();
    public static List<AttackTool> artilleries = new List<AttackTool>();
    public static List<AttackTool> createAttackTolls = new List<AttackTool>();




    public static void showData()
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

        foreach (CreateAttackTolls item in createAttackTolls)
        {
            Console.WriteLine($"TEH ARTILLERY LIST" +
            $"name {item.InsertNameGun} efective against {item.SelectedEfective} type bomb {item.SelectedTypeBomb}" +
            $" activate by {item.SelectedActiveBy} count of ammo {item.AmountOfAmmunation}");
        }


    }
    

}