using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieApplication.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter Movie Name")]
        [StringLength(30, MinimumLength = 3)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter Date")]
        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }

        [Required(ErrorMessage = "Please Enter Movie Name")]
        public string MovieName { get; set; }
        public string Awards { get; set; }

    }
}