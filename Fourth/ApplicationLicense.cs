namespace Fourth
{
    public class ApplicationLicense
    {
        public Level Level { get; set; }
        public string TrialKey { get; set; }
        public string ProKey { get; set; }
        public string Status { get { return $"Ви користуетесь {Level.ToString()} версією"; } }

        public ApplicationLicense()
        {
            TrialKey = 12345.ToString();
            ProKey = 54321.ToString();
            Level = Level.Free;
        }

        public bool AllowTrial(string key)
        {
            if (key == TrialKey)
            {
                Level = Level.Trial;
                return true;
            }

            return false;
        }

        public void AllowCommon()
        {
            Level = Level.Free;
        }

        public bool AllowPro(string key)
        {
            if (key == ProKey)
            {
                Level = Level.Pro;
                return true;
            }

            return false;
        }

    }
}