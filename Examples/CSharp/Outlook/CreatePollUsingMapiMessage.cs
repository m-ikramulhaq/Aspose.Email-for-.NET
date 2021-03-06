﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Aspose.Email;
using Aspose.Email.Examples.CSharp.Email;
using Aspose.Email.Mime;
using Aspose.Email.Mapi;
using Aspose.Email.Storage.Pst;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Email for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Email for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Email.Examples.CSharp.Email.Outlook
{
    class CreatePollUsingMapiMessage
    {
        public static void Run()
        {
            // The path to the File directory.
            string dataDir = RunExamples.GetDataDir_Outlook();

            MapiMessage msg = CreateTestMessage(false);

            FollowUpOptions options = new FollowUpOptions();
            options.VotingButtons = "Yes;No;Maybe;Exactly!";

            FollowUpManager.SetOptions(msg, options);

            msg.Save(dataDir+ "MapiMsgWithPoll.msg");            
        }
        private static MapiMessage CreateTestMessage(bool draft)
        {
            MapiMessage msg = new MapiMessage(
            "from@test.com",
            "to@test.com",
            "Flagged message",
            "Make it nice and short, but descriptive. The description may appear in search engines' search results pages...");

            if (!draft)
            {
                msg.SetMessageFlags(msg.Flags ^ MapiMessageFlags.MSGFLAG_UNSENT);
            }

            return msg;
        }
    }
}