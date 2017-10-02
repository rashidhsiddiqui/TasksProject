using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TasksProjectMVC5App.Models
{
    public class Task
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name="Name")]
        public string name { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Description")]
        public string description { get; set; }

        [Required]
        public DateTime dateCreated { get; set; }

        public DateTime? dateUpdated { get; set; }
    }
}