using Microsoft.Build.Framework.XamlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace hoangthinh_2080600057.Models
{
    public class course
    {
        public int Id { get; set; }

        public ApplicationUser Lecturet { get; set; }

        public string lecturnerId { get; set; }
        [Required]
        [StringLength(255)]
        public string place { get; set; }
        public DateTime datetime { get; set; }
        public Category Category { get; set; }
        [Required]
        public byte CategoryId { get; set; }
    }
  

}








