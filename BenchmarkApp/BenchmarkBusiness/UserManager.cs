using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using BenchmarkData;

namespace BenchmarkBusiness
{
    public class UserManager
    {
        public User SelectedUser { get; set; }

        public void SetSelectedUser(object selectedItem)
        {
            SelectedUser = (User)selectedItem;
        }

        public List<User> RetrieveAll()
        {
            using (var db = new BenchmarkContext())
            {
                return db.Users.ToList();
            }
        }

        public void Create(int userId, string userName, string firstName, string lastName, string password, bool accountType)
        {
            var newUser = new User() { UserId = userId, UserName = userName, FirstName = firstName, LastName = lastName, Password = password, AccountType = accountType };
            using (var db = new BenchmarkContext())
            {
                if (db.Users.Where(u => u.UserName == userName).Count()==1)
                {
                    throw new 
                }
                else 
                {
                    db.Users.Add(newUser);
                    db.SaveChanges();
                }
            }
        }

        public bool Update(int userId, string userName, string firstName, string lastName, string password)
        {
            using (var db = new BenchmarkContext())
            {
                var user = db.Users.Where(u => u.UserId == userId).FirstOrDefault();
                if (user == null)
                {
                    Debug.WriteLine($"User {userId} not found");
                    return false;
                }
                user.UserName = userName;
                user.Password = password;
                user.FirstName = firstName;
                user.LastName = lastName;
                // write changes to database
                try
                {
                    db.SaveChanges();
                    SelectedUser = user;
                }
                catch (Exception e)
                {
                    Debug.WriteLine($"Error updating {userId}");
                    return false;
                }
            }
            return true;
        }

        public bool Delete(int userId)
        {
            using (var db = new BenchmarkContext())
            {
                var user = db.Users.Where(u => u.UserId == userId).FirstOrDefault();
                if (user == null)
                {
                    Debug.WriteLine($"User {userId} not found");
                    return false;
                }
                db.Users.RemoveRange(user);
                db.SaveChanges();
            }
            return true;
        }

        public bool UserCheck(string userName, string password)
        {
            var users = RetrieveAll();
            var existingUser = users.Where(u => u.UserName == userName).FirstOrDefault();
            if (existingUser != null)
            {
                if (existingUser.Password == password)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
