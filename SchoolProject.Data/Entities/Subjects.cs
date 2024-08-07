using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Data.Entities
{
    public class Subjects
    {
        public Subjects()
        {

        }
        public int subId { get; set; }
        [StringLength(500)]
        public string SubjectName { get; set; }
        public DateTime Period { get; set; }
    }
}
