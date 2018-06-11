using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticipantManagement
{
    enum Education
    {
        HighSchool,
        Bachelors,
        Masters,
        PHD
    }

    enum CodeEducation
    {
        SelfTaught,
        College,
        Bootcamp,
        OnTheJob,
        Other
    }
    class Participant : User
    {
        #region Properties

        public Education HighestEducation { get; set; }
        /// <summary>
        /// Institution or how they learned to code
        /// </summary>
        public CodeEducation LearnedToCode { get; set; }
        /// <summary>
        /// Participant's technical skills, listed by SkillId linked to Skill class
        /// </summary>
        public List <Skill> SkillId { get; set; }
        #endregion

        #region Methods
        /// <summary>
        /// Participant can print their current schedule
        /// </summary>
        public void PrintSchedule()
        {

        }
        /// <summary>
        /// Participant can add a new technical skill
        /// </summary>
        public void AddSkill()
        {
  
        }
        #endregion
    }
}
