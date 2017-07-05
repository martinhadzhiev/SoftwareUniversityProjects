using System;
using System.Linq;

public class DateModifier
{
    public static int ModifyDate(string startDate, string endDate)
    {
        var startDateArgs = startDate.Split().Select(int.Parse).ToArray();
        var endDateArgs = endDate.Split().Select(int.Parse).ToArray();

        var result = 0;

        var stD = new DateTime(startDateArgs[0], startDateArgs[1], startDateArgs[2]);
        var enD = new DateTime(endDateArgs[0], endDateArgs[1], endDateArgs[2]);

        result = enD.Subtract(stD).Days;

        return result;
    }
}

