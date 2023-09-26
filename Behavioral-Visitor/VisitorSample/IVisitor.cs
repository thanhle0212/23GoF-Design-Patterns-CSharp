namespace VisitorSample
{
    public interface IVisitor
    {
        void Visit(BackOfficeEmployee e);
        void Visit(SalesEmployee e);
    }
}