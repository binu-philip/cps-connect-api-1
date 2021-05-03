using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPSConnectModel
{
    public class CalendarsResult
    {
        /// <summary>
        /// ColorCode - HexaDecimal HTML Color Value
        /// </summary>
        [JsonProperty("ColorCode")]
        public string HexaDecimalHTMLColorValue { get; set; }
        /// <summary>
        /// ParentID
        /// </summary>
        public Int64 ParentID { get; set; }
        /// <summary>
        /// Status
        /// </summary>
        public bool Status { get; set; }
        /// <summary>
        /// TagID
        /// </summary>
        public Int64 TagID { get; set; }
        /// <summary>
        /// Type
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// CalendarID
        /// </summary>
        public int CalendarID { get; set; }
        /// <summary>
        /// CalendarName
        /// </summary>
        public string CalendarName { get; set; }
    }
}
