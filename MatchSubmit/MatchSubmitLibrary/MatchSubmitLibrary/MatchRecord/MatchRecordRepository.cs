using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DataAccessLibrary;
using Microsoft.EntityFrameworkCore;

namespace MatchSubmitLibrary.MatchRecord
{
    public class MatchRecordRepository : GenericRepository<MatchRecordModel>, IMatchRepository
    {
        private MatchDataContext context;
        public MatchRecordRepository(MatchDataContext context) : base(context)
        {
            this.context = context;
        }

        public MatchRecordModel GetMatchByID(int matchID) 
        {
            return (from match in context.MatchRecord where match.matchID == matchID select match).FirstOrDefault();
        }
    }
    
}
