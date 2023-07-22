using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DS_Project
{
    public class CalCulatePoints
    {
        public List<ProjectsModel> CalcProjectPoint(List<ProjectsModel> projectsModel)
        {
            var orderByIncome =
                projectsModel.OrderByDescending(i => i.Income);

            int point = 100;
            foreach (var item in orderByIncome)
            {
                item.Point += point;
                point -= 10;
            }

            var orderByDayRemain =
                projectsModel.OrderBy(i => i.DayRemain);

            point = 100;
            foreach (var item in orderByDayRemain)
            {
                item.Point += point;
                point -= 10;
            }

            var orderByDayNeed =
                projectsModel.OrderByDescending(i => i.DayNeed);

            point = 100;
            foreach (var item in orderByDayNeed)
            {
                item.Point += point;
                point -= 10;
            }

            var orderByPoints =
                projectsModel.OrderByDescending(i => i.Point).ToList();

            return orderByPoints;
        }

        public string[] ProjectPriority(List<ProjectsModel> orderedCityList, List<CityDataModel> cityDataModels)
        {
            string origin = "Tehran";

            string[] projectPriority = new string[orderedCityList.Count()];
            projectPriority[0] = origin;

            int originId = cityDataModels.Find(i => i.Name == origin).Id;

            ProjectsModel p = orderedCityList.Find(i => i.Id == originId);

            orderedCityList.Remove(p);

            int i = 0;
            foreach (var item in orderedCityList)
            {
                string cityName = cityDataModels.Find(i => i.Id == item.Id).Name;
                i++;
                projectPriority[i] = cityName;
            }

            return projectPriority;
        }
    }
}
