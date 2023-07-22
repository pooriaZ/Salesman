using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using DS_Project.Utility;

namespace DS_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem Data

            #region Cities Data

            //AvailableVehicles : Car , Train , Airplane
            var cities = new List<CityDataModel>()
            {
                new CityDataModel() { Id = 1, Name = "Anchorace", AvailableVehicles = { true, true, true } },
                new CityDataModel() { Id = 2, Name = "Reykdavik", AvailableVehicles = { false, false, true } },
                new CityDataModel() { Id = 3, Name = "Moskva", AvailableVehicles = { true, true, false } },
                new CityDataModel() { Id = 4, Name = "Montreal", AvailableVehicles = { true, true, false } },
                new CityDataModel() { Id = 5, Name = "London", AvailableVehicles = { true, true, true } },
                new CityDataModel() { Id = 6, Name = "Istanbul", AvailableVehicles = { true, true, true } },
                new CityDataModel() { Id = 7, Name = "Khvree", AvailableVehicles = { true, false, false } },
                new CityDataModel() { Id = 8, Name = "Vladivostok", AvailableVehicles = { true, true, true } },
                new CityDataModel() { Id = 9, Name = "LA", AvailableVehicles = { true, false, true } },
                new CityDataModel() { Id = 10, Name = "New York", AvailableVehicles = { true, false, true } },
                new CityDataModel() { Id = 11, Name = "Tehran", AvailableVehicles = { true, true, true } },
                new CityDataModel() { Id = 12, Name = "Kathmandu", AvailableVehicles = { true, false, false } },
                new CityDataModel() { Id = 13, Name = "Sanduan", AvailableVehicles = { false, true, true } },
                new CityDataModel() { Id = 14, Name = "Casablanca", AvailableVehicles = { true, true, false } },
                new CityDataModel() { Id = 15, Name = "Cairo", AvailableVehicles = { true, false, true } },
                new CityDataModel() { Id = 16, Name = "Dubai", AvailableVehicles = { true, true, true } },
                new CityDataModel() { Id = 17, Name = "Hong Kong", AvailableVehicles = { true, false, true } },
                new CityDataModel() { Id = 18, Name = "Panama", AvailableVehicles = { true, true, true } },
                new CityDataModel() { Id = 19, Name = "Caracus", AvailableVehicles = { true, false, true } },
                new CityDataModel() { Id = 20, Name = "Dakar", AvailableVehicles = { true, true, true } },
                new CityDataModel() { Id = 21, Name = "Khartoum", AvailableVehicles = { true, false, false } },
                new CityDataModel() { Id = 22, Name = "Madras", AvailableVehicles = { true, true, false } },
                new CityDataModel() { Id = 23, Name = "Tokyo", AvailableVehicles = { false, true, false } },
                new CityDataModel() { Id = 24, Name = "Santiago", AvailableVehicles = { true, true, false } },
                new CityDataModel() { Id = 25, Name = "Rio de janeiro", AvailableVehicles = { true, false, true } },
                new CityDataModel() { Id = 26, Name = "Accra", AvailableVehicles = { true, false, true } },
                new CityDataModel() { Id = 27, Name = "Sangapore", AvailableVehicles = { true, false, true } },
                new CityDataModel() { Id = 28, Name = "Buenos Aires", AvailableVehicles = { true, false, false } },
                new CityDataModel() { Id = 29, Name = "Capetown", AvailableVehicles = { true, true, false } },
                new CityDataModel() { Id = 30, Name = "Nairobi", AvailableVehicles = { true, false, true } },
                new CityDataModel() { Id = 31, Name = "Batavia", AvailableVehicles = { true, true, false } },
                new CityDataModel() { Id = 32, Name = "Sydney", AvailableVehicles = { true, true, true } }
            };

            #endregion
            #region Distance Data

            int[,] distanceData = new int[,]
            {
                //City 1
                {
                    0, 5100, 0, 2550, 0, 0, 0, 6000, 3400, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                    0, 0, 0, 0
                },

                //City 2 
                {
                    5100, 0, 0, 5400, 3200, 0, 0, 0, 0, 0, 0, 0, 0, 4500, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                    0, 0, 0, 0
                },

                //City 3
                {
                    0, 0, 0, 0, 3800, 1100, 3750, 6800, 0, 0, 1800, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                    0, 0, 0, 0, 0
                },

                //City 4
                {
                    2550, 5400, 0, 0, 0, 0, 0, 0, 2800, 1600, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                    0, 0, 0, 0
                },

                //City 5
                {
                    0, 3200, 3800, 0, 0, 4800, 0, 0, 0, 0, 0, 0, 0, 1950, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                    0, 0, 0, 0
                },

                //City 6
                {
                    0, 0, 1100, 0, 4800, 0, 0, 0, 0, 0, 3500, 0, 0, 0, 1600, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                    0, 0, 0, 0
                },

                //City 7
                {
                    0, 0, 3750, 0, 0, 0, 0, 3100, 0, 0, 3400, 2550, 0, 0, 0, 0, 2550, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                    0, 0, 0, 0, 0
                },

                //City 8 
                {
                    6000, 0, 6800, 0, 0, 0, 3100, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2400, 0, 0, 0, 0, 0, 3100, 0, 0, 0, 0,
                    0, 0, 0, 0, 0
                },

                //City 9
                {
                    3400, 0, 0, 2800, 0, 0, 0, 0, 0, 2700, 0, 0, 2200, 0, 0, 0, 0, 3000, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                    0, 0, 0, 0, 0
                },

                //City 10
                {
                    0, 0, 0, 1600, 0, 0, 0, 0, 2700, 0, 0, 0, 1500, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                    0, 0, 0
                },

                //City 11
                {
                    0, 0, 1800, 0, 0, 3500, 3400, 0, 0, 0, 0, 1300, 0, 0, 0, 1600, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                    0, 0, 0, 0, 0
                },

                //City 12
                {
                    0, 0, 0, 0, 0, 0, 2550, 0, 0, 0, 1300, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1100, 0, 0, 0, 0, 3600, 0,
                    0, 0, 0, 0
                },

                //City 13
                {
                    0, 0, 0, 0, 0, 0, 0, 0, 2200, 1500, 0, 0, 0, 3200, 0, 0, 0, 2800, 1600, 3800, 0, 0, 0, 0, 0, 0,
                    0, 0, 0, 0, 0, 0
                },

                //City 14
                {
                    0, 4500, 0, 0, 1950, 0, 0, 0, 0, 0, 0, 0, 3200, 0, 2250, 0, 0, 0, 0, 1600, 0, 0, 0, 0, 0, 2550,
                    0, 0, 0, 0, 0, 0
                },

                //City 15
                {
                    0, 0, 0, 0, 0, 1600, 0, 0, 0, 0, 0, 0, 0, 2250, 0, 1200, 0, 0, 0, 0, 1800, 0, 0, 0, 0, 4800, 0,
                    0, 0, 0, 0, 0
                },

                //City 16
                {
                    0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1600, 0, 0, 0, 1200, 0, 0, 0, 0, 0, 1100, 2100, 0, 0, 0, 0, 0, 0,
                    0, 3000, 0, 0
                },

                //City 17
                {
                    0, 0, 0, 0, 0, 0, 2550, 2400, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1600, 0, 0, 0, 2850, 0,
                    0, 0, 0, 0
                },

                //City 18
                {
                    0, 0, 0, 0, 0, 0, 0, 0, 3000, 0, 0, 0, 2800, 0, 0, 0, 0, 0, 1300, 0, 0, 0, 8000, 4750, 3200, 0,
                    0, 0, 0, 0, 0, 4500
                },

                //City 19
                {
                    0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1600, 0, 0, 0, 0, 1300, 0, 0, 0, 0, 0, 0, 2400, 0, 0, 0, 0,
                    0, 0, 0
                },

                //City 20
                {
                    0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3800, 1600, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5000, 1600, 0, 0,
                    0, 0, 0, 0
                },

                //City 21
                {
                    0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1800, 1100, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                    1400, 0, 0
                },

                //City 22
                {
                    0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1100, 0, 0, 0, 2100, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2400, 0, 0,
                    0, 0, 0
                },

                //City 23
                {
                    0, 0, 0, 0, 0, 0, 0, 3100, 0, 0, 0, 0, 0, 0, 0, 0, 1600, 8000, 0, 0, 0, 0, 0, 0, 0, 0, 4250, 0,
                    0, 0, 0, 0
                },

                //City 24
                {
                    0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 4750, 0, 0, 0, 0, 0, 0, 2550, 0, 0, 1600, 0,
                    0, 0, 3600
                },

                //City 25
                {
                    0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3200, 2400, 5000, 0, 0, 0, 2550, 0, 0, 0,
                    3200, 3300, 0, 0, 0
                },

                //City 26
                {
                    0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2550, 4800, 0, 0, 0, 0, 1600, 0, 0, 0, 0, 0, 0, 0, 0,
                    8000, 2400, 0, 0
                },

                //City 27
                {
                    0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3600, 0, 0, 0, 0, 2850, 0, 0, 0, 0, 2400, 4250, 0, 0, 0, 0, 0,
                    0, 0, 1600, 2800
                },

                //City 28
                {
                    0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1600, 3200, 0, 0, 0, 0, 0,
                    0, 0
                },

                //City 29
                {
                    0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3300, 8000, 0, 0, 0,
                    3400, 6400, 0
                },

                //City 30
                {
                    0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3000, 0, 0, 0, 0, 1400, 0, 0, 0, 0, 2400, 0, 0,
                    3400, 0, 9600, 0
                },

                //City 31
                {
                    0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1600, 0, 6400,
                    9600, 0, 3200
                },

                //City 32
                {
                    0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 4500, 0, 0, 0, 0, 0, 3600, 0, 0, 2800, 0, 0,
                    0, 3200, 0
                },
            };

            #endregion
            #region Project Data

            var ProjectsData = new List<ProjectsModel>()
            {
                new ProjectsModel() { Id = 20, DayRemain = 19, DayNeed = 0.5, Income = 5000000 },
                new ProjectsModel() { Id = 32, DayRemain = 10, DayNeed = 2, Income = 6800000 },
                new ProjectsModel() { Id = 1, DayRemain = 21, DayNeed = 1, Income = 4500000 },
                new ProjectsModel() { Id = 23, DayRemain = 27, DayNeed = 2.5, Income = 6300000 },
                new ProjectsModel() { Id = 2, DayRemain = 21, DayNeed = 3, Income = 3400000 },
                new ProjectsModel() { Id = 29, DayRemain = 21, DayNeed = 3.5, Income = 5600000 },
                new ProjectsModel() { Id = 11, DayRemain = 15, DayNeed = 1.5, Income = 2000000 },
                new ProjectsModel() { Id = 28, DayRemain = 21, DayNeed = 4.5, Income = 8000000 },
                new ProjectsModel() { Id = 18, DayRemain = 13, DayNeed = 2.5, Income = 4700000 },
                new ProjectsModel() { Id = 8, DayRemain = 28, DayNeed = 2, Income = 6100000 },
            };

            #endregion

            CalCulatePoints cp = new CalCulatePoints();
            var orderByPoints = cp.CalcProjectPoint(ProjectsData);

            var citiesNavigationOrder = cp.ProjectPriority(orderByPoints, cities);

            List<string> projectsArrangement = new List<string>();
            List<string> passedCities = new List<string>();

            var srcIndex = 0;
            var dstIndex = 1;

            for (int i = 0; i < citiesNavigationOrder.Length - 1; i++)
            {
                var srcId = cities.Find(i => i.Name == citiesNavigationOrder[srcIndex]).Id;
                var dstId = cities.Find(i => i.Name == citiesNavigationOrder[dstIndex]).Id;

                if (ProjectsData.Find(i => i.Id == dstId).IsProjectDone == true)
                {
                    srcIndex++;
                    dstIndex++;
                    continue;
                }
                else
                {
                    var sp = ShortestPath.dijkstra(distanceData, srcId - 1);
                    var sptn = ShortestPath.ShortestPathTwoNodes(srcId, dstId, sp);


                    foreach (var item in sptn)
                    {
                        var cityName = cities.Find(i => i.Id == item).Name;
                        passedCities.Add(cityName);
                        for (int j = 0; j < passedCities.Count - 1; j++)
                        {
                            if (passedCities[j] == passedCities[j + 1])
                            {
                                passedCities.Remove(passedCities[j + 1]);
                            }
                        }
                    }


                    foreach (var item in sptn)
                    {
                        var proj = ProjectsData.Find(i => i.Id == item);
                        if (proj == null)
                        {
                            continue;
                        }
                        else if (!proj.IsProjectDone)
                        {
                            proj.IsProjectDone = true;
                            var projectInProgress = cities.Find(i => i.Id == proj.Id).Name;
                            projectsArrangement.Add(projectInProgress);
                        }
                        else
                        {
                            continue;
                        }
                    }
                }

                srcIndex++;
                dstIndex++;
            }

            VehiclesAndProfit.Vehicles(passedCities, cities);

            double earnings = 0;
            for(int i = 0; i < passedCities.Count - 1 ; i++)
            {
                var source = passedCities[i];
                var destination = passedCities[i + 1];

                var sourceData = cities.Find(i => i.Name == source);
                var destinationData = cities.Find(i => i.Name == destination);


                double income = VehiclesAndProfit.Eearning(ProjectsData, passedCities,cities, sourceData.UsedVehicles, distanceData[sourceData.Id - 1, destinationData.Id - 1]);
                earnings += income;
                int cost = VehiclesAndProfit.VehiclesCost(sourceData.UsedVehicles, distanceData[sourceData.Id - 1, destinationData.Id - 1]);
                earnings -= cost;
            }

            int k = 0;
            foreach (var item in passedCities)
            {
                var startId = cities.Find(i => i.Name == passedCities[k]).Id;
                var endId = cities.Find(i => i.Name == passedCities[k + 1]).Id;
                var distance = distanceData[startId - 1,endId - 1];
                Console.WriteLine($"{item}     {distance}");
                if (k == passedCities.Count - 2)
                {
                    continue;
                }
                else
                {
                    k++;
                }
            }

            Console.WriteLine($"Profit : {earnings}");

            Console.ReadKey();
        }
    }
}
