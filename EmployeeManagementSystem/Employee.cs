using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    class Employee
    {
        private String employeeID;
        private String firstName;
        private String lastName;
        private String stAddress;
        private String city;
        private String state;
        private int zip;
        private DateTime dOB;
        private DateTime hireDate;
        private double payRate;
        private String title;
        private Boolean hasBenefits;

        public Employee()
        {

        }

        public Employee(String employeeID, String firstName, String lastName, String stAddress, String city, String state, int zip, DateTime dOB, DateTime hireDate, double payRate, String title, Boolean hasBenefits)
        {

        }

        public String EmployeeID
        {
            get;
            set;
        }

        public String FirstName
        {
            get;
            set;
        }

        public String LastName
        {
            get;
            set;
        }

        public String StAddress
        {
            get;
            set;
        }

        public String City
        {
            get;
            set;
        }

        public String State
        {
            get;
            set;
        }

        public int Zip
        {
            get;
            set;
        }

        public DateTime DOB
        {
            get;
            set;
        }

        public DateTime HireDate
        {
            get;
            set;
        }

        public Double PayRate
        {
            get;
            set;
        }

        public String Title
        {
            get;
            set;
        }

        public Boolean HasBenefits
        {
            get;
            set;
        }

    }
}
