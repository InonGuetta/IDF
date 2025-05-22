
    public class Drone : AttackTool
    {
        // ערכים חדשים שאני רוצה להוסיף לקונסטרקטור חוץ מערכי הקונסטרקטור שירשתי מהאב
        public Drone(string bombType)
            : base("Drone", 2, bombType, 1, 3)
        {

        }

    }
