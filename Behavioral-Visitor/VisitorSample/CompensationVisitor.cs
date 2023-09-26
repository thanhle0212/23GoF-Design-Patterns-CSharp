namespace VisitorSample
{
    public class CompensationVisitor : IVisitor
    {
        public decimal TotalCompensation { get; private set; } = 0;
        public void Visit(BackOfficeEmployee e)
        {
            TotalCompensation += e.Salary + e.Bonus;
        }
        public void Visit(SalesEmployee e)
        {
            TotalCompensation += e.Salary + e.Commission;
        }
    }
}