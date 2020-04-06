using Exam_02.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exam_02.Models
{
    public class Theater
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]

        public int TheaterID { get; set; }
        public string theaterName { get; set; }

        public String Address { get; set; }

       



        public virtual ICollection<Booking> Bookings { get; set; }


    }
}