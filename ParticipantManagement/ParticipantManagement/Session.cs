using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticipantManagement
{
    class Session
    {
        #region Properties
        /// <summary>
        /// Scheduled date of workshop
        /// </summary>
        public string Date { get; set; }
        /// <summary>
        /// Scheduled start time of workshop
        /// </summary>
        public string Time { get; set; }
        /// <summary>
        /// Scheduled Street Address of session location
        /// </summary>
        public string StreetAddress { get; set; }
        /// <summary>
        /// City of session location
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// State of session location
        /// </summary>
        public string State { get; set; }
        /// <summary>
        /// Zip Code of session location
        /// </summary>
        public int ZipCode { get; set; }
        /// <summary>
        /// WorkshopId associated from Workshops
        /// </summary>
        public int WorkshopId { get; set; }

        #endregion

        #region Methods
        #endregion
    }
}
