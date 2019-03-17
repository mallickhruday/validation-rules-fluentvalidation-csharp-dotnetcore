using System;
using FluentValidation;
using SimonGilbert.Blog.Models;
using SimonGilbert.Blog.Validation;
using Xunit;

namespace SimonGilbert.Blog.Tests
{
    public class UserAccountValidatorTests
    {
        [Fact]
        public void User_Account_Is_Valid()
        {
            var expectedIsValid = true;

            var userAccount = new UserAccount
            {
                FirstName = "Simon",
                Username = "simongilbert",
                EmailAddress = "hello@simongilbert.net",
                MobilePhoneNumber = "+447890123456",
                DateOfBirth = new DateTime(1987, 11, 24),
            };

            var validator = new UserAccountValidator();

            var validationResult = validator.Validate(userAccount);

            Assert.Equal(expectedIsValid, validationResult.IsValid);
        }

        [Fact]
        public void User_Account_Is_Not_Valid()
        {
            var expectedIsValid = false;

            var userAccount = new UserAccount
            {
                FirstName = "",
                Username = "@simon-gilbert_!?",
                EmailAddress = "hello_simongilbert.net",
                MobilePhoneNumber = "07890123456",
                DateOfBirth = new DateTime(2019, 11, 24),
            };

            var validator = new UserAccountValidator();

            var validationResult = validator.Validate(userAccount);

            Assert.Equal(expectedIsValid, validationResult.IsValid);
        }
    }
}

