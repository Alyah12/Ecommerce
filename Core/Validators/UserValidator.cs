using Ecommerce.Entities;
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

        RuleFor(u => u.Age)
            .NotEmpty()
            .GreaterThan(18)
            .WithMessage("Age must be greater than 18");

        RuleFor(u => u.Role)
            .NotEmpty()
            .MaximumLength(20)
            .WithMessage("Role is required");
    }
}
