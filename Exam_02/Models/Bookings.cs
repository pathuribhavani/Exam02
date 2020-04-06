using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exam_02.Models
{
    public enum Rating
    {
        A, B, C, D, F
    }

    public class Booking
    {
        [Key]
       
        public int BookingID { get; set; }
        public int TheaterID { get; set; }
        public int MovieID { get; set; }
        public Rating? Rating { get; set; }

        public virtual Theater Theater { get; set; }
        public virtual Movie Movie { get; set; }
    }
}