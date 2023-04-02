using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaverecnyProjektIT4_2023
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Job { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string Phone{ get; set; }

        public Employee(int emplyoeeid, string job, string firstname, string lastname, DateTime birthdate, string email, string phone)
        {
            EmployeeId = emplyoeeid;
            Job = job;
            FirstName = firstname;
            LastName = lastname;
            BirthDate = birthdate;
            Email = email;
            Phone = phone;
        }
        public ListViewItem ToListViewItem()
        {
            return new ListViewItem(new string[] { EmployeeId.ToString(), Job, FirstName, LastName, BirthDate.Date.ToString("dd.MM.yyyy"), Email, Phone });
        }

    }
}
