using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinSearch
{
    public class Vin
    {
        public Vin(string vinNumber)
        {
            Number = vinNumber;

            CountryCode = vinNumber.Substring(0, 1);
            ManufacturerCode = vinNumber.Substring(1, 2);
            VehicleCode = vinNumber.Substring(3, 5);
            SecurityCode = vinNumber.Substring(8, 1);
            YearCode = vinNumber.Substring(9, 1);
            PlantCode = vinNumber.Substring(10, 1);
            SerialNumber = vinNumber.Substring(11, 6);
        }   

        public string Number { get; set; }
        public string CountryCode { get; set; }
        public string ManufacturerCode { get; set; }
        public string VehicleCode { get; set; }
        public string SecurityCode { get; set; }
        public string YearCode { get; set; }
        public string PlantCode { get; set; }
        public string SerialNumber { get; set; }
    }
}
