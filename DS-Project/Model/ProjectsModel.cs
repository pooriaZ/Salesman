using System;
using System.Collections.Generic;
using System.Text;

namespace DS_Project
{
    public class ProjectsModel
    {
        public int Id { get; set; }
        public int DayRemain { get; set; }
        public double DayNeed { get; set; }
        public double Income { get; set; }
        public int Point { get; set; } = 0;
        public bool IsProjectDone { get; set; } = false;
    }
}
