namespace _02.StudentsAndWorkers
{
    class Worker : Human
    {
        //Fields
        private const int workingDaysInWeek = 5;
        private double weekSalary;
        private int workHoursPerDay;

        //Constructors
        public Worker(string inputFirstName, string inputLastName, double inputWeekSalary, int inputWorkHoursPerDay) : base(inputFirstName, inputLastName)
        {
            this.WeekSalary = inputWeekSalary;
            this.WorkHoursPerDay = inputWorkHoursPerDay;
        }

        //Properties
        public double WeekSalary
        {
            get { return this.weekSalary; }
            private set { this.weekSalary = value; }
        }

        public int WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            private set { this.workHoursPerDay = value; }
        }

        //Methods
        public double MoneyPerHour()
        {
            double moneyPerDay = weekSalary / workingDaysInWeek;
            double moneyPerHour = moneyPerDay / workHoursPerDay;

            return moneyPerHour;
        }

        public override string ToString()
        {
            return base.ToString() + " - Salary: " + WeekSalary + " - HoursPerWeek: " + WorkHoursPerDay;
        }
    }
}
