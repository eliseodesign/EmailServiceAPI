using EmailServiceApi.DTOs;
using FluentValidation;

namespace EmailServiceApi.Validators
{
    public class EmailValidator : AbstractValidator<EmailDTO>
    {
        public EmailValidator(){
            RuleFor(x=>x.To).NotNull().EmailAddress().WithMessage("To no es del tipo correcto");
            RuleFor(x=>x.Content).NotNull().WithMessage("Content es requerido");
            RuleFor(x=>x.Subject).NotNull().WithMessage("Subjet no es del tipo correcto");
        }
    }
}