using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestSharp.Serializers;

namespace HighriseApi.Models.Enums
{
    public enum Frame
    {
        today,
        tomorrow,
        this_week,
        next_week,
        later,
        specific,
		overdue
    }
}
