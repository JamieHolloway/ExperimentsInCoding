using Microsoft.Office.Interop.Outlook;
using System;

namespace ReadEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            Read();
        }

        public static void Read()
        {
            var outlookApplication = new Application();
            var outlookNameSpace = outlookApplication.GetNamespace("MAPI");
            var folder = outlookNameSpace.Folders["jamieho@microsoft.com"].Folders["Todo"];

            foreach (MailItem mailItem in folder.Items)
            {
                try
                {
                    Console.WriteLine($"<b>From:</b> {mailItem.SenderName}");
                    Console.WriteLine($"<b>Sent:</b> {mailItem.CreationTime}");
                    Console.WriteLine($"<b>To:</b> {mailItem.To}");
                    Console.WriteLine($"<b>Cc:</b> {mailItem.CC}");
                    Console.WriteLine($"<b>Subject:</b> {mailItem.Subject}");
                    Console.WriteLine(mailItem.HTMLBody);
                    Console.Read();
                }
                catch (System.Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }
    }
}
