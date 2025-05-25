using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace IDF
{
    public class commander
    {
        public void manu()
        {
            bool commander = true;
            bool weppon = true;
            Hamas hamas = new Hamas();
            msg aman_msg = new msg();
            while (commander)
            {
                Console.WriteLine("CHOOSE A TERORIST 0-4");
                int number = int.Parse(Console.ReadLine());
                if (hamas.list_terorist[number].status == true)
                {
                    Console.WriteLine("CHOOSE A TOOL 0 -  3");
                    int number_weppon = int.Parse(Console.ReadLine());
                    if (number_weppon == 0)
                    {

                        if (ManageTools.drons.Any(tool => tool.AmountOfAmmunation > 0))
                        {
                            Console.WriteLine("the attack succsesed ");
                            ManageTools.drons.First(t => t.AmountOfAmmunation > 0).AmountOfAmmunation--;
                            hamas.list_terorist[number].status = false;
                            aman_msg.msgList($"the terorist{hamas.list_terorist[number]}Dead by Drone");
                        }
                        else
                        {
                            Console.WriteLine("ammo finish");
                        }

                    }
                    else if (number_weppon == 1)
                    {
                        if (ManageTools.drons.Any(tool => tool.AmountOfAmmunation > 0))
                        {
                            Console.WriteLine("the attack succsesed ");
                            ManageTools.drons.First(t => t.AmountOfAmmunation > 0).AmountOfAmmunation--;
                            hamas.list_terorist[number].status = false;
                            aman_msg.msgList($"the terorist{hamas.list_terorist[number]}Dead by fighterJets ");
                        }
                        else
                        {
                            Console.WriteLine("ammo finish");
                        }

                    }
                    else if (number_weppon == 2)
                    {
                        if (ManageTools.drons.Any(tool => tool.AmountOfAmmunation > 0))
                        {
                            Console.WriteLine("the attack succsesed ");
                            ManageTools.drons.First(t => t.AmountOfAmmunation > 0).AmountOfAmmunation--;
                            hamas.list_terorist[number].status = false;
                            aman_msg.msgList($"the terorist{hamas.list_terorist[number]}Dead by fighterJets ");
                        }
                        else
                        {
                            Console.WriteLine("ammo finish");
                        }

                    }


                }
            }
        }
    }
}

//public static List<AttackTool> drons = new List<AttackTool>();
//public static List<AttackTool> fighterJets = new List<AttackTool>();
//public static List<AttackTool> artilleries = new List<AttackTool>();
//public static List<AttackTool> createAttackTolls = new List<AttackTool>();

