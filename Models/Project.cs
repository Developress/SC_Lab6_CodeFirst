using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.Models
{
    class Project
    {
        public int ProjectID { get; set; }
        public string ProjectName { get; set; }
        public string CustomerName { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public ICollection<Person> People { get; set; }
    }
}
