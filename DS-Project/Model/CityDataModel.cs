using System;
using System.Collections.Generic;
using System.Text;

namespace DS_Project
{
    public class CityDataModel
    {
        public CityDataModel()
        {
            AvailableVehicles = new List<bool>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public List<bool> AvailableVehicles { get; set; }
        public string UsedVehicles { get; set; }
    }
}
