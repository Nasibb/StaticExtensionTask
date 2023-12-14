using System;
using System.Security.Principal;
using StaticExtensionTask.Domain.Helpers;
using StaticExtensionTask.Domain.Interfaces;

namespace StaticExtensionTask.Domain.Models
{
	public class User: IAccount
	{
        private static int _id;
		public int Id { get;}
		public string Fullname { get; set; }
		public string Email { get; set; }
        private string _password;
		public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (PasswordChecker(value))
                {
                    _password = value;
                    Console.WriteLine(ErrorMessage.SuccessMessage);
                }
                else
                {
                    Console.WriteLine(ErrorMessage.FailMessage);
                }
                
            }
        }

        public User(string email,string password)
        {
            Id = ++_id;
            Email = email;
            Password = password;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"{Id} {Fullname} {Email}");
        }

        public bool PasswordChecker(string password)
        {
            if (password.Length < 8) return false;
            bool isUpper = false;
            bool isLower = false;
            bool isDigit = false;
            foreach (var c in password)
            {
                if (char.IsUpper(c))
                {
                    isUpper = true;
                    continue;
                }
                if (char.IsLower(c))
                {
                    isLower = true;
                    continue;
                }
                if (char.IsDigit(c))
                {
                    isDigit = true;
                }
            }
            return isUpper && isLower && isDigit;
        }
    }
}

