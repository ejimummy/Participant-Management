using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticipantManagement
{
    class Staff : User
    {
        /// <summary>
        /// Staff member's professional job title, such as software engineer or HR manager
        /// </summary>
        public string JobTitle { get; set; }
        /// <summary>
        /// Staff member's company of employment
        /// </summary>
        public string Company { get; set; }
        /// <summary>
        /// Staff member's position designation such as Volunteer, Instructor, TA
        /// </summary>
        public string StaffType { get; set; }
    }
}
