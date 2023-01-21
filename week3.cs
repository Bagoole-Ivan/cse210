public class Job
    {
        public string _jobTitle = "Web Developer and Designer";
        public string _company = "Moroni Technologies Ltd";
        public int _startYear = 2019;
        public string _endYear = "Current";

        public void Display()
        {
            Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
        }
}

public class Resume
    {
        public string _jobTitle = "Data Analyst";
        public string _company = "Explore It Technologies Ltd";
        public int _startYear = 2017;
        public int _endYear = 2019;

        public string _jobTitle = "Missionary";
        public string _company = "The Chruch of Jesus Christ of Latter Day Saints";
        public int _startYear = 2015;
        public int _endYear = 2017;

        public string _jobTitle = "Mobile Money Agent";
        public string _company = "Sagma Enterprises Ltd";
        public int _startYear = 2014;
        public int _endYear = 2015;

        public void Display()
        {
            Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
        }
}