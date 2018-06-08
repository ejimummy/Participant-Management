using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticipantManagement
{
    class Administrator : User
    {
        /// <summary>
        /// Admin's role for permissions settings
        /// </summary>
        public string Role { get; set; }
    }
}
