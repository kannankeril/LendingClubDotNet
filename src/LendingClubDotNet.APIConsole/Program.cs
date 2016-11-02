using System;
using System.IO;

using LendingClubDotNet.Client.v1;
using LendingClubDotNet.Models;
using LendingClubDotNet.Models.Responses;
using LendingClubDotNet.Service;

namespace LendingClubDotNet.APIConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize the client with credentials.
            // Replace 'authorizationToken' with the one provided to you by Lending Club
            // Replace 'investorId' with your Lending Club Id
            string authorizationToken = "";
            string investorId = "";
            LendingClubV1Client lendingClubV1Client = new LendingClubV1Client(authorizationToken, investorId);

            #region Export listed loans and notes by portfolio to Excel workbook
            ResultObject resultObject = ImportLoansAndNotesToExcel(lendingClubV1Client);
            CheckActionResult(resultObject);
            #endregion
        }

        private static ResultObject ImportLoansAndNotesToExcel(LendingClubV1Client lendingClubV1Client)
        {
            ResultObject resultObject;
            try
            {
                LoanService loanService = new LoanService();
                PortfolioService portfolioService = new PortfolioService();
                NoteService noteService = new NoteService();

                ListedLoansResponse listedLoansResponse
                    = loanService.GetListedLoansResponse(lendingClubV1Client);
                PortfoliosOwnedResponse portfoliosOwnedResponse
                    = portfolioService.GetPortfoliosOwnedResponse(lendingClubV1Client);
                DetailedNotesOwnedResponse detailedNotesOwnedResponse
                    = noteService.GetDetailedNotesOwnedResponse(lendingClubV1Client);

                string exepath = System.Reflection.Assembly.GetExecutingAssembly().Location;
                string directory = System.IO.Path.GetDirectoryName(exepath);
                string fileFullName = Path.Combine(directory, "LendingClub.xlsx");
                resultObject = DocumentExportService.CreateExcelDocument(listedLoansResponse
                                                        , portfoliosOwnedResponse
                                                        , detailedNotesOwnedResponse
                                                        , fileFullName);
            }
            catch (Exception ex)
            {
                resultObject = new ResultObject(-1, ex.Message);
            }

            return resultObject;
        }

        private static void CheckActionResult(ResultObject resultObject)
        {
            if (!resultObject.IsSuccessful)
            {
                Console.WriteLine("***Error: " + resultObject.Message);
                Console.ReadKey();
            }
        }
    }
}
