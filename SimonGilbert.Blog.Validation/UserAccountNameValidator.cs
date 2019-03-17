using FluentValidation;
using SimonGilbert.Blog.Models;

namespace SimonGilbert.Blog.Validation
{
    public class UserAccountNameValidator : AbstractValidator<UserAccount>
    {
        public UserAccountNameValidator()
        {
            RuleFor(x => x.FirstName)
                .NotNull()
                .Length(2, 50)
                .WithMessage("Please specify a first name value between 2 and 50 characters.");
        }
    }
}