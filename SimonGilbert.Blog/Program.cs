using System;
using FluentValidation;
using SimonGilbert.Blog.Models;
using SimonGilbert.Blog.Validation;

namespace SimonGilbert.Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            var userAccount = new UserAccount
            {
                FirstName = "",
                Username = "@simon-gilbert_!?",
                EmailAddress = "hello_simongilbert.net",
                MobilePhoneNumber = "07890123456",
                DateOfBirth = new DateTime(2019, 11, 24),
            };

            var validator = new UserAccountValidator();

            validator.ValidateAndThrow(userAccount);
        }
    }
}
