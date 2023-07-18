using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProxySample
{
    public class SharedFolderProxy : ISharedFolder
    {
        private ISharedFolder folder;
        private Employee employee;

        public SharedFolderProxy(Employee emp)
        {
            employee = emp;
        }

        public void PerformRWOperation()
        {
            if (string.Equals("CEO", employee.Role, StringComparison.OrdinalIgnoreCase) ||
            string.Equals("MANAGER", employee.Role, StringComparison.OrdinalIgnoreCase))
            {
                folder = new SharedFolder();
                Console.WriteLine("Shared Folder Proxy makes call to the RealFolder 'PerformRWOperations method'");
                folder.PerformRWOperation();
            }
            else
            {
                Console.WriteLine("Shared Folder proxy says 'You don't have permission to access this folder'");
            }
        }
    }
}