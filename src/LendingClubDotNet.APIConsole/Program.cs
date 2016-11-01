using LendingClubDotNet.Client.v1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            ImportLoansAndNotesToExcel(lendingClubV1Client);
            #endregion
        }

        private static void ImportLoansAndNotesToExcel(LendingClubV1Client lendingClubV1Client)
        {
            throw new NotImplementedException();
        }
    }
}
