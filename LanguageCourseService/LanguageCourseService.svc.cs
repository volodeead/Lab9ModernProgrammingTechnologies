using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace LanguageCourseService
{

        public class LanguageCourseService : ILanguageCourseService
        {
            public List<Course> GetCourses()
            {
                return PopulateCourseData();
            }

            private List<Course> PopulateCourseData()
            {
                // Тут ви створите список курсів, як ми описали раніше
                List<Course> listCourses = new List<Course>();
                listCourses.Add(new Course { CourseID = 1, CourseName = "English Beginner", Price = 100.00m, StartDate = new DateTime(2024, 1, 1) });
                listCourses.Add(new Course { CourseID = 2, CourseName = "French Intermediate", Price = 150.00m, StartDate = new DateTime(2024, 2, 1) });
                return listCourses;
            }
        }

}
