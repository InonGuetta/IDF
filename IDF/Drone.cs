public class  Drone : AttackTool
{
    public Drone(string bombType)
        : base("Drone",2, bombType,1,3)
    {
        // ערכים חדשים שאני רוצה להוסיף לקונסטרקטור חוץ מערכי הקונסטרקטור שירשתי מהאב
    }
}