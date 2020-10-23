using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatchSubmitLibrary.MatchRecord
{
    /// <summary>
    /// Model of the Match record.
    /// </summary>
    public class MatchRecordModel
    {
        /// <summary>
        /// Gets or sets the ID property.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the MatchID property.
        /// </summary>
        public int MatchID { get; set; }

        /// <summary>
        /// Gets or sets the high seed's first ban.
        /// </summary>
        public int? T1Ban1 { get; set; }

        /// <summary>
        /// Gets or sets the low seed's first ban.
        /// </summary>
        public int? T2Ban1 { get; set; }

        /// <summary>
        /// Gets or sets the high seed's map pick.
        /// </summary>
        public int? T1Pick { get; set; }

        /// <summary>
        /// Gets or sets the low seed's map pick.
        /// </summary>
        public int? T2Pick { get; set; }

        /// <summary>
        /// Gets or sets the high seed's second ban.
        /// </summary>
        public int? T1Ban2 { get; set; }

        /// <summary>
        /// Gets or sets the low seed's second ban.
        /// </summary>
        public int? T2Ban2 { get; set; }

        /// <summary>
        /// Gets or sets the decider map.
        /// </summary>
        public int? FPick { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the record is visible.
        /// </summary>
        public bool Visible { get; set; }

        // public int mapsPlayed { get; set; }

        /// <summary>
        /// Gets or sets the map ban url for the high seed.
        /// </summary>
        public string Team1Url { get; set; }

        /// <summary>
        /// Gets or sets the map ban url for the low seed.
        /// </summary>
        public string Team2Url { get; set; }

        /// <summary>
        /// Gets or sets the map ban url for the viewer.
        /// </summary>
        public string ViewerUrl { get; set; }

        /// <summary>
        /// Gets or sets the browser source.
        /// </summary>
        public string BrowserSourceUrl { get; set; }

        /// <summary>
        /// Gets or sets the lobby id.
        /// </summary>
        public string LobbyId { get; set; }
    }
}
