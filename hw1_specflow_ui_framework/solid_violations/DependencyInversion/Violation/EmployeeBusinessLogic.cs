using System;
using System.Collections.Generic;
using System.Text;

namespace solid_violations.DependencyInversion.Violation
{
    public class EmployeeBusinessLogic
    {
        EmployeeDataAccess _EmployeeDataAccess;
        public EmployeeBusinessLogic()
        {
            _EmployeeDataAccess = DataAccessFactory.GetEmployeeDataAccessObj();
        }
        public Employee GetEmployeeDetails(int id)
        {
            return _EmployeeDataAccess.GetEmployeeDetails(id);
        }
    }
}
