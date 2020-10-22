using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLibrary;

namespace MatchSubmitLibrary.MatchRecord
{
    /// <summary>
    /// Implementation of the IGenericRepository interface.
    /// </summary>
    public interface IMatchRepository : IGenericRespository<MatchRecordModel>
    {
        /// <summary>
        /// Get the match record by the matchID.
        /// </summary>
        /// <param name="matchID">MatchID.</param>
        /// <returns>MatchRecord for matchID.</returns>
        MatchRecordModel GetMatchByID(int matchID);
    }
}
