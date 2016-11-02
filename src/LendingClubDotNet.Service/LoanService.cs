using System;

using LendingClubDotNet.Models.Responses;
using LendingClubDotNet.Client.v1;

namespace LendingClubDotNet.Service
{
    public class LoanService
    {
        private static ListedLoansResponse _listedLoanResponse;
        private static DateTime? _lastListedLoanResponseTime;

        public ListedLoansResponse GetListedLoansResponse(LendingClubV1Client lendingClubV1Client)
        {
            if (_listedLoanResponse == null || DateTime.Now.Subtract(_lastListedLoanResponseTime.Value).Minutes >= 10)
            {
                _listedLoanResponse = lendingClubV1Client.LoanResource.GetListedLoans();
                _lastListedLoanResponseTime = DateTime.Now;
            }

            return _listedLoanResponse;
        }
    }
}
