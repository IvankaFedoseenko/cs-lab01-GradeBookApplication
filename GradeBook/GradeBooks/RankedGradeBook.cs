using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Ranked;
            Name = name;
        }
        public override char GetLetterGrade(double averageGrade)
        {
            foreach (var student in Students)
            {
                int countStudents = 0;
                if(student != null)
                {
                    countStudents++;
                }
                double topStudents = 1;
                if(student.AverageGrade > averageGrade)
                {
                    topStudents = student.AverageGrade;
                }
                else
                {
                    topStudents++;
                }
                if(topStudents <= countStudents * 20 / 100)
                {
                    return 'A';
                }
                if(topStudents <= countStudents * 40 / 100)
                {
                    return 'B';
                }
                if (topStudents <= countStudents * 60 / 100)
                {
                    return 'C';
                }
                if (topStudents <= countStudents * 80 / 100)
                {
                    return 'D';
                }
                else
                {
                    return 'F';
                }

            }
        }
    }
}
