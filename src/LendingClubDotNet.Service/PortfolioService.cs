using System;

using LendingClubDotNet.Models.Responses;
using LendingClubDotNet.Client.v1;

namespace LendingClubDotNet.Service
{
    public class PortfolioService
    {
        private PortfoliosOwnedResponse _portfolioOwnedResponse;
        private DateTime? _lastPortfolioOwnedResponseTime;

        public PortfoliosOwnedResponse GetPortfoliosOwnedResponse(LendingClubV1Client lendingClubV1Client)
        {
            if (_portfolioOwnedResponse == null || DateTime.Now.Subtract(_lastPortfolioOwnedResponseTime.Value).Minutes >= 10)
            {
                _portfolioOwnedResponse = lendingClubV1Client.AccountResource.GetPortfoliosOwned();
                _lastPortfolioOwnedResponseTime = DateTime.Now;
            }

            return _portfolioOwnedResponse;
        }
    }
}
