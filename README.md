LendingClubDotNet
=========

C# (.NET v4.5) Client for the Lending Club API

Example usage:
```
// Initialize the client with credentials.
// Replace 'authenticationToken' with the one provided to you by Lending Club
// Replace 'actorId' with your Lending Club Id
LendingClubV1Client lendingClubV1Client = new LendingClubV1Client(authenticationToken, actorId);

// Get all Listed Loans.
ListedLoansResponse listedLoansResponse = lendingClubV1Client.LoanResource.GetListedLoans();

// Get all Portfolios that you have.
PortfoliosOwnedResponse portfoliosOwnedResponse = lendingClubV1Client.AccountResource.GetPortfoliosOwned();

// Submit an Orders Request (invest in loans).
SubmitOrdersRequest submitOrdersRequest = new SubmitOrdersRequest
			{
				aid = Convert.ToInt32(actorId),
				orders = new List<Order> { new Order
				{
					loanId = loanId,
					portfolioId =  portfolioId,
					requestedAmount = 25
				} }
			};

// Congratulations, at this point if the request has been submitted successfully, you will have programatically invested!
SubmitOrdersResponse submitOrdersResponse = lendingClubV1Client.AccountResource.SubmitOrders(submitOrdersRequest);
```

See the official Lending Club API documentation here:
https://www.lendingclub.com/developers/lc-api.action


If you want more information about me, Justin Blackwood, go here:
https://www.linkedin.com/in/justinedwardblackwood






LendingClubDotNet (kannankeril)
===============================

Thanks to Justin for sharing his libraries that allow the rest of the .Net developer community to tap into the Lending Club ecosystem via their public API.

My first goal in forking this project is to add a console project that will allow individuals (members of the eclectic .Net Developer community who are also Lending Club Investors) to download currently listed loans as well as each of their existing portfolios into an Excel workbook.

The idea is to have access to all the data that LC provides in order determine what factors may have contributed to or detracted from performance in our current portfolios.

Hopefully the insight gained can then be used to help evaluate investment decisions into currently listed loans. The Excel workbook may be of more utility than the Lending Club UI as the UI does not seem to expose all the data that is available via the LC API.

For eg., your existing notes may indicate that 

	public records > 0 and finance inquiries > 0,
 
are a common attribute among notes that have defaulted or missed a payment deadline. 
Alternately, you might look at bankruptcy filings and decide to focus on states or zip codes with a lower incidence of such filings.

You can apply your new expanded criteria to the Listed Loans worksheet and come up with your custom shortlist of loans to invest in.

Future goal, expose the data via a visual interface that focuses on comparing returns across various portfolios. More on that when we get to it.

I am open to ideas for implementation/collaboration.

kannankeril
https://www.linkedin.com/in/kannankeril


