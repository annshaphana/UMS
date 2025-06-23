using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model; 

namespace WindowsFormsApp1.Model
{
    public class Timetable
    {
        public int Id { get; set; }
        public string Day { get; set; }
        public string Subject { get; set; }
        public string Time { get; set; }
        public string Teacher { get; set; }
    }
}


