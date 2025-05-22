
using System.Collections.Generic;
using System.Dynamic;
using System.Security.AccessControl;
using System.Threading;
// אולי צריך לעשות פה מחלקת utility 
// 

public abstract class AttackTool 
{
    // איך אני עושה שמחלקה אחרת תירש רק את השורה היחידה הזאת שמלמטה
    Dictionary<int, string> effective = new Dictionary<int, string> { { 1, "Effective To Bulding" }, { 2, "Effective To Open Area" }, { 3, "Effective To Tunnel" } };
    Dictionary<int, string> active_by = new Dictionary<int, string> { { 1, "Active By Auto" }, { 2, " Active By Human" } };

    public string InsertNameGun { get; }

    // יצירת הפקודות geter ו seter
    public int SelectedEfective { get; set; }
    public string SelectedTypeBomb { get; set; }
    public int SelectedActiveBy { get; set; }
    public int AmountOfAmmunation { get; set; }




    // למה אני צריך את הדברים הללן 
    //nameKey;
    //effectiveKey;
    //bombKey;
    //activeKey;
    //ammo;

    public AttackTool(string nameKey, int effectiveKey,string bombKey, int activeKey, int ammo )
    {
        this.InsertNameGun =    nameKey;
        this.SelectedEfective = effectiveKey;
        this.SelectedTypeBomb = bombKey;
        this.SelectedActiveBy = activeKey;
        this.AmountOfAmmunation = ammo;
        
          }
}