using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieApplication.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Please Enter Movie Title Name")]
        [StringLength(30,MinimumLength =3)]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please Enter Movie Date")]
        [DataType(DataType.Date)]
        public DateTime? ReleaseDate { get; set; }

        [Required(ErrorMessage = "Please Enter Producer Name")]
        public string ProducerName { get; set; }

        [Required(ErrorMessage = "Please Enter Actor Name")]
        public string Actors { get; set; }

        [Required(ErrorMessage = "Please Enter Short Description")]
        public string Description { get; set; }


    }
}