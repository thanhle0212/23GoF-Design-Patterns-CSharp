namespace CoRSample
{
    public abstract class BaseApprover : IHandler
    {

        protected IHandler _nextHandler;

        public void SetTheNextHandler(IHandler handler)
        {
            _nextHandler = handler;
        }

        public abstract void Process(GadgetPurchase request);
    }
}