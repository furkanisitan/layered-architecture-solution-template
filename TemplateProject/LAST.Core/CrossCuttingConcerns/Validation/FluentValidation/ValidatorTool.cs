using FluentValidation;
using LAST.Core.Entities;
using System.Linq;

namespace LAST.Core.CrossCuttingConcerns.Validation.FluentValidation
{
    public class ValidatorTool
    {
        /// <summary>
        /// Performs model validation on the entity object using the 'validator' parameter.
        /// </summary>
        /// <typeparam name="T">type of entity</typeparam>
        /// <param name="validator">validator object</param>
        /// <param name="entity">entity object</param>
        /// <param name="ruleSet">FluentValidation RuleSets</param>
        public static void FluentValidate<T>(IValidator<T> validator, T entity, string ruleSet) where T : class, IEntity, new()
        {
            var result = validator.Validate(entity, ruleSet: ruleSet);
            if (result.Errors.Any())
                throw new ValidationException(result.Errors);
        }
    }
}
