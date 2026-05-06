using System;
using System.Collections.Generic;
using System.Linq;
using fitpal.Models;

namespace fitpal.Services
{
    
    public class UserRepository
    {
        private static UserRepository _instance;
        private readonly List<FitnessUser> _users;

        
        public static UserRepository Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserRepository();
                return _instance;
            }
        }

        private UserRepository()
        {
            _users = new List<FitnessUser>();
            SeedDemoUser();
        }

        private void SeedDemoUser()
        {
            var demo = new FitnessUser("demo", "demo123", "Demo User", 25, "Male",
                                       75.0, 175.0, FitnessGoal.WeightLoss);
            demo.LogProgress(75.0, "Starting point");
            _users.Add(demo);
        }

        public bool Register(FitnessUser user)
        {
            if (_users.Any(u => u.Username == user.Username))
                return false;
            _users.Add(user);
            return true;
        }

        public FitnessUser Login(string username, string password)
        {
            return _users.FirstOrDefault(
                u => u.Username == username && u.Password == password);
        }

        public bool UsernameExists(string username)
        {
            return _users.Any(u => u.Username == username);
        }

        public void UpdateUser(FitnessUser updated)
        {
            var existing = _users.FirstOrDefault(u => u.Username == updated.Username);
            if (existing != null)
            {
                int index = _users.IndexOf(existing);
                _users[index] = updated;
            }
        }
    }
}
