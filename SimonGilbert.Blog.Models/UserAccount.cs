using System;

namespace SimonGilbert.Blog.Models
{
    public class UserAccount
    {
        public string FirstName { get; set; }

        public string Username { get; set; }

        public string EmailAddress { get; set; }

        public string MobilePhoneNumber { get; set; }

        public DateTime DateOfBirth { get; set; }
    }
}