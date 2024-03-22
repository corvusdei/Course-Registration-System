using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Registration_System
{

    // Possible Course Types for ICourse Interface
    public enum CourseType
    {
        Mathematics,
        Literature,
        Science,
        History
    }
    public interface ICourse
    {
        string CourseName { get; }
        CourseType Type { get; }
        string CourseDescription { get; }
    }

}