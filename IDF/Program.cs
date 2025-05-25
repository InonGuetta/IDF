//namespace IDF
//{
//    using System;
//    using System.Collections.Generic;
//    using System.Linq;
//    using System.Text;
//    using System.Threading.Tasks;





using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        CreateAttackTolls new_tool_01 = new CreateAttackTolls("s-400", 1, "50 - kg", 1, 2);
        ManageTools.createAttackTolls.Add(new_tool_01);
        FighterJet f16_01 = new FighterJet("500 kg");
        ManageTools.fighterJets.Add(f16_01);
        Drone drone01 = new Drone("20 - KG");
        ManageTools.drons.Add(drone01);
        Artillery artillery01 = new Artillery(30);
        ManageTools.artilleries.Add(artillery01);
        
        Idf idf = new Idf();
        msg aman_msg = new msg();
        Hamas hamas = new Hamas();
        List<string> names = new List<string>() { "Ahmed", "Fatima", "Omar", "Layla", "Hassan", "Nour", "Ali", "Aisha", "Khalid", "Zainab" };
        List<string> weapon = new List<string>() { "ak47", "m16", "knife", "gun" };
        Random rnd = new Random();
        for (int i = 0; i < 10; i++)
        {
            
            int randomInt = rnd.Next(1, 5);
            bool randomBool = rnd.Next(0, 2) == 0;
            string randomName = names[rnd.Next(0,names.Count)];
            string randweapon = weapon[rnd.Next(0,weapon.Count)];
            Terorist a = new Terorist(randomName, randomInt, randomBool, randweapon);
            a.Produce_alone(hamas);
           
        }
        

    }
    
}