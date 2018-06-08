using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticipantManagement
{
    class User
    {
        static int lastUserId = 0;

        #region Properties
        /// <summary>
        /// UserID
        /// </summary>
        public int UserId { get; private set; }
        /// <summary>
        /// User's first name
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// User's last name
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// User's email address
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// User's street address 1st Line
        /// </summary>
        public string StreetAddress1 { get; set; }
        /// <summary>
        /// User's street address 2nd Line
        /// </summary>
        public string StreetAddress2 { get; set; }
        /// <summary>
        /// User's city
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// User's state
        /// </summary>
        public string State { get; set; }
        /// <summary>
        /// User's zip code
        /// </summary>
        public int ZipCode { get; set; }
        /// <summary>
        /// User's phone number
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// Date the user account was created
        /// </summary>
        public DateTime DateCreated { get; set; }
        #endregion

        #region Constructors
        public User()
        {
            UserId = ++lastUserId;
            DateCreated = DateTime.UtcNow;
        }
        #endregion


        #region Methods
        /// <summary>
        /// User update personal data
        /// </summary>
        public void UpdatePersonalData()
        {

        }
        /// <summary>
        /// Delete user account
        /// </summary>
        /// <param name="user">UserId</param>
        /// <returns>true if successfully deleted, otherwise returns false</returns>
        public bool DeleteAccount(int user)
        {
            bool success = false;

            return success;
        }
        #endregion
    }
}
