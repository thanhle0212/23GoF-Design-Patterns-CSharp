namespace VisitorSample
{
    public class BackOfficeEmployee : Employee, IElement
    {
        public decimal Bonus { get; set; }
        public BackOfficeEmployee(string name, decimal salary, decimal bonus) : base(name, salary)
        {
            Bonus = bonus;
        }

        public void Accept(IVisitor visitor) => visitor.Visit(this);

    }
}