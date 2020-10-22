using System.Linq;
using DataAccessLibrary;
using Microsoft.EntityFrameworkCore;

namespace MatchSubmitLibrary.MatchRecord
{
    /// <summary>
    /// Implementation of the GenericRepository and the IMatchRepository interface.
    /// </summary>
    public class MatchRecordRepository : GenericRepository<MatchRecordModel>, IMatchRepository
    {
        /// <value>Private matchcontext of the supplied type.</value>
        private MatchDataContext context;

        /// <summary>
        /// Initializes a new instance of the <see cref="MatchRecordRepository"/> class.
        /// </summary>
        /// <param name="context">Instance of the matchcontext.</param>
        public MatchRecordRepository(MatchDataContext context)
            : base(context)
        {
            this.context = context;
        }

        /// <summary>
        /// Implentation of the GetMatchByID method.
        /// </summary>
        /// <param name="matchID">MatchID of the record.</param>
        /// <returns>Matchrecord.</returns>
        public MatchRecordModel GetMatchByID(int matchID)
        {
            return (from match in context.MatchRecord where match.MatchID == matchID select match).FirstOrDefault();
        }
    }
}
