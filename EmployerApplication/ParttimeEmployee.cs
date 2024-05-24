using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployerApplication
{
    internal class ParttimeEmployee : IEmployee
    {

        private string firstname;
        private string lastname;
        private string department;
        private string jobtitle;
        private double basicsalary;





        public ParttimeEmployee(string fname, string lname, string dept, string titlejob)
        {
            this.firstname = fname;
            this.lastname = lname;
            this.department = dept;
            this.jobtitle = titlejob;


        }
        public string F_name
        {
            get
            {
                return firstname;


            }
            set

            {
                firstname = value;
            }
        }

        public string L_name
        {
            get
            {
                return lastname;


            }
            set

            {
                lastname = value;
            }
        }


        public string dept
        {
            get
            {
                return department;


            }
            set

            {
                department = value;
            }
        }



        public string job
        {
            get
            {
                return jobtitle;


            }
            set

            {
                jobtitle = value;
            }
        }

        public double salary
        {
            get
            {
                return basicsalary;


            }
            set

            {
                basicsalary = value;
            }
        }


        public void computeSalary(int hoursworked, double rateperhour)
        {
            salary = hoursworked * rateperhour;


        }

        public double getSalary()
        {
            return salary;
        }


    }
}



