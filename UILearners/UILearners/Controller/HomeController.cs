using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UILearners.Controller
{
    public class HomeController
    {

        public string name { get; set; }
        public int pay { get; set; }
        //This method is Calculating the monthly salary of an employee.
        public int PermEmpMonthlySalary()
        {
            string name = string.Empty;
            pay = 1233;
            double doub = 1232.93;
            decimal decim = 23234523452344234452344523423.523454M;
            float flo = 232345234523442344523445234238907907898.523454F;
            name = "Bhuvan";
            return pay;
        }
        public void ContEmpMonthlySalary()
        {
            //string salary = string.Empty;
            string name = string.Empty;
            pay = 1233;
        }
        public void TempEmpMonthlySalary()
        {
            //string salary = string.Empty;
            string name = string.Empty;
            pay = 1233;
        }
    }
    public class HomeController2
    {
        //order of the parameters
        //type of the parameters
        //number of the parameters
        public void Method1(int age, string samsung)
        {

        }
        public void Method1(int number)
        {

        }
    }
    public class HomeController3
    {
        public void Method1()
        {

        }
    }
    public class HomeController4
    {
        public void Method1()
        {

        }
    }
}