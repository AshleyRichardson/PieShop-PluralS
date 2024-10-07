using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PieShop_PluralS.HR;
//different way to organize namespace. Semi-colon on end instead of {} wrapped around.

//same as class. Can use structs in place of class on programs with simple data representations.
internal struct WorkTask
{
    public string description;
    public int hours;

    public void PerformWorkTask()
    {
        Console.WriteLine($"Task {description} of {hours} hour(s) has been performed.");
    }
}

