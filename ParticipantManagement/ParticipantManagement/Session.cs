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
        /// LocationId associated with Location class
        /// </summary>
        public int LocationId { get; set; }
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

        #endregion

        #region Methods
        public void scheduleSession()
        {

        }

        public void cancelSession()
        {

        }

        public void updateSession()
        {

        }
        #endregion
    }
}
