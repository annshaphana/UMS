using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Controllers;


namespace WindowsFormsApp1.Models
{
    public class Student
    {
        
        public string Name { get; set; }
        public string Address { get; set; }
        public int StudentID { get; internal set; }
    }


}
