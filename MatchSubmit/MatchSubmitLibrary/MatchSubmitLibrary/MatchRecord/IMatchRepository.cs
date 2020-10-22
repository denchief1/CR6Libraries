using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLibrary;

namespace MatchSubmitLibrary.MatchRecord
{
    interface IMatchRepository : IGenericRespository<MatchRecordModel>
    {
        MatchRecordModel GetMatchByID(int matchID);
    }
}
