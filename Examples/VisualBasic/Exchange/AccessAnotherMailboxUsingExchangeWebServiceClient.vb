﻿Imports Aspose.Email.Exchange
Imports Aspose.Email.Mail

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Email for .NET API reference 
'when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Email for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Email.Examples.VisualBasic.Email.Exchange
	Class AccessAnotherMailboxUsingExchangeWebServiceClient
		Public Shared Sub Run()
			' ExStart:AccessAnotherMailboxUsingExchangeWebServiceClient
			' Create instance of EWSClient class by giving credentials
			Dim client As IEWSClient = EWSClient.GetEWSClient("https://outlook.office365.com/ews/exchange.asmx", "testUser", "pwd", "domain")

			' Get Exchange mailbox info of other email account
			Dim mailboxInfo As ExchangeMailboxInfo = client.GetMailboxInfo("otherUser@domain.com")
			' ExEnd:AccessAnotherMailboxUsingExchangeWebServiceClient
		End Sub
	End Class
End Namespace