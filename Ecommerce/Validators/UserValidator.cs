using Ecommerce.Model;
using FluentValidation;

namespace Ecommerce.Validators;

public class UserValidator : AbstractValidator<User>
{
    public void Validate()
    {
        RuleFor(u => u.Email)
            .NotEmpty()
            .EmailAddress()
            .WithMessage("Invalid email address");

        RuleFor(u => u.Password)
            .NotEmpty()
            .MinimumLength(8)
            .MaximumLength(20)
            .WithMessage("Password must be between 8 and 20 characters");

        RuleFor(u => u.Role)
            .NotEmpty()
            .MaximumLength(20)
            .WithMessage("Role is required");
    }
}
