﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class CourseRepository
    {
        private List<Course> courses = new List<Course>();

        public void AddCourse(Course course)
        {
            courses.Add(course);
        }

        public Course GetCourses(string name)
        {
            for (int i = 0; i < courses.Count; i++)
            {
                if (courses[i].Name == name)
                {
                    return courses[i];
                }
            }
            return null;
        }

        public double GetTotalValue()
        {
            double value = 0;
            for (int i = 0; i < courses.Count; i++)
            {
                value += Utility.GetValueOfCourse(courses[i]);
            }
            return value;
        }
    }
}
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Morgengry
//{

//    public class CourseRepository
//    {
//        public void AddCourse(Course c112)
//        {
//            throw new NotImplementedException();
//        }

//        public double GetTotalValue()
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
