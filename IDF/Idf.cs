using System;
using System.Collections.Generic;
using System.Net;

public class Idf
{
    private DateTime sinceIdf = new DateTime(1948, 5, 26);
    private string chiefCommander = "Eyal Zamir";
    

    Dictionary<int, List<AttackTool>> attackTools = new Dictionary<int, List<AttackTool>> {
        {0, ManageTools.drons },
        {1, ManageTools.artilleries },
        {2, ManageTools.createAttackTolls },
        {3, ManageTools.fighterJets }

    };




    public void addTool(AttackTool tools)
    {

    }

}