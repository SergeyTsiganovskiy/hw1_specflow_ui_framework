using System;
using System.Collections.Generic;
using System.Text;

namespace solid_violations.DependencyInversion.Correct
{
    public class DataAccessFactory
    {
        public static IEmployeeDataAccess GetEmployeeDataAccessObj()
        {
            return new EmployeeDataAccess();
        }
    }
}
