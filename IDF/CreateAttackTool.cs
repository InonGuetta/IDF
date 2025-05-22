using System.Collections.Generic;

public class CreateAttackTolls : AttackTool
{

    public CreateAttackTolls(string nameKey, int effectiveKey, string bombKey, int activeKey, int ammo)
        : base (nameKey, effectiveKey, bombKey, activeKey, ammo)
    {
        // פה יש עוד ערכים שניתן להוסיף לקונסטרקטור של הבן

    }



    //List<AttackTool> attack_tolls = new List<AttackTool>();

    //    AttackTool tool = new AttackTool("NEW GUN",1,"BOMB MINI",2,30);
    //    attack_tolls.Add(tool);
    //public void AddTool()
    //{

    //}


}
