using System;
using System.Collections.Generic;
using System.Text;

namespace solid_violations.DependencyInversion.Violation
{
    public class DataAccessFactory
    {
        public static EmployeeDataAccess GetEmployeeDataAccessObj()
        {
            return new EmployeeDataAccess();
        }
    }
}
