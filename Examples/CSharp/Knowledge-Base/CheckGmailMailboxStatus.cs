﻿using Aspose.Email.Clients;
using Aspose.Email.Clients.Pop3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Email for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Email for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Email.Examples.CSharp.Email.Knowledge.Base
{
    class CheckGmailMailboxStatus
    {
        public static void Run()
        {
            try
            {
                // Create a POP3 client
                Pop3Client client = new Pop3Client();

                // Basic settings (required)
                client.Host = "pop.gmail.com";
                client.Username = "user@gmail.com";
                client.Password = "pwd";
                client.Port = 995;
                client.SecurityOptions = SecurityOptions.SSLImplicit;

                // ExStart:CheckGmailMailboxStatus
                // Create an object of type Pop3MailboxInfo and Get the mailbox information, Check number of messages, and Check mailbox size
                Pop3MailboxInfo info;
                info = client.GetMailboxInfo();
                Console.WriteLine(info.MessageCount);
                Console.Write(info.OccupiedSize + " bytes");
                // ExEnd:CheckGmailMailboxStatus
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
