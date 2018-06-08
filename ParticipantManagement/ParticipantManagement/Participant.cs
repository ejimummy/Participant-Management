using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticipantManagement
{
    class Participant : User
    {
        #region Properties

        public List <string> CollegeDegree { get; set; } 
        /// <summary>
        /// Institution or how they learned to code
        /// </summary>
        public string LearnedToCode { get; set; }
        /// <summary>
        /// Participant's technical skills, listed by SkillId linked to Skill class
        /// </summary>
        public List <string> Skills { get; set; }
        #endregion

        #region Methods
        /// <summary>
        /// Participant can print their current schedule
        /// </summary>
        public void PrintSchedule()
        {

        }
        /// <summary>
        /// Participant can update their personal data
        /// </summary>
        public void UpdatePersonalData() ///probably want to do this a bit differently for each property
        {

        }
        #endregion
    }
}
