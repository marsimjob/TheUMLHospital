namespace Hospital
{
    public class Patient : Person
    {
        public Journal Log = new Journal();
        private string DoctorID;

        public Patient(Hospital hospital, Ward ward, string id, string name, string gender, string drID, string diagnosis, string previousVisits)
      : base(name, id, gender, hospital, ward)   // Person Constructor
        {
           DoctorID = drID;
           Log.Diagnosis = diagnosis;
           Log.PreviousVisits = previousVisits;
        }

        public void Admit(Doctor assignedDr)
        {
            Console.WriteLine($"{Name} was admited to {this.AssignedHospital.HospitalName}");
            assignedDr.Patients.Add(this);
            this.AssignedHospital.PatientIdList.Add(this);
        }

        public void Discharge(Doctor assignedDr)
        {
            Console.WriteLine($"{Name} has been discharged!");
            assignedDr.Patients.Remove(this);
            this.AssignedHospital.PatientIdList.Remove(this);
        }

        public void PrintPatientInfo()
        {
            Console.WriteLine("---- PATIENT INFORMATION ----");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Patient ID: {Id}");
            Console.WriteLine($"Ward: {AssignedWard}");
            Console.WriteLine($"Doctor ID: {DoctorID}");
            Console.WriteLine($"Previous visits: {Log.PreviousVisits}");

            Console.WriteLine("---- HOSPITAL INFORMATION ----");
            Console.WriteLine($"Hospital Name: {AssignedHospital.HospitalName}");
            Console.WriteLine($"Hospital Location: {AssignedHospital.HospitalLocation}");
            Console.WriteLine($"Hospital Date: {AssignedHospital.HospitalBuildDate}");

            Console.WriteLine("---- LOG BOOK ----");
            if (this.Log != null && Log.ReturnLogCount() > 0)
            {
                for (int i = 0; i < Log.ReturnLogCount(); i++)
                {
                    Console.WriteLine($"Log {i + 1}: {Log.LogBook[i]}");
                }
            }
            else
            {
                Console.WriteLine("No logs available.");
            }
        
            Console.WriteLine("---- DIAGNOSIS ----");
            Console.WriteLine($"Diagnosis: {Log.Diagnosis}");
        }
    }
}
