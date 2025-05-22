using System.Security.AccessControl;

public class CreateNewTool : AttackTool
{
    public CreateNewTool(string nameKey, int effectiveKey, string bombKey, int activeKey, int ammo)
        : base(nameKey, effectiveKey, bombKey, activeKey, ammo)
    {
        // פה ניתן להוסיף שדות חדשים שאנחנו רוצים להודים חוץ ממה שקיבלנו מהאב
    }



}