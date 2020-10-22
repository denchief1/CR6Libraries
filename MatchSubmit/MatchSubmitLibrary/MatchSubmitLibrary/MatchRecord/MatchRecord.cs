using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatchSubmitLibrary.MatchRecord
{
    public class MatchRecordModel
    {
        public int ID { get; set; }
        public int matchID { get; set; }
        public int? t1Ban1 { get; set; }
        public int? t2Ban1 { get; set; }
        public int? t1Pick { get; set; }
        public int? t2Pick { get; set; }
        public int? t1Ban2 { get; set; }
        public int? t2Ban2 { get; set; }
        public int? fPick { get; set; }
        public bool visible { get; set; }
        //public int mapsPlayed { get; set; }
        public string team1Url { get; set; }
        public string team2Url { get; set; }
        public string viewerUrl { get; set; }
        public string browserSourceUrl { get; set; }
        public string lobbyId { get; set; }
    }
}
