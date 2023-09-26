using VisitorSample;

var employees = new List<IElement>
        {
            new BackOfficeEmployee("John",80000,10000),
            new BackOfficeEmployee("Mary",120000,10000),
            new SalesEmployee("Bob",90000,40000),
        };

// Calculating total compensation
var compensationVisitor = new CompensationVisitor();

employees.ForEach(e => e.Accept(compensationVisitor));
Console.WriteLine($"Total Compensation : {compensationVisitor.TotalCompensation:C}");


// Calculating total stock options
var esoVisitor = new EmployeeStockOptionVisitor();
employees.ForEach(e => e.Accept(esoVisitor));

Console.WriteLine($"Total Stock Options : {esoVisitor.TotalUnit}");
