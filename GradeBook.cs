using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class GradeBook
{
    private List<float> allGrades = new List<float>();

    public GradeBook()
    {
        System.Console.WriteLine("You made a grade book.");
    }

    public void addGrade(float grade)
    {
        allGrades.Add(grade);
    }

    public GradeStatistics computeStatistics()
    {
        GradeStatistics stats = new GradeStatistics();

        stats.averageGrade = allGrades.Average();
        stats.highestGrade = allGrades.Max();
        stats.lowestGrade = allGrades.Min();

        return stats;
    }
}