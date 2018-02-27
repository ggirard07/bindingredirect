using System;

namespace BindingRedirectIssue.Common
{
    public class Class1
    {
        public static void Debug()
        {
            Console.WriteLine($"!!!BindingRedirectIssue.Common!!! In .NetStandard right now");
            Console.WriteLine($"!!!BindingRedirectIssue.Common!!! {Microsoft.WindowsAzure.Storage.CloudStorageAccount.DevelopmentStorageAccount}");
        }
    }
}
