namespace Hospital
{
    public class Nurse : Resident
    {
        public Doctor AssignedDoctor;
        public List<Nurse> TeamMates = new List<Nurse>();

        public Nurse(Hospital hospital, Ward residentWard, Doctor assignedDoctor, string residentID, 
            string residentName, string residentGender, string residentShift, string residentProfession = "Nurse")
    : base(hospital, residentWard, residentID, residentName, residentGender, residentProfession, residentShift)
        {
            AssignedDoctor = assignedDoctor;
        }

        public void AssignDoctor(Doctor drToAssign)
        {
            AssignedDoctor = drToAssign;
            Console.WriteLine($"Dr {drToAssign.Name} is {Name}'s new assigned doctor");
        }

        public void AssistDoctor()
        {
            Console.WriteLine($"{Name} helps out their assigned doctor-- Dr {AssignedDoctor.Name}!");
        }
        
        public void SetNurseMate(Nurse newNurse)
        {
            TeamMates.Add(newNurse);
            newNurse.TeamMates.Add(this);
            Console.WriteLine($"{newNurse.Name} has been added to {this.Name}'s team and viceversa");
        }
        public void CheckRecords(Patient patient)
        {
            patient.PrintPatientInfo();
        }

        public void AdjustReconrds(Patient patient)
        {
            // TODO : ADJUST THE PATIENTS RECORD
            Console.WriteLine("Nurse adjusts record for patient" + patient.Name);
        }

        public override void ClockIn()
        {
            Console.WriteLine("Nurse has clocked in!");
        }
        public override void ClockOut()
        {
            Console.WriteLine("Nurse has clocked out!");
        }
    }
}
