using ProxySample;

Console.WriteLine("Client passing employee with Role Developer to folderproxy");
Employee emp1 = new Employee("Math", "123456", "Developer");
SharedFolderProxy folderProxy1 = new SharedFolderProxy(emp1);
folderProxy1.PerformRWOperation();
Console.WriteLine();


Console.WriteLine("Client passing employee with Role Manager to folderproxy");
Employee emp2 = new Employee("Thanh", "123456", "Manager");
SharedFolderProxy folderProxy2 = new SharedFolderProxy(emp2);
folderProxy2.PerformRWOperation();