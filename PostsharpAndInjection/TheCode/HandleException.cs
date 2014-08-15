using System;
using PostSharp.Aspects;

namespace PostsharpAndInjection.TheCode
{
    [Serializable]
    public class HandleException : OnMethodBoundaryAspect
    {
        public override void OnException(MethodExecutionArgs args)
        {
            base.OnException(args);

            ServiceManager.Instance.Log.LogError(args.Exception);
        }
    }
}