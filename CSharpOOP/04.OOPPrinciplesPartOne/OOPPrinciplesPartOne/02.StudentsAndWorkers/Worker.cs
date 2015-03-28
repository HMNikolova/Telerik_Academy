namespace _02.StudentsAndWorkers
{
    class Worker : Human
    {
        public decimal WeekSalary { get; private set; }

        public int WorkHoursPerDay { get; private set; }

        public Worker(string fName, string lName, decimal weekSalary, int workDayHours) : base(fName, lName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workDayHours;
        }

        public decimal MoneyPerHour()
        {
            return this.WeekSalary / (5m * WorkHoursPerDay);
        }
    }
}
