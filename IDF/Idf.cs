using System;
using System.Collections.Generic;
using System.Net;

public class Idf
{
    private DateTime sinceIdf = new DateTime(1948, 5, 26);
    private string chiefCommander = "Eyal Zamir";

    Dictionary<string, List<AttackTool>> attackTools = new Dictionary<string, List<AttackTool>> {
        {"drons", ManageTools.drons },
        {"artilleries", ManageTools.artilleries },
        {"createAttackTolls", ManageTools.createAttackTolls },
        {"FighterJet", ManageTools.fighterJets }
    
    };




    public void addTool(AttackTool tools)
    {
        
    }

}
