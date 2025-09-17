namespace Hospital
{
    public class Ward
    {
        public int WardNumber;
        public string WardName;
        public static string[] Wards = {
        "Children's Ward",
        "Neurologic Ward",
        "Surgical Ward",
        "Cardiac Ward"
        };
        public Ward(int WardNumber, string WardName)
        {
            this.WardNumber = WardNumber;
            this.WardName = WardName;
        }
    }
}
