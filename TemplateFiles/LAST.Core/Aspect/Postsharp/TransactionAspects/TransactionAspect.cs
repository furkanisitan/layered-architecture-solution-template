using PostSharp.Aspects;
using PostSharp.Serialization;
using System.Transactions;

namespace $safeprojectname$.Aspect.Postsharp.TransactionAspects
{
    /// <summary>
    /// Runs the method body as 'transactional'. In the event of an error, all transactions are rolled back.
    /// </summary>
    [PSerializable]
    public sealed class TransactionAspect : OnMethodBoundaryAspect
    {
        public override void OnEntry(MethodExecutionArgs args)
        {
            var transactionScope = new TransactionScope(TransactionScopeOption.Required);
            args.MethodExecutionTag = transactionScope;
        }

        public override void OnSuccess(MethodExecutionArgs args)
        {
            var transactionScope = (TransactionScope)args.MethodExecutionTag;
            transactionScope.Complete();
        }

        public override void OnExit(MethodExecutionArgs args)
        {
            var transactionScope = (TransactionScope)args.MethodExecutionTag;
            transactionScope.Dispose();
        }
    }
}
