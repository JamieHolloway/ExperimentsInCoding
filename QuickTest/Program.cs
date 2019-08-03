using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QuickTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = 1;
            var pattern = @"(?i)SendBack comments:</strong>(.*?)<br>";

            var subject =
                @"<!DOCTYPE html>  <html lang=""en"" xmlns=""http://www.w3.org/1999/xhtml"" xmlns:mso=""urn:schemas-microsoft-com:office:office"" xmlns:msdt=""uuid:C2F41010-65B3-11d1-A29F-00AA00C14882"">  <head>    <title>PO# 80107534 {6,609.60 USD}: has been sent back by Approver {susant}</title>  <style type=""text/css"">         body, td, th {             font-family: ""Segoe UI Light"", Arial;             font-size: 14px;             color: #000;         }          body {             background-color: #FFF;         }          a {             color: #2873C9;             border: ""0"";         }              a:link {                 text-decoration: none;             }              a:visited {                 text-decoration: none;                 color: #2873C9;             }              a:hover {                 text-decoration: underline;                 color: #2873C9;             }              a:active {                 text-decoration: none;                 color: #2873C9;             }          h1 {             font-size: 22px;             font-weight: 400;             color: #000;             line-height: normal;             text-decoration: blink;         }          h2 {             font-size: 18px;             color: #000;             font-weight: normal;             border: ""0"";         }          h3 {             font-size: 14px;             color: #000;             font-weight: normal;         }          .body18 {             font-size: 18px;         }          .symbol {             font-family: ""Segoe UI Symbol"";             color: #2873C9;         }          .comment {             background-color: #FFAA00;         }     </style>  </head>  <body>  <h1>GFS SCM PO – The Approver has sent back the PO to the Requestor/Project Owner. Based on the modifications made to the PO, the PO Approval workflow may restart upon resubmission.  </h1>  <p><span class=""symbol"">?</span><a title=""Click here to view in MyOrder"" href=""https://myorder/Requisition/QueueView.aspx?reqid=80107534""> View PO details in MyOrder  </a></p>  <p><span class=""body18""><strong>Title:</strong> GFS Hardware PO</span><br>  <strong>Supplier:</strong> WORLD WIDE TECHNOLOGY INC (0002148678) </p>  <p><strong>SendBack reason:</strong>None<br>  <strong>SendBack comments:</strong>This is connecting RNG&lt;&gt;DC. Use IO code for Regional Fabric: DSM_Fabric_New P10002996 1690364<br>  <strong>Owner:</strong> Fritz Whitney<br>  <strong>Requestor:</strong> Frederick Whitney<br>  <strong>Notes:</strong> ||MCIO CORE | DM3 | TFS# 821513| DSM | DM3 | DC | MGFX Refresh PH2 | Optical-Transport | Inphi<br>  </p>  <p><span class=""symbol"">?</span> Go to <a title=""Click here to view in MSApprovals"" href=""https://emea01.safelinks.protection.outlook.com/?url=https%3A%2F%2Fmsapprovals.microsoft.com%2F%23%2Flogin%3FtenantId%3D5%26documentNumber%3D80107534%26fiscalYear%3D%26t%3DProcurement&amp;data=02%7C01%7C%7C0c4406b86fdf4233e2eb08d6387f8eb6%7C72f988bf86f141af91ab2d7cd011db47%7C1%7C0%7C636758517836854128&amp;sdata=IhDuBORRvYm%2FVwbmbMUMdK9SKtToNlECK3yXeo4aaas%3D&amp;reserved=0"" originalSrc=""https://msapprovals.microsoft.com/#/login?tenantId=5&documentNumber=80107534&fiscalYear=&t=Procurement"" shash=""SJ9DBRkyQjFNO8GI97riQKM+bu2SglRZ0xLFwsyPc6k3XZK5dnoZ+Q1037TFYS4v40efC7FJUEx6dhZmkpEYfsyhTiXw8iZW2ZHybjP4WrQlLC5dYdFSY6c+aMLpCmpphWGQiYDITU/1rQkoEytPIjxpVHQ7Fhje6wFktA3yeP0="" originalSrc=""https://msapprovals.microsoft.com/#/login?tenantId=5&documentNumber=80107534&fiscalYear=&t=Procurement"" shash=""r7MNQKelpqAHZu82Of72oKeF0rvISv099BO6IhbrZXgOmuigtSUe8neFUAyOyL2zGRwKvp5SuWL0/+afblMCOqYKEiKRMYB749ELl4u5Cr3VoPEtcoBGCx6wtoK/YD2NWwd28duqR+JXNPb9We5a4+Zfz6Oxhxur6wi/jNG+3VQ="">  MSApprovals website</a> or the <a tile=""Click here to view in MSApprovals"" href=""https://emea01.safelinks.protection.outlook.com/?url=https%3A%2F%2Fmsapprovals.microsoft.com%2Fspamvc%2FDeepLink%2FDeepLink.html%3FTenantID%3D5%26DocumentNumber%3D80107534%26templateName%3DProcurement&amp;data=02%7C01%7C%7C0c4406b86fdf4233e2eb08d6387f8eb6%7C72f988bf86f141af91ab2d7cd011db47%7C1%7C0%7C636758517836864136&amp;sdata=rMKg6oku6AoBlONy4BwIFes2UY8vAtEf978x3Ix86C4%3D&amp;reserved=0"" originalSrc=""https://msapprovals.microsoft.com/spamvc/DeepLink/DeepLink.html?TenantID=5&DocumentNumber=80107534&templateName=Procurement"" shash=""TemWjMcgGy94+MIcEWnaQR9euw6lox1nW9hhVycd2iOBih6f+MKAwvD2+TgyhXuaSlimLcFAgnje8iwGtsSYGKi0pJN51ORiJQxQ+alJFuzudAP+0PUvfBkvRp3ws5czR2ZmdYlylHyIMJJ6Ir9Jdx4E3VISEHkwt/fqzgjSSO8="" originalSrc=""https://msapprovals.microsoft.com/spamvc/DeepLink/DeepLink.html?TenantID=5&DocumentNumber=80107534&templateName=Procurement"" shash=""Ri7b+eMKB8uB6tO9A90p8nbEPU/ckG6aWk8zrWl0yZq6AIlIvuAhgTPemz9mzS8R22p/fn2PvjzhYluZXB/lvgq0h63oiJg3S84vEzMglEUMn+/U14SGWgcLyT/EZBo9k7r5a4aUfvHHNupY746uo4k6HjejRFly/Uk5q5RlX2E="">  MSApprovals app</a><br>  <b>Note: </b>The “MSApprovals app” link only works if the app is installed, otherwise please use the “MSApprovals website” link.  <br>  </p>  </body>  </html>  
";
            try
            {
                var regex = new Regex(pattern.ToString());
                var match = regex.Match(subject.ToString());
                if (match.Success && p < match.Groups.Count) Console.WriteLine((match.Groups[p].Value)); else Console.WriteLine("no match");
            }
            catch (Exception e)
            {
                var message = "Subject=" + subject.ToString() + " Pattern=" + pattern.ToString() + " Exception=" + e.Message;
                if (e.InnerException != null) message += "InnerException=" + e.InnerException.Message;
                throw new ApplicationException("Severe error caught in execution of user-defined function; contact jamieho@microsoft.com for support.  Diagnostics: " + message);
            }


        }
    }
}
