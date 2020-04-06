using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exam_02.Models
{
    public class Movie
    {
        [Key]

        public int MovieID { get; set; }
        public string movieName { get; set; }
        
        public DateTime ReleaseDate { get; set; }
        public String genre { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; }
    }
}