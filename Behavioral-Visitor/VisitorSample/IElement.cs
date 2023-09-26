namespace VisitorSample
{
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }
}