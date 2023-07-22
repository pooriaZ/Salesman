using System;
using System.Collections.Generic;
using System.Text;

namespace DS_Project.Utility
{
    public static class VehiclesAndProfit
    {
        public static void Vehicles(List<string> passedCities, List<CityDataModel> cities)
        {
            foreach (var item in passedCities)
            {
                var city = cities.Find(i => i.Name == item);

                if (city.AvailableVehicles[2])
                {
                    city.UsedVehicles = "Airplane";
                }
                else if (city.AvailableVehicles[1])
                {
                    city.UsedVehicles = "Train";
                }
                else
                {
                    city.UsedVehicles = "Car";
                }
            }
        }

        public static int VehiclesCost(string Vehicles, int distance)
        {
            int cost = 0;
            if (Vehicles == "Car")
            {
                cost = distance * 1000;
            }

            else if (Vehicles == "Train")
            {
                cost = distance * 500;
            }

            else
            {
                cost = 3000000;
            }

            return cost;
        }

        private static double VehiclesTime(string Vehicles, int distance)
        {
            double dayPassed = 0;

            if (Vehicles == "Car" && distance%3000 == 0)
            {
                dayPassed = distance / 3000;
            }
            else if (Vehicles == "Car" && distance%3000 != 0)
            {
                dayPassed = Math.Abs(distance / 3000) + 1;
            }
            else if (Vehicles == "Train" && distance%2500 == 0)
            {
                dayPassed = distance / 2500;
            }
            else if (Vehicles == "Train" && distance%2500 != 0)
            {
                dayPassed = Math.Abs(distance / 2500) + 1;
            }
            else
            {
                dayPassed = 0.5;
            }
                return dayPassed;
        }

        public static double Eearning(List<ProjectsModel> projectData, List<string> passedCities, 
            List<CityDataModel> cities, string Vehicles, int distance)
        {
            double earnings = 0;
            double daysPassed = 0;
            double dayPassedForTravel = VehiclesTime(Vehicles, distance);

            foreach (var item in passedCities)
            {
                var passedCityId = cities.Find(i => i.Name == item).Id;
                var passedCityProjectData = projectData.Find(i => i.Id == passedCityId);

                if (passedCityProjectData == null)
                {
                    continue;
                }

                daysPassed += passedCityProjectData.DayNeed;

                if (daysPassed > passedCityProjectData.DayRemain)
                {
                    double lossDay = passedCityProjectData.DayRemain - daysPassed;
                    passedCityProjectData.Income = (1 - (Math.Abs(lossDay) * 0.15)) * passedCityProjectData.Income;
                }
                earnings += passedCityProjectData.Income;
                daysPassed += dayPassedForTravel;
            }

            return earnings;
        }

    }
}
