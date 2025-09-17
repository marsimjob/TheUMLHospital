namespace Hospital
{
    public class Journal
    {
        public List<string> LogBook = new List<string>();
        public string Diagnosis = "";
        public string PreviousVisits = "";
        public void AddLog(string logMessage)
        {
            string newLogMessage = logMessage;
            LogBook.Add(newLogMessage);
        }

        public string GetLogAtIndex(int index)
        {
            if (index <= 0)
            {

                string noResponse =
                    "Currently no log on this patient";
                return noResponse;
                    }
            else
                return LogBook[index];
        }

        public int ReturnLogCount()
        {
            return LogBook.Count;
        }
    }
}