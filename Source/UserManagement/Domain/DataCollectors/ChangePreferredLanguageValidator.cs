/*---------------------------------------------------------------------------------------------
 *  Copyright (c) The International Federation of Red Cross and Red Crescent Societies. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

using Concepts.DataCollectors;
using Dolittle.Commands.Validation;
using FluentValidation;

namespace Domain.DataCollectors
{
    public class ChangePreferredLanguageValidator : CommandInputValidatorFor<ChangePreferredLanguage>
    {
        public ChangePreferredLanguageValidator()
        {
            RuleFor(_ => _.DataCollectorId)
                .NotEmpty().WithMessage("Data Collector Id must be set")
                .SetValidator(new DataCollectorIdValidator());

            RuleFor(_ => _.PreferredLanguage)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .IsInEnum().WithMessage("Preferred Language must be valid");
        }
    }
}