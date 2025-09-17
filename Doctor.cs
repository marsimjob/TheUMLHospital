namespace Hospital
{
    public class Doctor : Resident
    {
        public List<Patient> Patients = new List<Patient>();
        public string Status;

        public Doctor(Hospital hospital, Ward residentWard, string residentID, string residentName, 
            string residentGender, string residentShift, string residentProfession = "Doctor", string status = "Available")
            : base(hospital, residentWard, residentID, residentName, residentGender, "Doctor", residentShift)
        {
            this.Status = status;
        }

        public void MakeDiagnosis(Patient patient)
        {
            int latestLogIndex = patient.Log.ReturnLogCount();
            Console.WriteLine($"Dr {Name} takes a close look at their patient.");
            Console.WriteLine($"Patient {patient.Name}'s log says: {patient.Log.GetLogAtIndex(latestLogIndex)}");

            Console.WriteLine($"Patient diagnosis is: {patient.Log.Diagnosis}");
        }

        public void PrescribeMedication(Patient patient)
        {
            Console.WriteLine($"Dr {Name} prescribes medicine to {patient.Name}");
        }

        public void RequestTransfer(Patient patient, Ward ward) 
        {
            Console.WriteLine($"Dr {Name} request {patient.Name} to be transferred to {ward.WardName} {ward.WardNumber}");
        }
        public override void ClockIn()
        {
            Console.WriteLine("Doctor has clocked in!");
        }
        public override void ClockOut()
        {
            Console.WriteLine("Doctor has clocked out!");
        }
    }
}




