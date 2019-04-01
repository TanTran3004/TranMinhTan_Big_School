using TranMinhTan_Big_School.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TranMinhTan_Big_School.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcomingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}