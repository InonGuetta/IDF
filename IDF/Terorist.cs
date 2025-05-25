
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Xml.Linq;


public class Terorist
{
    public string name;
    public int rank;
    public bool status;
    public string weapon;
    public Terorist(string name, int rank, bool status, string weapon, Hamas hamas)
    {
        this.name = name;
        this.rank = rank;
        this.status = status;
        this.weapon = weapon;
        Produce_alone(hamas);
    }
     public void Produce_alone( Hamas hamas)
    {
        hamas.add_terorist(this);

    }
}
    
    //private void creator(List<Terorist> list_terorist)
    //{
    //    List<string> names = new List<string>() {"Ahmed", "Fatima", "Omar", "Layla", "Hassan", "Nour", "Ali", "Aisha", "Khalid", "Zainab"};
    //    List<string> weapon = new List<string>() { "ak47", "m16", "knife","gun" };
    //    for (int i=0;i<10;i++)
    //    {
    //        Random rnd = new Random();
    //        int randomInt = rnd.Next(1, 5);
    //        bool randomBool = rnd.Next(0, 2) == 0;
    //        string randomName = names[rnd.Next(names.Count)];
    //        string randweapon = weapon[rnd.Next(weapon.Count)];
    //        Terorist a = new Terorist(randomName, randomInt, randomBool, randweapon);
    //        list_terorist.Add(a);
    //    }
//}
//}





