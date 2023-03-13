using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Course
    {
        public string Title { get; set; }
        public double Credits { get; set; }
        public List<string> DaysOfWeek { get; set; }
        public Dictionary<string, int> Book { get; set; }
        public List<Student> Students { get; set; }

        public Course(string title, double credits, List<string> daysOfWeek, Dictionary<string, int> book, List<Student> students)
        {
            Title = title;
            Credits = credits;
            DaysOfWeek = daysOfWeek;
            Book = book;
            Students = students;
        }
    }

}
