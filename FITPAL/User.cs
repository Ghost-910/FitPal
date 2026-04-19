using System;

namespace FITPAL.Models
{
    public abstract class Person
    {
        private string _name;
        private int _age;
        private string _gender;

        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name cannot be empty.");
                _name = value;
            }
        }

        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 1 || value > 120)
                    throw new ArgumentOutOfRangeException(nameof(value), "Age must be between 1 and 120.");
                _age = value;
            }
        }

        public string Gender
        {
            get { return _gender; }
            set
            {
                if (value != "Male" && value != "Female")
                    throw new ArgumentException("Gender must be Male or Female.");
                _gender = value;
            }
        }

        public Person(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public abstract string GetSummary();

        public abstract double CalculateDailyCalories(FitnessGoal goal = FitnessGoal.Maintenance);
    }

    public class User : Person
    {
        private string _username;
        private string _password;

        public string Username
        {
            get { return _username; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Username cannot be empty.");
                _username = value;
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 6)
                    throw new ArgumentException("Password must be at least 6 characters.");
                _password = value;
            }
        }

        public User(string username, string password, string name, int age, string gender)
            : base(name, age, gender)
        {
            Username = username;
            Password = password;
        }

        public override string GetSummary()
        {
            return $"User: {Name} | Age: {Age} | Gender: {Gender}";
        }

        public override double CalculateDailyCalories(FitnessGoal goal = FitnessGoal.Maintenance)
        {
            return 2000;
        }
    }
}