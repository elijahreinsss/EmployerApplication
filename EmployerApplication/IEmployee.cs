using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployerApplication
{
    internal interface IEmployee
    {
        string F_name { get; set; }
        string L_name { get; set; }
        string dept { get; set; }
        string job { get; set; }
        double salary { get; set; }
        void computeSalary(int hoursworked, double rateperhour);
    }
}
