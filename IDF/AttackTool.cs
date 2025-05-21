
using System.Collections.Generic;
using System.Dynamic;
using System.Security.AccessControl;

// תבנית כללית ליצירת נשק 
public abstract class AttackTool
{
    
    Dictionary<int, string> effective = new Dictionary<int, string> { { 1, "Effective To Bulding" }, { 2, "Effective To Open Area" }, { 3, "Effective To Tunnel" } };
    Dictionary<int, string> active_by = new Dictionary<int, string> { { 1, "Active By Auto" }, { 2, " Active By Human" } };


    // יצירת הפקודות geter ו seter
    protected string insertNameGun { get; set; }
    protected int SelectedEfective { get; set; }
    protected string SelectedTypeBomb { get; set; }
    protected int SelectedActiveBy { get; set; }
    protected int AmountOfAmmunation { get; set; }


    // קונסטרקטור
    protected AttackTool(string nameKey, int effectiveKey,string bombKey, int activeKey, int ammo )
    {
        insertNameGun = nameKey;
        SelectedEfective = effectiveKey;
        SelectedTypeBomb = bombKey;
        SelectedActiveBy = activeKey;
        AmountOfAmmunation = ammo;

    }
}