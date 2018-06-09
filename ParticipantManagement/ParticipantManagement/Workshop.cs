using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticipantManagement
{
    class Workshop
    {
        static int lastWorkshopId = 0;

        #region Properties
        /// <summary>
        /// WorkshopId created at initiation
        /// </summary>
        public int WorkshopId { get; private set; }
        /// <summary>
        /// Workshop Title
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Workshop Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Length of Workshop in minutes
        /// </summary>
        public int Length { get; set; }
        /// <summary>
        /// Link to materials storage location
        /// </summary>
        public string MaterialsLink { get; set; }

        #endregion

        public Workshop()
        {
            WorkshopId = ++lastWorkshopId;
        }

        #region Methods
        /// <summary>
        /// Update Workshop information
        /// </summary>
        public void UpdateWorkshop() ///need to work out how I want to do this, overloaded method or separate methods for each property
        {

        }
        /// <summary>
        /// Delete workshop from the system
        /// </summary>
        /// <param name="">WorkshopId</param>
        public void DeleteWorkshop(int WorkshopId)
        {

        }
        #endregion

    }
}
