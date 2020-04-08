using Core.CrossCuttingConcerns.Validation.FluentValidation;
using PostSharp.Aspects;
using PostSharp.Serialization;
using System;
using System.Linq;

namespace Core.Aspects.Postsharp.ValidationAspects
{
    /// <summary>
    /// Model validation of the entity object inherited from IEntity.
    /// "validatorType" => Type of model validator class.
    /// </summary>
    [PSerializable]
    public class FluentValidationAspect : OnMethodBoundaryAspect
    {
        private Type _validatorType;
        private string _ruleSet;

        public FluentValidationAspect(Type validatorType, string ruleSet = null)
        {
            _validatorType = validatorType;
            _ruleSet = ruleSet;
        }

        public override void OnEntry(MethodExecutionArgs args)
        {
            var entityType = _validatorType.BaseType?.GetGenericArguments()[0];
            var entities = args.Arguments.Where(x => x.GetType() == entityType);
            var genericValidateMethod = typeof(ValidatorTool).GetMethod(nameof(ValidatorTool.FluentValidate))?.MakeGenericMethod(entityType);
            var validator = Activator.CreateInstance(_validatorType);

            foreach (var entity in entities)
                genericValidateMethod?.Invoke(null, new[] { validator, entity, _ruleSet });
        }
    }
}
