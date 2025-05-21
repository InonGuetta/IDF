public class FighterJet : AttackTool
{
    public FighterJet(string bombType)
        // לא להוסיף את הפסיק נקודה אחרי השורה של base
        : base("Fighter Jet", 1, bombType, 2, 8)
    {

    }


}