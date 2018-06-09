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
        static int lastSessionId = 0;

        /// <summary>
        /// Auto Generated SessionId
        /// </summary>
        public int SessionId { get; private set; }
        /// <summary>
        /// Scheduled date of workshop
        /// </summary>
        public string Date { get; set; }
        /// <summary>
        /// Scheduled start time of workshop
        /// </summary>
        public string Time { get; set; }
        /// <summary>
        /// WorkshopId associated from Workshops
        /// </summary>
        public int WorkshopId { get; set; }

        /// <summary>
        /// LocationId associated with Location class
        /// </summary>
        public int LocationId { get; set; }

        #endregion

        public Session(int workshopId, string date, string time, int locationId)
        {
            SessionId = ++lastSessionId;
            WorkshopId = workshopId;
            Date = date;
            Time = time;
            LocationId = locationId;
        }

        #region Methods

        public void cancelSession()
        {

        }

        public void updateSession()
        {

        }
        #endregion
    }
}
