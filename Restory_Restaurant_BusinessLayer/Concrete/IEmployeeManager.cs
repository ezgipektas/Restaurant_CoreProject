﻿using Restory_Restaurant_BusinessLayer.Abstract;
using Restory_Restaurant_DataAccessLayer.Abstract;
using Restory_Restaurant_EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restory_Restaurant_BusinessLayer.Concrete
{
    public class IEmployeeManager : IEmployeeService
    {
        private readonly IEmployeeDal _employeeDal;

        public IEmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }

        public void TAdd(Employee t)
        {
            _employeeDal.Insert(t);
        }

        public void TDelete(Employee t)
        {
            _employeeDal.Delete(t);
        }

        public Employee TGetByID(int id)
        {
            return _employeeDal.GetByID(id);
        }

        public List<Employee> TGetList()
        {
            return _employeeDal.GetList();
        }

        public void TUpdate(Employee t)
        {
            _employeeDal.Update(t);
        }
    }
}
