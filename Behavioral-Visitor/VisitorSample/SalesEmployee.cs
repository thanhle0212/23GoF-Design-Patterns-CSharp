namespace VisitorSample
{
    public class SalesEmployee : Employee, IElement
    {
        public decimal Commission { get; set; }
        public SalesEmployee(string name, decimal salary, decimal commission) : base(name, salary)
        {
            Commission = commission;
        }
        public void Accept(IVisitor visitor) => visitor.Visit(this);
    }
}