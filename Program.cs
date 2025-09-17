
using System.Diagnostics;

namespace Hospital
{
    internal class Program
    {
        // Hospital declaration
        static Hospital hospital = new Hospital("New Spring Hospital", "Ohio State", 1890);
        
        // Ward declarations
        static  Ward ward1 = new Ward(3, Ward.Wards[2]);
        static Ward ward2 = new Ward(1, Ward.Wards[0]);

        // Doctor declarations
        static Doctor dr1 = new Doctor(hospital, ward1, "DR-0129", "Jeremy Herris", "Male", "Doctor", "Available");
        static Doctor dr2 = new Doctor(hospital, ward2, "DR-0130", "Emily Carter", "Female", "Doctor", "Available");
        static Doctor dr3 = new Doctor(hospital, ward1, "DR-0131", "Michael Johnson", "Male", "Doctor", "Unavailable");

        // Nurse declarations
        static Nurse nurse1 = new Nurse(hospital, ward1, dr1, "NR-041", "Alice Smith", "Female", "Morning", "Nurse");
        static Nurse nurse2 = new Nurse(hospital, ward2, dr2, "NR-032", "Bob Johnson", "Male", "Afternoon", "Nurse");
        static Nurse nurse3 = new Nurse(hospital, ward1, dr1, "NR-103", "Jonas Torp", "Male", "Night", "Nurse");
        static Nurse nurse4 = new Nurse(hospital, ward1, dr3, "NR-004", "Diana Brown", "Female", "Morning", "Nurse");
        static Nurse nurse5 = new Nurse(hospital, ward2, dr2, "NR-555", "Evan White", "Male", "Afternoon", "Nurse");

        // Patient Declration
        static Patient patient1 = new Patient(hospital, ward1, "Alice Smith", "P-001", "Female", dr1.Id, "Stomach cramps", "Yes");
        static Patient patient2 = new Patient(hospital, ward2, "Albert Trevor", "P-002", "Male", dr2.Id, "Fever", "No");
        static Patient patient3 = new Patient(hospital, ward1, "Charlie Lee", "P-003", "Male", dr3.Id, "Broken leg", "Yes");

        // Main method
        static void Main()
        {
            // Open Hopsital
            hospital.OpenHopsital();
            Console.WriteLine();
            // Clocking in
            dr3.ClockIn();
            // Assigning nurse mates
            nurse1.SetNurseMate(nurse3);
            nurse2.SetNurseMate(nurse5);
            nurse4.SetNurseMate(nurse1);
            Console.WriteLine();
            // Print patient info (first from patient, then from nurse)
            patient1.PrintPatientInfo();
            patient3.Log.AddLog($"This is a log entry for {patient3.Name}'s journal!"); // Add a log entry, which will modify the outcome
            patient3.Log.AddLog($"{patient3.Name} has experienced less swelling over the last 2 days."); // Another one.
            nurse3.CheckRecords(patient3);
            Console.WriteLine();
            // Doctor request transfer between wards
            dr2.RequestTransfer(patient2, ward1);
            Console.WriteLine();
            Console.WriteLine($"Ward name of ward1 is: {ward1.WardName}");
            Console.WriteLine();
            // Doctor diagnosis
            dr1.MakeDiagnosis(patient1);
            Console.WriteLine();
            // Prescribe medicine
            dr2.PrescribeMedication(patient1);
            Console.WriteLine();
            // Nurse helps her assigned doctor
            nurse3.AssistDoctor();
            Console.WriteLine();
            // Clocking out
            nurse5.ClockOut();
            Console.WriteLine();
            // Close Hospital
            hospital.CloseHospital();
        }

    }
}
