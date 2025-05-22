using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF
{
    internal class program
    {
        static void Main(string[] args)
        {
            Artillery artliery = new Artillery();
            Idf idf = new Idf();
            CreateAttackTolls new_tool_01 = new CreateAttackTolls("s-400",1,"50 - kg",1,2);
            Drone drone01 = new Drone("20 - KG");
            
            idf.addTool(artliery);
            



        }
    }
}
