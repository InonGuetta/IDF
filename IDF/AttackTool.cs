
using System.Collections.Generic;
using System.Dynamic;
using System.Security.AccessControl;

// תבנית כללית ליצירת נשק 
public class AttackTool
{
    
    Dictionary<int, string> effective = new Dictionary<int, string> { { 1, "Effective To Bulding" }, { 2, "Effective To Open Area" }, { 3, "Effective To Tunnel" } };
    Dictionary<int, string> active_by = new Dictionary<int, string> { { 1, "Active By Auto" }, { 2, " Active By Human" } };


    // יצירת הפקודות geter ו seter
    string insertNameGun { get; set; }
    public int SelectedEfective { get; set; }
    public string SelectedTypeBomb { get; set; }
    public int SelectedActiveBy { get; set; }
    public int AmountOfAmmunation { get; set; }


    // קונסטרקטור
    public AttackTool(string nameKey, int effectiveKey,string bombKey, int activeKey, int ammo )
    {
        insertNameGun = nameKey;
        SelectedEfective = effectiveKey;
        SelectedTypeBomb = bombKey;
        SelectedActiveBy = activeKey;
        AmountOfAmmunation = ammo;

    }
}