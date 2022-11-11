﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALProject
{
    public  class EmpInfo
    {
        [Key]
        public string Email { get; set; }
        [Required]
        public string Name { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOfJoining { get; set; }
        [Required]
        public int Passcode { get; set; }
        public virtual ICollection<BlogInfo> Blogs { get; set; }
    }
}

