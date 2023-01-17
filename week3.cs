public class Job
    {
        public string _jobTitle = "Web Developer and Designer";
        public string _company = "Moroni Technologies Ltd";
        public int _startYear = 2019;
        public int _endYear = 2022;

        public void Display()
        {
            Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
        }
}

public class Resume
    {
        public string _jobTitle;
        public string _company;
        public int _startYear;
        public int _endYear;

        public void Display()
        {
            Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
        }
}