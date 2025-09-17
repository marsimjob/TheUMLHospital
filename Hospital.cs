namespace Hospital
{
    public class Hospital
    {
        public string HospitalName;
        public string HospitalLocation;
        public int HospitalBuildDate;
        public List<Patient> PatientIdList = new List<Patient>();
        public List<Resident> ResidentIDList = new List<Resident>();

        public Hospital(string hospitalName, string hospitalLocation, int hospitalDate)
        {
            HospitalName = hospitalName;
            HospitalLocation = hospitalLocation;
            HospitalBuildDate = hospitalDate;
        }

        public void CloseHospital()
        {
            Console.WriteLine("Hopsital is closed.");
        }

        public void OpenHopsital()
        {
            Console.WriteLine("Hospital is open!");
        }
    }
}
