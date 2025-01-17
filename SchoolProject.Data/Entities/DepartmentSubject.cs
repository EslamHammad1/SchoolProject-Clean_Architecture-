﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace SchoolProject.Data.Entities
{
    public class DepartmentSubject 
    {
        [Key]
        public int DeptSubID { get; set; }
        public int DID { get; set; }
        public int SubID { get; set; }

        [ForeignKey("DID")]
        public virtual Department Department { get; set; }

        [ForeignKey("SubID")]
        public virtual Subjects Subjects { get; set; }
    }

}