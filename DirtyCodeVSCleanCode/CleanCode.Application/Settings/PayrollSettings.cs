using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Application.Settings
{
    public class PayrollSettings
    {
        public double StandardWorkHoursPerWeek { get; set; } = 40;
        public double OvertimeHourlyRate { get; set; } = 15.0;
        public double StandardHourlyRate { get; set; } = 10.0;
    }
}
