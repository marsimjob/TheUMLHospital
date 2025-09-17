namespace Hospital
{
    public abstract class Resident : Person
    {
        public string ResidentProfession;
        public string ResidentShift;

        public Resident(Hospital residentHospital, Ward residentWard,
                string residentID, string residentName, string residentGender,
                string profession, string shift)
            : base(residentID, residentName, residentGender, residentHospital, residentWard)
        {
            this.ResidentProfession = profession;
            this.ResidentShift = shift;
        }

        public abstract void ClockIn();

        public abstract void ClockOut();
        }
}




