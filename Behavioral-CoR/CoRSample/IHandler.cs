namespace CoRSample
{
    public interface IHandler
    {
        public void SetTheNextHandler(IHandler handler);

        public void Process(Product request);
    }
}