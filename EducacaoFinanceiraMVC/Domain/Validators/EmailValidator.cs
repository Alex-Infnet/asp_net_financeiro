using System;
using System.ComponentModel.DataAnnotations;
using Domain.ViewModels;

namespace Domain.Validators
{
    public class EmailValidator : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var FaleConosco = (FaleConoscoViewModel)validationContext.ObjectInstance;
            if (FaleConosco.Email == null || FaleConosco.Email.Length < 3)
            {
                return new ValidationResult(ErrorMessage);
            }
            var extensionMail = FaleConosco.Email.Substring(FaleConosco.Email.Length - 3, 3);
            if (extensionMail != ".br")
            {
                return new ValidationResult(ErrorMessage);
            }
            return ValidationResult.Success;
        }
    }
}

