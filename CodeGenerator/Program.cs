using Microsoft.Office.Interop.Outlook;
using System;
using System.Data;
using System.Net.Mime;
using System.Text.RegularExpressions;

namespace ReadEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            var outlookApplication = new MediaTypeNames.Application();
            var outlookNameSpace = outlookApplication.GetNamespace("MAPI");
            var folder = outlookNameSpace.Folders["jamieho@microsoft.com"].Folders["MSApprovalNotifications"];

            foreach (MailItem mailItem in folder.Items)
            {
                try
                {

                }
                catch (System.Exception e)
                {
                    Console.WriteLine($"Exception raised in {GetType().Name} -- {e}");
                }
            }
        }
    }
}