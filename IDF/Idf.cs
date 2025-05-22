using System;
using System.Collections.Generic;

public class Idf
{
    private DateTime sinceIdf = new DateTime(1948, 5, 26);
    private string chiefCommander = "Eyal Zamir";



    List<AttackTool> attackTools = new List<AttackTool>();
    public void addTool(AttackTool tools)
    {
        attackTools.Add(tools);
    }

}
