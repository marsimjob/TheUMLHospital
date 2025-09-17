namespace Hospital
{
    public abstract class Person
    {
        public string Id;
        public string Name;
        public string Gender;

        public Hospital AssignedHospital;
        public Ward AssignedWard;

        public Person(string id, string name, string gender, Hospital hospital, Ward ward)
        {
            Id = id;
            Name = name;
            Gender = gender;
            AssignedHospital = hospital;
            AssignedWard = ward;
        }
    }
}