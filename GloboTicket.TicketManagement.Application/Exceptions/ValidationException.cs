using System;
using System.Collections.Generic;
using FluentValidation.Results;

namespace GloboTicket.TicketManagement.Application.Exceptions
{
    public class ValidationException : ApplicationException
    {
        public ValidationException(ValidationResult validationResult)
        {
            ValidationErrors = new List<string>();

            foreach (var validationError in validationResult.Errors) ValidationErrors.Add(validationError.ErrorMessage);
        }

        public List<string> ValidationErrors { get; set; }
    }
}