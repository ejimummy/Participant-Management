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
        public Workshop Workshop { get; set; }

        /// <summary>
        /// LocationId associated with Location class
        /// </summary>
        public Location Location { get; set; }

        #endregion

        public Session(Workshop workshop, string date, string time, Location location)
        {
            SessionId = ++lastSessionId;
            Workshop = workshop;
            Date = date;
            Time = time;
            Location = location;
        }

        #region Methods
       
        /// <summary>
        /// Remove a session from the database
        /// </summary>
        public void cancelSession()
        {

        }
        /// <summary>
        /// Update a session that already exists in the database
        /// </summary>
        public void updateSession(Workshop workshop, string date, string time, Location location)
        {
            Workshop = workshop;
            Date = date;
            Time = time;
            Location = location;
        }
        #endregion
    }
}
