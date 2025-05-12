using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentMarksCalculator
{
    public static class StudentCalculator
    {
        public static double CalculateAverage(List<(string Name, int Grade)> students)
        {
            return students.Average(s => s.Grade);
        }

        public static (string Name, int Grade) GetHighestScore(List<(string Name, int Grade)> students)
        {
            return students.OrderByDescending(s => s.Grade).First();
        }

        public static (string Name, int Grade) GetLowestScore(List<(string Name, int Grade)> students)
        {
            return students.OrderBy(s => s.Grade).First();
        }





        
    }
}
