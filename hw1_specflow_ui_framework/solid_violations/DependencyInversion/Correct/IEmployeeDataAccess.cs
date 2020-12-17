using System;
using System.Collections.Generic;
using System.Text;

namespace solid_violations.DependencyInversion.Correct
{
    public interface IEmployeeDataAccess
    {
        Employee GetEmployeeDetails(int id);
    }
}
