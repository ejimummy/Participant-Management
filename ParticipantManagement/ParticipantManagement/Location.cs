using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticipantManagement
{
    class Location
    {
        static int lastLocationId = 0;
        #region Properties
        
        public int LocationId { get; private set; }
        /// <summary>
        /// Street address of vendor partner
        /// </summary>
        public string StreetAddress { get; set; }
        /// <summary>
        /// City of vendor partner
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// State of vendor partner
        /// </summary>
        public string State { get; set; }
        /// <summary>
        /// Zip Code of vendor partner
        /// </summary>
        public int ZipCode { get; set; }
        #endregion

        public Location()
        {
            LocationId = ++lastLocationId;
        }
        #region Methods
        /// <summary>
        /// Add a new vendor location
        /// </summary>
        /// <param name="address">StreetAddress</param>
        /// <param name="city">City</param>
        /// <param name="state">State</param>
        /// <param name="zipCode">ZipCode</param>
        public void addLocation(string address, string city, string state, int zipCode)
        {
            StreetAddress = address;
            City = city;
            State = state;
            ZipCode = zipCode;
        }
        /// <summary>
        /// Update the location information in the system
        /// </summary>
        public void updateLocation()
        {

        }
        /// <summary>
        /// Delete location from the system
        /// </summary>
        /// <param name="locationId"></param>
        public void deleteLocation(int locationId)
        {

        }
        #endregion

    }
}
