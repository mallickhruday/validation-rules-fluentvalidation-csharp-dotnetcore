using System;
using FluentValidation;
using SimonGilbert.Blog.Models;

namespace SimonGilbert.Blog.Validation
{
    public class UserAccountAgeValidator : AbstractValidator<UserAccount>
    {
        public UserAccountAgeValidator()
        {
            RuleFor(x => x.DateOfBirth)
                .Must(IsOver18)
                .WithMessage("You must be over 18 years old.");
        }

        private bool IsOver18(DateTime dateOfBirth)
        {
            return (DateTime.Now.AddYears(-18) >= dateOfBirth);
        }
    }
}