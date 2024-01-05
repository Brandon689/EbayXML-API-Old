using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Database.DTO.Interface;

namespace ECommerce.Database.DTO
{
    public class EbayAddress : BaseAddress, IOrder<string>
    {
        public string OrderId { get; set; }

        public string Street { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string CityName { get; set; }
        public string County { get; set; }
        //public bool CountrySpecified { get; set; }
        public string CountryName { get; set; }
        //public string Phone { get; set; }
        //public bool PhoneCountryCodeSpecified { get; set; }
        //public string PhoneCountryPrefix { get; set; }
        //public string PhoneAreaOrCityCode { get; set; }
        //public string PhoneLocalNumber { get; set; }
        //public string AddressID { get; set; }
        //public int AddressOwner { get; set; }
        //public string ExternalAddressID { get; set; }
        //public string InternationalName { get; set; }
        //public string InternationalStateAndCity { get; set; }
        //public string InternationalStreet { get; set; }
        //public string CompanyName { get; set; }
        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        //public string Phone2 { get; set; }
    }
}
