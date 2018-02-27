using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingRedirectIssue.Cmd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"!!!BindingRedirectIssue.Cmd!!! {Microsoft.WindowsAzure.Storage.CloudStorageAccount.DevelopmentStorageAccount}");

            BindingRedirectIssue.Common.Class1.Debug();
        }
    }
}
