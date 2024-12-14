using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace MVCClient.Models
{
    public class Movies
    {
        [Required(ErrorMessage ="MovieId is Required")]
        public string MovieId { get; set; }
        [Required(ErrorMessage = "Title is Required")]
        public string Title { get; set; }
        [Required(ErrorMessage = "ReleaseDate is Required")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [Required(ErrorMessage = "Actor is Required")]
        public string Actor { get; set; }
        [Required(ErrorMessage = "Director is Required")]
        public string Director { get; set; }

    }
}