LendingClubDotNet (kannankeril)
===============================

Thanks to [Justin Blackwood](https://github.com/jblackwood12/LendingClubDotNet) for sharing his project. His Lending Club (LC) client allows the rest of the .Net developer community to tap into the LC ecosystem via their public API. In case it is not obvious, this project is a fork of Justin's original project, also hosted on Github.

Thanks also to [Mike Gledhill](http://www.MikesKnowledgeBase.com)for his [Export to Excel class](http://www.codeproject.com/Articles/692092/A-free-Export-to-Excel-Csharp-class-using-OpenXML) that simplified much of the work of exporting the data.

My goal in forking this project was to add a console application that would allow individuals *(members of the eclectic .Net Developer community who are also Lending Club Investors)* to download currently listed loans as well as each of their existing portfolios into an Excel workbook.

The idea is to have access to all the data that LC provides in order determine what variables may have contributed to / detracted from performance in current portfolios. And, to apply that insight to filter active loans and identify those listings that are the best investment candidates.

The Excel workbook may be of more utility than the Lending Club UI as the UI does not seem to expose all the data that is available via the LC API. 

For eg., your existing notes may indicate that, "public records > 0 and finance inquiries > 0", are a common attribute among notes that have defaulted or missed a payment deadline. 
Alternately, you might look at bankruptcy filings and decide to focus on states or zip codes with a lower incidence of such filings.


Future goal, expose the data via a visual interface that focuses on comparing returns across various portfolios. More on that when we get to it.

I am open to ideas for implementation/collaboration.


https://www.linkedin.com/in/kannankeril


