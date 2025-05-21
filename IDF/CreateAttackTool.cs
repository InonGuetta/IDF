using System.Collections.Generic;

public class CreateAttackTolls
{
    List<AttackTool> attack_tolls = new List<AttackTool>();

    public void AddTool()
    {
        AttackTool tool = new AttackTool("NEW GUN",1,"BOMB MINI",2,30);
        attack_tolls.Add(tool);

    }
}