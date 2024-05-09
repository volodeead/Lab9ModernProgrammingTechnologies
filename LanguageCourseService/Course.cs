using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace LanguageCourseService
{
    [DataContract(Namespace = "")]
    public class Course
    {
        [DataMember]
        public int CourseID { get; set; }

        [DataMember]
        public string CourseName { get; set; }

        [DataMember]
        public decimal Price { get; set; }

        [DataMember]
        public DateTime StartDate { get; set; }
    }

}