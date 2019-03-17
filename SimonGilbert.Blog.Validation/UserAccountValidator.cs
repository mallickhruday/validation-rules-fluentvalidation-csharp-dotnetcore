using FluentValidation;
using SimonGilbert.Blog.Models;

namespace SimonGilbert.Blog.Validation
{
    public class UserAccountValidator : AbstractValidator<UserAccount>
    {
        public UserAccountValidator()
        {
            Include(new UserAccountNameValidator());
            Include(new UserAccountTechDetailsValidator());
            Include(new UserAccountAgeValidator());
        }
    }
}