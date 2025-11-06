namespace ClassesAndObjects
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        private double _salary { get; set; }

        public void setSalary(double salary)
        {
            _salary = salary;
        }
        public double getSalary()
        {
            return _salary;
        }

        public string getFullName()
        {
            return $"{FirstName} {LastName}";
        }
        public string getFullName(string middleName)
        {
            return $"{FirstName} {middleName} {LastName}";
        }
    }
}
