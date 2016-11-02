using System;

using LendingClubDotNet.Models.Responses;
using LendingClubDotNet.Client.v1;

namespace LendingClubDotNet.Service
{
    public class NoteService
    {
        private DetailedNotesOwnedResponse _detailedNotesOwnedResponse;
        private DateTime? _lastDetailedNotesOwnedResponseTime;

        public DetailedNotesOwnedResponse GetDetailedNotesOwnedResponse(LendingClubV1Client lendingClubV1Client)
        {
            if (_detailedNotesOwnedResponse == null || DateTime.Now.Subtract(_lastDetailedNotesOwnedResponseTime.Value).Minutes >= 10)
            {
                _detailedNotesOwnedResponse = lendingClubV1Client.AccountResource.GetDetailedNotesOwnedResponse();
                _lastDetailedNotesOwnedResponseTime = DateTime.Now;
            }

            return _detailedNotesOwnedResponse;
        }
    }
}
