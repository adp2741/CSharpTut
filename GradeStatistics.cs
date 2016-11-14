using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class GradeStatistics
{
    public float averageGrade;
    public float lowestGrade;
    public float highestGrade;

    public string returnStatistics()
    {
        string outputString = String.Format("Average grade: {0}\nLowest grade: {1}\nHighest grade: {2}", averageGrade, lowestGrade, highestGrade);
        return outputString;
    }
}