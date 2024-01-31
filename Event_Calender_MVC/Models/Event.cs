using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Event_Calender_MVC.Models
{
    public class Event
    {
        [Key]
        public int event_id { get; set; }
        
        [Required]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "event name only conains letters.")]
        [StringLength(20, ErrorMessage = "Event name is too long")]
        public string? event_name { get; set; }
        public string? event_description { get; set; }
        public DateTime start_date { get; set; }
        public DateTime? end_date { get; set;}

        [Required(ErrorMessage ="Color required")]
        public string? themecolor { get; set;}
        public bool isfullday { get; set; }
    }
}
